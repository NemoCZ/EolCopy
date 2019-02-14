using System;
using System.Collections.Generic;
using System.Text;

namespace EolCopy.Data_Processing
{
    class Pozice
    {
        public string Name { get; set; }
        public int Id { get; }
        public int[] Data { get; set; }
        private const int pocatekDat = 4;

        public Pozice(string name,int id,string[] data)
        {
            Name = name;
            Id = id;
            List<int> ciselnySeznam = new List<int>();
            for (int i = pocatekDat; i < data.Length; i++)
            {
                int n = 0;
                if (int.TryParse(data[i],out n))
                {
                    ciselnySeznam.Add(n);
                }
            }
            Data = ciselnySeznam.ToArray();
        }
		
		private int[] StrArrToIntArr(string[] data)
		{
			List<int> ciselnySeznam = new List<int>();
            for (int i = pocatekDat; i < data.Length; i++)
            {
                int n = 0;
                if (int.TryParse(data[i],out n))
                {
                    ciselnySeznam.Add(n);
                }
            }
            return  ciselnySeznam.ToArray();
        }
		}

    }
}
