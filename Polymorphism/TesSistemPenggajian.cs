using System;
using System.Collections.Generic;

namespace PayrollSystemPolymorphism
{
    class SistemPenggajian
    {
        static void Main(string[] args)
        {
            var pegawaiBergaji = new PegawaiBergaji("John", "Smith", "111-11-1111", 800.00M);
            var pegawaiPerJam = new PegawaiPerJam("Karen", "Price", "222-22-2222", 16.75M, 40.0M);
            var komisiPegawai = new KomisiPegawai("Sue", "Jones", "333-33-3333", 10000.00M, .06M);
            var basePlusKomisiPegawai = new BasePlusKomisiPegawai("Bob", "Lewis", "444-44-4444", 5000.00M, .04M, 300.00M);

            Console.WriteLine("Pegawai diproses secara individual: \n");

            Console.WriteLine($"{pegawaiBergaji}\nDiperoleh: " + $"{pegawaiBergaji.Penghasilan():C}\n");
            Console.WriteLine($"{pegawaiPerJam}\nDiperoleh: " + $"{pegawaiPerJam.Penghasilan():C}\n");
            Console.WriteLine($"{komisiPegawai}\nDiperoleh: " + $"{komisiPegawai.Penghasilan():C}\n");
            Console.WriteLine($"{basePlusKomisiPegawai}\nDiperoleh: " + $"{basePlusKomisiPegawai.Penghasilan():C}\n");

            var pegawai = new List<Pegawai>() { pegawaiBergaji, pegawaiPerJam, komisiPegawai, basePlusKomisiPegawai };

            Console.WriteLine("Pegawai diproses secara polimorfik:\n");

            foreach (var currentPegawai in pegawai)
            {
                Console.WriteLine(currentPegawai);

                if (currentPegawai is BasePlusKomisiPegawai)
                {
                    var pegawai1 = (BasePlusKomisiPegawai)currentPegawai;

                    pegawai1.GajiPokok *= 1.10M;
                    Console.WriteLine("Gaji pokok baru dengan kenaikan 10% : " + $"{pegawai1.GajiPokok:C}");
                }
                Console.WriteLine($"Diperoleh: {currentPegawai.Penghasilan():C}\n");
            }
            for (int j = 0; j < pegawai.Count; j++)
            {
                Console.WriteLine($"Pegawai {j} adalah {pegawai[j].GetType()}");
            }
        }
    }
}
