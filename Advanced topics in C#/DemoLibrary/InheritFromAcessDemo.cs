namespace DemoLibrary
{
    class InheritFromAcessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo();
            InternalDemo();
            PrivateProtectedDemo();
            PublicDemo();
            // I cannot call the private methods
        }
    }
}
