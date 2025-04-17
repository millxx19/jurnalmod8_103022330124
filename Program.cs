using System.Collections.Generic;
using System.Numerics;

class program
{
    static void Main(string[] args)
    {
        BankTransferConfig config = BankTransferConfig.Load();
        //
        config.UbahSatuan();
        config.Save();

        Console.Write($"Please insert the amount of money to transfer:"){config.satuan}: } ");
        double jumlah = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("“Masukkan jumlah uang yang akan di-transfer:");  
        int jumlah = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(transferBerhasil, jumlah, config.pesan_diterima ; config.pesan_ditolak);
}