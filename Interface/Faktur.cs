using System;

namespace IPayableHierachy
{
    public class Faktur : IPayable
    {
        public string NoBagian { get; }
        public string DeskBagian { get; }
        private int kuantitas;
        private decimal hargaPerItem;

        public Faktur(string noBagian, string deskBagian, int kuantitas, decimal hargaPerItem)
        {
            NoBagian = noBagian;
            DeskBagian = deskBagian;
            Kuantitas = kuantitas;
            HargaPerItem = hargaPerItem;
        }
        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Kuantitas)} harus >= 0");
                }
                kuantitas = value;
            }
        }
        public decimal HargaPerItem
        {
            get
            {
                return hargaPerItem;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(HargaPerItem)} harus >= 0");
                }
                hargaPerItem = value;
            }
        }
        public override string ToString() =>
            $"Faktur:\nNomor Bagian: {NoBagian} ({DeskBagian})\n" +
            $"Kuantitas: {Kuantitas}\nHarga Per Item: {HargaPerItem:C}";
        public decimal DapatkanJumlahPembayaran() => Kuantitas * HargaPerItem;
    }
}
