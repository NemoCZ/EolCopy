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

        public DataProcessor(string cesta)
        {
            datovaTabulka = new DataTable();
            

        }

        public Typ NactiDataZeSouboru(string cesta)
        {
            Typ typ = new Typ(1); //todo: cislo typu nacitat z nazvu souboru
            StreamReader sr = new StreamReader(cesta);
            bool prvniRadek = true;
            string[] popisky;
            List<string[]> radky = new List<string[]>();
            while (sr.Peek() >= 0)
            {
                if (prvniRadek)
                {
                    string prvni = sr.ReadLine();
                    popisky = prvni.Split(';');
                }

                radky.Add(sr.ReadLine().Split(';')); //jednotlive pozice jsou ve formě pole stringů, mimochodem je důležité přečíst všechno jinak tento while nikdy
                // nedoběhne

                prvniRadek = false;

            }
            
            return null;
        }
    }
}
