namespace DemoLibrary
{
    public class AccessDemo
    {
        private void Demo()
        {
            PrivateDemo();
        }

        //Can only be called from other items in this class
        private void PrivateDemo()
        {

        }

        // It is available in AccessDemo and ervery class (in this namespace) which derived from this class
        // It is private when it is autside the Assembly and protected when it is used inside the Assembly
        private protected void PrivateProtectedDemo()
        {

        }
        // it use allot when Inherit a class
        // You can access it in this class or in any method inside a class which derived from this class
        protected void ProtectedDemo()
        {

        }

        //Can be called every where inside the namespace
        // And also from everywhere it is inherited
        protected internal void ProtectedInternalDemo()
        {

        }

        //Can only be called inside the namespace (Assembly or Project)
        internal void InternalDemo()
        {

        }

        //is Accessable from everywhere
        public void PublicDemo()
        {

        }
    }
}
