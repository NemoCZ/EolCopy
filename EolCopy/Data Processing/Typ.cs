using System;
using System.Collections.Generic;
using System.Text;

namespace EolCopy.Data_Processing
{
    class Typ
    {
        public int CisloTypu { get; }
        public List<Pozice> Data { get; }

        public Typ(int id)
        {
            CisloTypu = id;
            Data = new List<Pozice>();
        }
    }
}
