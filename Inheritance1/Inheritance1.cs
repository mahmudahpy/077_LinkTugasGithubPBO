using System;

namespace KomisiPegawai
{
    public class KomisiPegawai : object
    {
        public string NAwal { get; }
        public string NAkhir { get; }
        public string NoKTP { get; }
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiPegawai(string nAwal, string nAkhir, string noKTP, decimal penjualanKotor, decimal tingkatKomisi)
        {
            NAwal = nAwal;
            NAkhir = nAkhir;
            NoKTP = noKTP;
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
        }
        public decimal PenjualanKotor
        {
            get
            {
                return penjualanKotor;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(PenjualanKotor)} harus >= 0");
                }
                penjualanKotor = value;
            }
        }
        public decimal TingkatKomisi
        {
            get
            {
                return tingkatKomisi;
            }
            set
            {
                if (value <= 0 || value >= 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(TingkatKomisi)} harus > 0 dan < 1");
                }
                tingkatKomisi = value;
            }
        }
        public decimal Penghasilan() => tingkatKomisi * penjualanKotor;
        public override string ToString() =>
            $"Komisi Pegawai: {NAwal} {NAkhir}\n" +
            $"Nomor KTP: {NoKTP}\n" +
            $"Penjualan Kotor: {penjualanKotor:C}\n" +
            $"Tingkat Komisi: {tingkatKomisi:F2}";
    }
    class Inheritance1
    {
        static void Main(string[] args)
        {
            var pegawai = new KomisiPegawai("Sue", "Jones", "222-22-2222", 10000.00M, .06M);
            Console.WriteLine("Informasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama Awal : {pegawai.NAwal}");
            Console.WriteLine($"Nama Akhir : {pegawai.NAkhir}");
            Console.WriteLine($"Nomor KTP : {pegawai.NoKTP}");
            Console.WriteLine($"Penjualan Kotor : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat Komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Penghasilan : {pegawai.Penghasilan():C}");

            pegawai.PenjualanKotor = 5000.00M;
            pegawai.TingkatKomisi = .1M;

            Console.WriteLine("\nInformasi pegawai yang diperbarui diperoleh oleh ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Penghasilan : {pegawai.Penghasilan():C}");

            Console.ReadKey();
        }
    }
}

