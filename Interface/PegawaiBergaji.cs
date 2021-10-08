using System;

namespace IPayableHierachy
{
    public class PegawaiBergaji : Pegawai
    {
        private decimal gajiMingguan;
        public PegawaiBergaji(string nAwal, string nAkhir, string noKTP, decimal gajiMingguan) : base(nAwal, nAkhir, noKTP)
        {
            GajiMingguan = gajiMingguan;
        }
        public decimal GajiMingguan
        {
            get
            {
                return gajiMingguan;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(GajiMingguan)} harus >= 0");
                }
                gajiMingguan = value;
            }
        }
        public override decimal Penghasilan() => GajiMingguan;
        public override string ToString() =>
            $"Pegawai Bergaji: {base.ToString()}\n" +
            $"Gaji Mingguan: {GajiMingguan:C}";
    }
}

