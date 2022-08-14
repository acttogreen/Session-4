class Program
{
    public static void Main(string[] args)
    {
        CariDataNilaiMuridTertinggi();
    }
    private static void HitungLuasBangun()
    {
        Perhitungan perhitungan = new Perhitungan();
        Console.Write("Masukkan jenis bangunan: ");
        string? shape = Console.ReadLine();
        if (string.IsNullOrEmpty(shape))
        {
            Console.WriteLine("Input tidak boleh kosong");
            return;
        }
        perhitungan.HitungLuas(shape);
    }
    private static void TestCar()
    {
        Car car = new Car("Toyota", "Black", 2015);
        Engine engine = new Engine();
        car.About();
        engine.Accelerate(10);
    }
    private static void CariDataNilaiMuridTertinggi()
    {
        Random rand = new Random(); // buat objek random
        Siswa[] kelas12A = new Siswa[30]; // buat array siswa dengan 30 elemen                   
        for (int i = 0; i < kelas12A.Length; i++) //looping untuk mengisi array
        {
            int nilaiSiswa = rand.Next(50, 100);
            kelas12A[i] = new Siswa("Kelas A", nilaiSiswa); //isi array dengan nilai random
            Console.WriteLine("{0} {1} {2}", kelas12A[i].Kelas, kelas12A[i].nilai, Environment.NewLine);
        }

        int nilaiTertinggi = 0;
        int index = 0;
        for (int i = 0; i < kelas12A.Length; i++) //cari nilai tertinggi dengan sort array
        {
            if (kelas12A[i].nilai > nilaiTertinggi)
            {
                nilaiTertinggi = kelas12A[i].nilai; //set nilai tertinggi
                index = i;
            }
        }
        Console.WriteLine("Nilai tertinggi adalah: {0} di index {1}", nilaiTertinggi, index);
    }
}

public class Vehicle
{
    protected string model = "", color = "";
    protected int year = 0;
}

public class Car : Vehicle
{
    public Car(string model, string color, int year)
    {
        this.model = model;
        this.color = color;
        this.year = year;
    }

    public void About()
    {
        Console.WriteLine("This is a {0} {1} {2}", this.color, this.year, this.model);
    }
}
