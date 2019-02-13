using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace EolCopy.Data_Processing
{
    class Typ
    {
        public int CisloTypu { get; }
        public string[] popisky { get; }
        public List<Pozice> Data { get; }

        public Typ(string cesta)
        {
            Data = new List<Pozice>();
            NactiDataZeSouboru(cesta);
        }

        private void NactiDataZeSouboru(string cesta)
        {
            StreamReader sr = new StreamReader(cesta);
            bool prvniRadek = true;
            string[] popisky = null;
            int i = 1;
            while (sr.Peek() >= 0)
            {
                if (prvniRadek)
                {
                    string prvni = sr.ReadLine();
                    popisky = prvni.Split(';');
                }
                string[] dataRadku = sr.ReadLine().Split(';');
                Data.Add(new Pozice(popisky[i++],int.Parse(dataRadku[0]),dataRadku)); 

                prvniRadek = false;

            }

            
        }
    }
}
