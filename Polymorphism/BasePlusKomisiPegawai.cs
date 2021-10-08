using System;

namespace PayrollSystemPolymorphism
{
    public class BasePlusKomisiPegawai : KomisiPegawai
    {
        private decimal gajiPokok;

        public BasePlusKomisiPegawai(string nAwal, string nAkhir, string noKTP, decimal penjualanKotor, decimal tingkatKomisi, decimal gajiPokok) : base(nAwal, nAkhir, noKTP, penjualanKotor, tingkatKomisi)
        {
            GajiPokok = gajiPokok;
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
        public override decimal Penghasilan() => GajiPokok + base.Penghasilan();
        public override string ToString() =>
            $"Gaji Pokok {base.ToString()}\nGaji Pokok: {GajiPokok:C}";
    }
}
