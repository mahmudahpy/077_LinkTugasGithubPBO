using System;

namespace PayrollSystemPolymorphism
{
    public class KomisiPegawai : Pegawai
    {
        private decimal penjualanKotor;
        private decimal tingkatKomisi;

        public KomisiPegawai(string nAwal, string nAkhir, string noKTP, decimal penjualanKotor, decimal tingkatKomisi) : base(nAwal, nAkhir, noKTP)
        {
            PenjualanKotor = penjualanKotor;
            TingkatKomisi = tingkatKomisi;
        }
        public decimal  PenjualanKotor
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
        public override decimal Penghasilan() => TingkatKomisi * PenjualanKotor;
        public override string ToString() =>
            $"Komisi Pegawai: {base.ToString()}\n" +
            $"Penjualan Kotor: {PenjualanKotor:C}\n" +
            $"Tingkat Komisi: {TingkatKomisi:F2}";
    }
}
