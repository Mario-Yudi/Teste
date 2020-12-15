using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Teste03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopiarImagemController : ControllerBase
    {
        public static string sourceDirectory = @"C:\imagens";
        public static string destDirectory = @"c:\imagenscopia";
        //DirectoryInfo destdir = new DirectoryInfo(destDirectory);

        public DirectoryInfo destdir = Directory.CreateDirectory(destDirectory);

        DirectoryInfo dir = new DirectoryInfo(sourceDirectory);
        public string[] files = Directory.GetFiles(sourceDirectory).Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg")).ToArray();


    // GET: api/<CopiarController>
    [HttpGet]
        public IEnumerable<CopiarImagem> Get()
        {
            //foreach (FileInfo fi in dir.GetFiles())
            //{
            //    string ArquivoDestino = Path.Combine(destDirectory, fi);
            //    fi.CopyTo(ArquivoDestino, false);
            //}

            foreach (string arq in files)
            {
                string fileName = Path.GetFileName(arq);
                string ArquivoDestino = Path.Combine(destDirectory, fileName);
                System.IO.File.Copy(arq, ArquivoDestino, false);
            }

            var rng = new Random();
            return Enumerable.Range(0, files.Length).Select(index => new CopiarImagem
            {
                ArquivoOrigem = files[rng.Next(files.Length)]

            })
            .ToArray();


        }
    }
}

