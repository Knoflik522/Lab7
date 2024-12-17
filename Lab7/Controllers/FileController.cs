using Microsoft.AspNetCore.Mvc;
using System.Text;

namespace Lab7.Controllers
{
    public class FileController : Controller
    {
        // GET: File/DownloadFile
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        // POST: File/DownloadFile
        [HttpPost]
        public IActionResult DownloadFile(string firstName, string lastName, string fileName)
        {
            // Перевірка: Якщо ім'я файлу не введено - дефолтне значення
            if (string.IsNullOrEmpty(fileName))
            {
                fileName = "DefaultFileName";
            }

            
            var fileContent = $"Ім'я: {firstName}\nПрізвище: {lastName}";
            var bytes = Encoding.UTF8.GetBytes(fileContent);

            
            return File(bytes, "text/plain", $"{fileName}.txt");
        }
    }
}
