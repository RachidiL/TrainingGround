using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreFoundation;
using Foundation;
using SystemConfiguration;
using TestProjectXamarin.Data;
using TestProjectXamarin.iOS.Data;
using UIKit;

[assembly: Xamarin.Forms.Dependency(typeof(NetworkConnection))]

namespace TestProjectXamarin.iOS.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; private set; }
        private NetworkReachability defaultReachability;
        private EventHandler ReachabilityChanged;
        public void CheckNetworkConnection()
        {
            InternetStatus();
        }

        private bool InternetStatus()
        {
            NetworkReachabilityFlags flags;
            bool defaultNetworkAvailable = IsNetworkAvailable(out flags);
            if (defaultNetworkAvailable && ((flags & NetworkReachabilityFlags.IsDirect) != 0))
                return false;
            else if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                return true;
            else if (flags == 0)
                return false;
            return true;
        }

        private bool IsNetworkAvailable(out NetworkReachabilityFlags flags)
        {
            if(defaultReachability == null)
            {
                defaultReachability = new NetworkReachability(new System.Net.IPAddress(0));
                defaultReachability.SetNotification(OnChangedReachability);
                defaultReachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
            }
            if (!defaultReachability.TryGetFlags(out flags))
                return false;

            return IsReachableWithoutRequiringConnection(flags);
        }

        private bool IsReachableWithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            bool isReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;
            bool noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

            if ((flags & NetworkReachabilityFlags.IsWWAN) != 0)
                noConnectionRequired = true;
            return isReachable && noConnectionRequired;
        }

        private void OnChangedReachability(NetworkReachabilityFlags flags)
        {
            var h = ReachabilityChanged;
            if (h != null)
                h(null, EventArgs.Empty);
        }
    }
}