using System.IO;
using System;

class Program
{
    public static void IsThereAnA(string text)
    {
        bool contem = text.Contains('a') || text.Contains('A');
        if (contem)
        {
            Console.WriteLine($"O texto contém a letra 'a' maiúscula ou minúscula {text.Count(c => c == 'a' || c == 'A')} vezes");
        }
        else
        {
            Console.WriteLine("O texto não contém a letra 'A'");
        }
    }

    static void Main(string[] args)
    {
        string filePath = @"consulta.txt";
        
        try
        {
            // Lê todo o conteúdo do arquivo
            string content = File.ReadAllText(filePath);
            IsThereAnA(content);
        }
        catch (Exception e)
        {
            Console.WriteLine($"Erro ao ler o arquivo: {e.Message}");
        }
    }
}


