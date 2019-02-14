using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace EolCopy.Data_Processing
{
    class DataProcessor
    {
        
        private DataTable datovaTabulka;
        private List<Typ> tabulkaTypu;
        private FileInfo[] soubory;

        public DataProcessor(string cesta) // cesta je cesta ke složce
        {
            datovaTabulka = new DataTable();
            tabulkaTypu = new List<Typ>();
            soubory = NactiSoubory(cesta);

        }

        public void PridejTyp(Typ typ)
        {
            tabulkaTypu.Add(typ);
        }

        private FileInfo[] NactiSoubory(string cesta)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(cesta);
            return dirInfo.GetFiles();
        }

        public void NactiTypy()
        {
            foreach (FileInfo soubor in soubory)
            {
                tabulkaTypu.Add(new Typ(soubor.FullName));
            }
        }
        
        public void NactiTypy(string cesta)
        {
            NactiSoubory(cesta);
            NactiTypy();
        }


    }
}
