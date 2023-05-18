using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCity.DAL.Dots
{
    public class FilialDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adress { get; set; }

        public FilialDto(int id, string name, string adress)
        {
            Id = id;
            Name = name;
            Adress = adress;
        }
    }
}
