using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualizeSourceCode
{
    internal class Kelas
    {
        public int jumlahKelas = 0;
        public int id { get; set; }
        public string namaKelas { get; set; }
        public List<string> superKelas = new List<string>();

        public Kelas(string aNamaKelas, string aSuperKelas)
        {
            ++jumlahKelas;
            this.id = jumlahKelas;
            this.namaKelas = aNamaKelas;
            this.superKelas.Add(aSuperKelas);
        }


    }
}
