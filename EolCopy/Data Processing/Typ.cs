using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace EolCopy.Data_Processing
{
    class Typ
    {
        private int cislo;
        public int CisloTypu => cislo;
        public string[] popisky { get; }
        public List<Pozice> Data { get; }


        public Typ(string cesta)
        {
            cislo = 0;


            //**** vytažení čísla typu z názvu souboru
            Regex rg = new Regex(@"_(?<typ>[0-9]+)\.csv");
            Match mch = rg.Match(cesta);
            
            if (mch.Success)
            {
                cislo = int.Parse(mch.Groups["typ"].Value);
            }
            //    \d+\b   regex na cislo typu
            //***************************************


            Data = new List<Pozice>();
            NactiDataZeSouboru(cesta);
        }

        private void NactiDataZeSouboru(string cesta)
        {
            StreamReader sr = new StreamReader(cesta);
            bool prvniRadek = true;
            string[] popisky = null;
            int i = 0;
            while (sr.Peek() >= 0)
            {
                if (prvniRadek)
                {
                    string prvni = sr.ReadLine();
                    popisky = prvni.Split(';');
                }
                string popisek = "";
                if (i<popisky.Length)
                {
                    popisek = popisky[i++];
                }
                string radek = sr.ReadLine();
                string[] dataRadku = radek.Split(';');
                int id = 0;
                if (int.TryParse(dataRadku[0],out id))
                {
                    cislo = id;
                }
                
                Data.Add(new Pozice(popisek,id,dataRadku)); 

                prvniRadek = false;

            }

            
        }
    }
}
