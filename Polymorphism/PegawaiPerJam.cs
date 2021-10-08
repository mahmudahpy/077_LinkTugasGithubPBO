using System;

namespace PayrollSystemPolymorphism
{
    public class PegawaiPerJam : Pegawai
    {
        private decimal upah;
        private decimal jam;

        public PegawaiPerJam(string nAwal, string nAkhir, string noKTP, decimal upahPerJam, decimal jamKerja) : base(nAwal, nAkhir, noKTP)
        {
            Upah = upahPerJam;
            Jam = jamKerja; 
        }
        public decimal Upah
        {
            get
            {
                return upah;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Upah)} harus >= 0");
                }
                upah = value;
            }
        }
        public decimal Jam
        {
            get
            {
                return jam;
            }
            set
            {
                if (value < 0 || value > 168)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Jam)} harus >= 0 dan <= 168");
                }
                jam = value;
            }
        }
        public override decimal Penghasilan()
        {
            if (Jam <= 40)
            {
                return Upah * Jam;
            }
            else
            {
                return (40 * Upah) + ((Jam - 40) * Upah * 1.5M);
            }
        }
        public override string ToString() =>
            $"Pegawai Per Jam: {base.ToString()}\n" +
            $"Upah Per Jam: {Upah:C}\nJam Kerja: {Jam:F2}";
    }
}
