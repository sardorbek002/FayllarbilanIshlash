using System.Xml.Serialization;

namespace Exam_5_Modul;

public class First
{
   public void Run()
    {
        // Manbani (boshlang'ich direktoriya) va maqsad direktoriyaning manzilini aniqlang
        string sourceDirectory = @"C:\Users\Noutbuk Savdosi\Desktop\Exam5_Modul\Kochirildi";
        string destinationDirectory = @"C:\Users\Noutbuk Savdosi\Desktop\Exam5_Modul\Kochirdi";

        // Manba direktoriyaning ichidagi barcha fayllarni ko'chirish
        string[] files = Directory.GetFiles(sourceDirectory);
        foreach (string file in files)
        {
            string fileName = Path.GetFileName(file);
            string destinationPath = Path.Combine(destinationDirectory, fileName);
            File.Copy(file, destinationPath);
        }

        // Manba direktoriyaning ichidagi barcha direktoriyalarni ko'chirish
        string[] directories = Directory.GetDirectories(sourceDirectory, "*", SearchOption.AllDirectories);
        foreach (string directory in directories)
        {
            string relativePath = Path.GetRelativePath(sourceDirectory, directory);
            string destinationDir = Path.Combine(destinationDirectory, relativePath);
            Directory.CreateDirectory(destinationDir);
        }

        Console.WriteLine("Fayllar va direktoriyalar ko'chirildi.");
    }




}
