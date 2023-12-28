using CsvHelper;
using Sprint2_Attempt3.Dungeon;
using Sprint2_Attempt3.Enemy;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Sprint2_Attempt3.Inventory
{
    internal class SaveFileLoader
    {
        private static SaveFileLoader instance = new SaveFileLoader();
        public static int numCounts { get; } = 15;
        private static String[] files = new String[] { 
            "../../../Inventory/SaveFiles/Standard.csv",
            "../../../Inventory/SaveFiles/SaveFile1.csv",
            "../../../Inventory/SaveFiles/SaveFile2.csv",
            "../../../Inventory/SaveFiles/SaveFile3.csv",
        };
        private static int fileNum = 0;

        public static SaveFileLoader Instance
        {
            get
            {
                return instance;
            }
        }
        public SaveFileLoader()
        {
        }

        public float[] LoadFile(int i)
        {
            float[] counts = new float[numCounts];
            StreamReader sr = new StreamReader(files[i]);
            while (!sr.EndOfStream)
            {
                for (int x = 0; x < numCounts; x++)
                {
                    var line = "";
                    try { line = sr.ReadLine(); } 
                    catch { Console.WriteLine("Save File Incorrectly Formatted"); }
                    if (line != null)
                    {
                        var words = line.Split(",");
                        try { counts[x] = float.Parse(words[0]); }
                        catch { Console.WriteLine("Save File Incorrectly Formatted"); }
                    }
                }
            }
            sr.Close();
            return counts;
        }

        public void SaveFile(float[] counts) {
            StreamWriter stringWriter = new StreamWriter(files[fileNum]);
            CsvWriter csvWriter = new CsvWriter(stringWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(counts);
            stringWriter.Close(); 
        }

        public void SetFileNum(int i) {
            if (i >= 1 && i < files.Length) {
                fileNum = i;
            }
        }

        public static int GetFileNum() { return fileNum; }
    }
}
