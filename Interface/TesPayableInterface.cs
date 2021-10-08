using System;
using System.Collections.Generic;

namespace IPayableHierachy
{
    class TesPayableInterface
    {
        static void Main(string[] args)
        {
            var objekPayable = new List<IPayable>(){
                new Faktur("01234", "kursi", 2, 375.00M),
                new Faktur("56789", "ban", 4, 79.95M),
                new PegawaiBergaji("John", "Smith", "111-11-1111", 800.00M),
                new PegawaiBergaji("Lisa", "Barnes", "888-88-8888", 1200.00M)};

            Console.WriteLine("Faktur dan Pegawai diproses secara polimorfik:\n");

            foreach (var payable in objekPayable)
            {
                Console.WriteLine($"{payable}");
                Console.WriteLine($"Jatuh tempo yang harus dibayar: {payable.DapatkanJumlahPembayaran():C}\n");
            }

            Console.ReadKey();
        }
    }
}
