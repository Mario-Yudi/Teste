using System;
using System.IO;
using System.Text.RegularExpressions;

namespace TelefonePadrao
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourceDirectory = @"C:\Temp";

            try
            {
                var txtFiles = Directory.EnumerateFiles(sourceDirectory, "*.txt*", SearchOption.AllDirectories);

                foreach (string currentFile in txtFiles)
                {
                    string fileName = currentFile.Substring(sourceDirectory.Length + 1);
                    string linha;
                    string arquivo = @"C:\TEMP\"+fileName;
                    Regex rgx = new Regex(@"^\([1-9]{2}\) (?:[2-8]|9[1-9])[0-9]{3}\-[0-9]{4}$");
                    using (StreamReader reader = new StreamReader(arquivo))
                    {
                        linha = reader.ReadLine();
                        if (rgx.IsMatch(linha))
                        {
                            Console.WriteLine("Número de Telefone no formato correto: " + linha);
                            Console.WriteLine("Arquivo: " + fileName);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
