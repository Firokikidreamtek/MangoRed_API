namespace RedMango_API.Services
{
    public interface IBlobService
    {
        Task<string> UploadBlob(IFormFile file);
    }
}
