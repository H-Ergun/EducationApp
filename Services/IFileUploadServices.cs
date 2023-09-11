﻿using Microsoft.AspNetCore.Identity;

namespace EducationApp.Services
{
    public interface IFileUploadServices
    {

        public string Save(IFormFile file, string userId, string trainingName);

        public string Save(IFormFile file, string userId, string trainingName, string contentName);

    }
}
