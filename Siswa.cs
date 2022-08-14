public class Siswa
{
    public string Kelas { get; set; }
    public int nilai { get; set; }
    public Siswa(string kelas, int nilai)
    {
        this.Kelas = kelas;
        this.nilai = nilai;
    }
}