namespace WebUploadFileS3.Interfaces
{
    public interface IRepositoryS3
    {
        Task<string> UploadFileAsync(IFormFile file);
    }
}
