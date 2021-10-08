using System;

namespace PayrollSystemPolymorphism
{
    public abstract class Pegawai
    {
        public string NAwal { get; }
        public string NAkhir { get; }
        public string NoKTP { get; }
        public Pegawai(string nAwal, string nAkhir, string noKTP)
        {
            NAwal = nAwal;
            NAkhir = nAkhir;
            NoKTP = noKTP;
        }
        public override string ToString() => $"{NAwal} {NAkhir}\n" + $"Nomor KTP: {NoKTP}";
        public abstract decimal Penghasilan();
    }
}
