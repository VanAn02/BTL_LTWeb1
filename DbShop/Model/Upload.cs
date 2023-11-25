﻿using CloudinaryDotNet.Actions;
using CloudinaryDotNet;

namespace DbTravel.Api.Model
{
    public class Upload
    {
        private readonly Cloudinary _cloudinary;
        public Upload(Cloudinary cloudinary)
        {
            _cloudinary = cloudinary;
        }
        public string ImageUpload(IFormFile? hinhAnh)
        {
            if (hinhAnh != null && hinhAnh.Length > 0)
            {
                using (var stream = hinhAnh.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams
                    {
                        File = new FileDescription(hinhAnh.FileName, stream),
                        Transformation = new Transformation().Width(500).Height(500).Crop("fill"),
                    };

                    try
                    {
                        var uploadResult = _cloudinary.Upload(uploadParams);
                        return uploadResult.SecureUrl.ToString();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi tải lên hình ảnh: {ex.Message}");
                    }
                }
            }

            return null;
        }
    }
}
