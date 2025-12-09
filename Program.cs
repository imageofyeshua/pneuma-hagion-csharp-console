namespace PneumaHagion;

class Program
{
    static void Main(string[] args)
    {
        var angeloi = new AngelosCounter("karpos_pneumatos.csv");
        var amountPerAngelos = angeloi.GetKarposPerAngelos();
        foreach(var obj in amountPerAngelos)
        {
            Console.WriteLine("{0} {1}", obj.Key, obj.Value);
        }
    }
}
