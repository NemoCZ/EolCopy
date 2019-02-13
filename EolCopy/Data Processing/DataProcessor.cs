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

        public DataProcessor(string cesta) // cesta je cesta ke složce
        {
            datovaTabulka = new DataTable();
            tabulkaTypu = new List<Typ>();
            

        }

        public void PridejTyp(Typ typ)
        {
            tabulkaTypu.Add(typ);
        }

        
    }
}
