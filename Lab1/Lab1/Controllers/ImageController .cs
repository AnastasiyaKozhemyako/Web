﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.DAL.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class ImageController : Controller
    {
        UserManager<ApplicationUser> _userManager;
        IWebHostEnvironment _env;
        public ImageController(UserManager<ApplicationUser>
       userManager, IWebHostEnvironment env)
        {
            _userManager = userManager;
            _env = env;
        }
        public async Task<FileResult> GetAvatar()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user.AvatarImage != null)
                return File(user.AvatarImage, "image/...");
            else
            {
                var avatarPath = "/Images/BA2fOx8VU1M.jpg";

                return File(_env.WebRootFileProvider
                .GetFileInfo(avatarPath)
               .CreateReadStream(), "image/...");
            }
        }
    }
}
