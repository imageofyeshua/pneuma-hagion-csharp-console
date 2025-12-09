namespace PneumaHagion;

public class AngelosCounter
{
    private List<Angelos> _angeloi;

    public AngelosCounter(List<Angelos> angeloi)
    {
        _angeloi = angeloi;
    }

    public AngelosCounter(string filePath)
    {
        _angeloi = ReadAngelos(filePath);
    }

    public Dictionary<string, int> GetKarposPerAngelos()
    {
        Dictionary<string, int> dict = new();
        foreach (Angelos angelos in _angeloi)
        {
            if (dict.ContainsKey(angelos.Name))
                dict[angelos.Name] += angelos.Amount;
            else
                dict[angelos.Name] = angelos.Amount;
        }
        return dict;
    }
    private static List<Angelos> ReadAngelos(string filePath)
    {
        List<Angelos> angeloi = new();
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            string[] items = line.Split(',');
            Angelos angelos = new Angelos
            {
                Name = items[0],
                Karpos = items[1],
                Amount = int.Parse(items[2])
            };
            angeloi.Add(angelos);
        }

        return angeloi;
    }
}