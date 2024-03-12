//1302220079
public class KodePos
{
    public enum Kelurahan
    {
        Batununggal,
        Kujangsari,
        Mengger,
        Wates,
        Cijaura,
        Jatisari,
        Margasari,
        Sekejati,
        Kebonwaru,
        Maleer,
        Samoja
    }

    private static Dictionary<Kelurahan, string> kodePosTabel = new Dictionary<Kelurahan, string>
    {
        { Kelurahan.Batununggal, "40266" },
        { Kelurahan.Kujangsari, "40287" },
        { Kelurahan.Mengger, "40267" },
        { Kelurahan.Wates, "40256" },
        { Kelurahan.Cijaura, "40287" },
        { Kelurahan.Jatisari, "40286" },
        { Kelurahan.Margasari, "40286" },
        { Kelurahan.Sekejati, "40286" },
        { Kelurahan.Kebonwaru, "40272" },
        { Kelurahan.Maleer, "40274" },
        { Kelurahan.Samoja, "40273" }
    };

    public static string getKodePos(Kelurahan kelurahan)
    {
        return kodePosTabel.GetValueOrDefault(kelurahan, "Kode pos tidak ditemukan");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Batununggal : " + KodePos.getKodePos(KodePos.Kelurahan.Batununggal));
        Console.WriteLine("Kujangsari : " + KodePos.getKodePos(KodePos.Kelurahan.Kujangsari));
        Console.WriteLine("Samoja : " + KodePos.getKodePos(KodePos.Kelurahan.Samoja));
    }
}