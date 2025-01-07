using WebUploadFileS3.Interfaces;
using Amazon.S3;
using Amazon.S3.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace WebUploadFileS3.implementation
{
    public class RespositoryS3 : IRepositoryS3
    {
        private readonly IAmazonS3 _s3Client;
        private readonly string _bucketName;

        public RespositoryS3(IConfiguration configuration)
        {
            var accessKey = configuration["AWS:AccessKey"];
            var secretKey = configuration["AWS:SecretKey"];
            var region = configuration["AWS:Region"];
            _bucketName = configuration["AWS:BucketName"];

            _s3Client = new AmazonS3Client(accessKey, secretKey, Amazon.RegionEndpoint.GetBySystemName(region));
        }
        public async Task<string> UploadFileAsync(IFormFile file)
        {
            using var newMemoryStream = new MemoryStream();
            file.CopyTo(newMemoryStream);

            var request = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = file.FileName,
                InputStream = newMemoryStream,
                ContentType = file.ContentType,
                AutoCloseStream = true
            };
            await _s3Client.PutObjectAsync(request);
            return file.FileName;
        }
    }
}
