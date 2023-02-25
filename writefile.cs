using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    /// <summary>
    /// Программа для записи текста в файл
    /// </summary>
    internal class writefile
    {
        /// <summary>
        /// Запись текста в txt файл
        /// </summary>
        /// <param name="fileNamewrite"></param>
        /// <param name="result"></param>
        public static void writetxt(string fileNamewrite, string result)
        {
            File.WriteAllText(fileNamewrite, result);
        }
    }
}
