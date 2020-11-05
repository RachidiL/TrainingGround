namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        int TotalDownloadLeft { get; }
    }
}