class Perhitungan
{
    public float nilai1, nilai2, luas;

    public void HitungLuas(string bangunDatar)
    {
        if (string.IsNullOrEmpty(bangunDatar))
        {
            Console.WriteLine("Input tidak boleh kosong");
            return;
        }
        switch (bangunDatar)
        {
            default: Console.WriteLine("Jenis bangunan tidak terdaftar"); break;
            case "persegi": HitungLuasPersegi(); break;
            case "persegi panjang": HitungLuasPersegiPanjang(); break;
            case "segitiga": HitungLuasSegitiga(); break;
            case "lingkaran": HitungLuasLingkaran(); break;
        }
    }

    private void HitungLuasLingkaran()
    {
        Console.Write("Masukkan nilai jari-jari: ");
        float.TryParse(Console.ReadLine(), out nilai1);
        luas = 3.14f * nilai1 * nilai1;
        Console.WriteLine("Luas lingkaran adalah: {0}", luas);
    }

    private void HitungLuasSegitiga()
    {
        Console.Write("Masukkan nilai alas: ");
        float.TryParse(Console.ReadLine(), out nilai1);
        Console.Write("Masukkan nilai tinggi: ");
        float.TryParse(Console.ReadLine(), out nilai2);
        luas = nilai1 * nilai2 / 2;
        Console.WriteLine("Luas segitiga adalah: {0}", luas);
    }

    private void HitungLuasPersegiPanjang()
    {
        Console.Write("Masukkan nilai panjang: ");
        float.TryParse(Console.ReadLine(), out nilai1);
        Console.Write("Masukkan nilai lebar: ");
        float.TryParse(Console.ReadLine(), out nilai2);
        luas = nilai1 * nilai2;
        Console.WriteLine("Luas persegi panjang adalah: {0}", luas);
    }

    private void HitungLuasPersegi()
    {
        Console.Write("Masukkan nilai sisi: ");
        float.TryParse(Console.ReadLine(), out nilai1);
        luas = nilai1 * nilai1;
        Console.WriteLine("Luas persegi adalah: {0}", luas);
    }
}