using System;
using System.Collections.Generic;
using System.Text;

namespace EolCopy.Data_Processing
{
    class Pozice
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int[] Data { get; set; }

        public Pozice(string name,int id,int[] data)
        {
            Name = name;
            Id = id;
            Data = data;
        }

    }
}
