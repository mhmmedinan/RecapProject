﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Core.Results;

namespace Core.Utilities.FileHelper
{
    public class FileHelper
    {
        public static string AddAsync(IFormFile file) 
        {
            var result = newPath(file);

            try
            {
                var sourcePath = Path.GetTempFileName();

                using (var stream = new FileStream(sourcePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                File.Move(sourcePath, result.newPath);
            }
            catch (Exception exception)
            {

                return exception.Message;
            }

            return result.Path2;
        }

        public static string UpdateAsync(string sourcePath,IFormFile file) 
        {

            var result = newPath(file);
            try
            {
               

                if (sourcePath.Length > 0)
                {
                    using (var stream = new FileStream(result.newPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                }

                File.Delete(sourcePath);
            }
            catch (Exception excepiton)
            {
                return excepiton.Message;
            }

            return result.Path2;

        }
        public static IResult DeleteAsync(string path)
        {
            try
            {
                File.Delete(path);
            }
            catch (Exception exception)
            {
                return new ErrorResult(exception.Message);
            }

            return new SuccessResult();
        }
        public static(string newPath,string Path2) newPath(IFormFile file) 
        {

            System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.FileName);
            string fileExtension = fileInfo.Extension;

            var creatingFileName = Guid.NewGuid().ToString("N") + fileExtension;
            string result = $@"{Environment.CurrentDirectory + @"\wwwroot\Images"}\{creatingFileName}";

            return (result, $"\\Images\\{creatingFileName}");

        }
    }
}
