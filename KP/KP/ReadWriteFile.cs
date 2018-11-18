using System.Collections.Generic;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Windows.Forms;
using System;

namespace KP
{
    public static class ReadWriteFile
    {
        private static DataContractJsonSerializer jsonFormatter;

        static ReadWriteFile()
        {
            jsonFormatter = new DataContractJsonSerializer(typeof(Triangle[]));
        }

        public static void ReadFile(ref ListBox listBox_Triangles, ref Picture picture, ref int counter, string Path)
        {
            if (new FileInfo(Path).Length <= 2) throw new FileException("Файл пуст.");

            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                Triangle[] arrayOutput = (Triangle[])jsonFormatter.ReadObject(fs); 
                foreach (Triangle obj in arrayOutput)
                {
                    if (obj.A > 100000 || obj.B > 100000 || obj.C > 100000 || obj.Angle == Math.PI)
                        throw new FileException("Файл содержит треугольник с недопустимыми параметрами.");
                    listBox_Triangles.Items.Add($"Треугольник №{++counter} ({obj.Type})");
                    picture.Add(obj);
                }
            }
        }

        public static void WriteInFile(List<Triangle> list, string Path)
        {
            using (FileStream fs = new FileStream(Path, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, list.ToArray());
            }
        }
    }
}
