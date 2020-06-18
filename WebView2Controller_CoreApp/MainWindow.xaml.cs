using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Web.WebView2.Core;

namespace WebView2Controller_CoreApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WebView.NavigationStarting += EnsureHttps;
            InitializeAsync();
        }

        public async void InitializeAsync()
        {
            await WebView.EnsureCoreWebView2Async(null);
            WebView.CoreWebView2.WebMessageReceived += UpdateAddressBar;

            await WebView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(window.document.URL);");
            await WebView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener(\'message\', event => alert(event.data));");
        }

        public void UpdateAddressBar(object? sender, CoreWebView2WebMessageReceivedEventArgs args)
        {
            var uri = args.TryGetWebMessageAsString();
            AddressBar.Text = uri;
            WebView.CoreWebView2.PostWebMessageAsString(uri);
        }

        public void EnsureHttps(object? sender, CoreWebView2NavigationStartingEventArgs args)
        {
            var uri = args.Uri;
            if (uri.StartsWith("https://")) return;
            WebView.CoreWebView2.ExecuteScriptAsync($"alert('{uri} is not safe, try an https link!')");
            args.Cancel = true;
        }

        private void ButtonGo_OnClick(object sender, RoutedEventArgs e)
        {
            WebView?.CoreWebView2?.Navigate(AddressBar.Text);
        }
    }
}
