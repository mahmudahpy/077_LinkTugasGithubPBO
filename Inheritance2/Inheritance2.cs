using System;

namespace BasePlusKomisiPegawai
{
    public class BasePlusKomisiPegawai
    {
        public string NAwal { get; }
        public string NAkhir { get; }
        public string NoKTP { get; }

        private decimal penjualanKotor;
        private decimal tingkatKomisi;
        private decimal gajiPokok;

        public BasePlusKomisiPegawai(string nAwal, string nAkhir, string noKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok)
        {
            NAwal = nAwal;
            NAkhir = nAkhir;
            NoKTP = noKTP;
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
            GajiPokok = gajiPokok;
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
        public decimal GajiPokok
        {
            get
            {
                return gajiPokok;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiPokok)} harus >= 0");
                }
                gajiPokok = value;
            }
        }
        public decimal Penghasilan() =>
            gajiPokok + (tingkatKomisi * penjualanKotor);
        public override string ToString() =>
            $"Komisi Gaji Pokok Pegawai: {NAwal} {NAkhir}\n" +
            $"Nomor KTP: {NoKTP}\n" +
            $"Penjualan Kotor: {penjualanKotor:C}\n" +
            $"Tingkat Komisi: {tingkatKomisi:F2} \n" +
            $"Gaji Pokok: {gajiPokok:C}";
    }
    class Inheritance2
    {
        static void Main(string[] args)
        {
            var pegawai = new BasePlusKomisiPegawai("Bob", "Lewis", "333-33-3333", 5000.00M, .04M, 300.00M);
            Console.WriteLine("Informasi pegawai diperoleh dengan properti dan metode: \n");
            Console.WriteLine($"Nama Awal : {pegawai.NAwal}");
            Console.WriteLine($"Nama Akhir : {pegawai.NAkhir}");
            Console.WriteLine($"Nomor KTP : {pegawai.NoKTP}");
            Console.WriteLine($"Penjualan Kotor : {pegawai.PenjualanKotor:C}");
            Console.WriteLine($"Tingkat Komisi : {pegawai.TingkatKomisi:F2}");
            Console.WriteLine($"Penghasilan : {pegawai.Penghasilan():C}");
            Console.WriteLine($"Gaji Pokok : {pegawai.GajiPokok:C}");

            pegawai.GajiPokok = 1000.00M;

            Console.WriteLine("\nInformasi pegawai yang diperbarui diperoleh oleh ToString:\n");
            Console.WriteLine(pegawai);
            Console.WriteLine($"Penghasilan : {pegawai.Penghasilan():C}");

            Console.ReadKey();

        }
    }
}
