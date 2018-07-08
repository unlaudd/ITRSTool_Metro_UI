using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRSTool_Metro_UI
{
    class FileIO
    {
        static public void saveAsOwnTextFormat(string filename, string textToSave)
        {
            //Создаём или перезаписываем существующий файл
            StreamWriter sw = File.CreateText(filename);
            //Записываем текст в поток файла
            sw.WriteLine(textToSave);
            //Закрываем файл
            sw.Close();
        } 
        
    }
}
