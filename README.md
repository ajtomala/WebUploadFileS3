# Uploading Files to Amazon S3 in ASP.NET Core with Razor Pages 📁🌩️

## Descripción

This project is a web application developed in ASP.NET Core using Razor Pages. It allows users to upload files to Amazon S3, the AWS cloud storage service. This solution is ideal for managing and storing files securely and efficiently in the cloud.🚀

## Technologies Used

- **ASP.NET Core**: Framework for building modern and scalable web applications.
- **Razor Pages**: Simplifies UI development in ASP.NET Core, providing a cleaner, more manageable code structure.
- **Amazon S3**: Cloud storage service offering high durability, availability and scalability.
- **Amazon S3 SDK for .NET**: Provides simple and direct integration with AWS services.

## Features.

1. **File Upload Form**: Allows users to select and upload files from their device.
2. **File Management in S3**: Ability to upload files from an Amazon S3 bucket. 📄➡️🌩️
3. **Security and Configuration**: Secure handling of AWS credentials and bucket configuration via `appsettings.json`.🔒

## Initial Configuration
1. **Framework version for .NET**:
![image](https://github.com/user-attachments/assets/6537d05f-93e9-46d5-9c4a-e9b731fe6f37)
  
2. **Install the AWS SDK for .NET**:
 ![image](https://github.com/user-attachments/assets/7e45dfef-6319-4e3e-9109-7bfee08448df)

2. **Configure appsettings.json**:
{
  “AWS": {
    “AccessKey": ‘taccess-key-id’,
    “secretKey": ‘secret-access-key’,
    “bucketName": ‘bucket-name’,
    “Region": ”us-west-1”
  }
}
