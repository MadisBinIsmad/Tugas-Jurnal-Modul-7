using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.IO;

namespace JurnalModul7
{
    class DataMahasiswa103082400038
    {
        public class Nama
        {
            public string depan { get; set; }
            public string belakang { get; set; }
        }

        public class Mahasiswa
        {
            public Nama nama { get; set; }
            public long nim { get; set; }
            public string fakultas { get; set; }
        }

        public static void ReadJSON()
        {
            string json = File.ReadAllText("jurnal7_1_103082400038.json");

            Mahasiswa data = JsonSerializer.Deserialize<Mahasiswa>(json);

            Console.WriteLine("Nama: " + data.nama.depan + " " + data.nama.belakang);
            Console.WriteLine("NIM: " + data.nim);
            Console.WriteLine("Fakultas: " + data.fakultas);
        }
    }
}
