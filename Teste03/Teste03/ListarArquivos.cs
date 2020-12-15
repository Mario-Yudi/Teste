using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Teste03
{
    public static class ListarArquivos
    {
        //public static string sourceDirectory = @"C:\imagens";

        public static string[] arquivos = System.IO.Directory.GetFiles(@"C:\imagens").Where(s => s.EndsWith(".png") || s.EndsWith(".jpg") || s.EndsWith(".jpeg")).ToArray();

        public static int qtd = arquivos.Length;
    }
}
