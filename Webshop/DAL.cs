namespace Webshop
{
    public static class VareList
    {
        public static string VareListPath = @"C:\\Users\anto3\WebshopLister\VareList.txt";
        public static void SaveVareList(List<Vare> VareList)
        {
            if (!File.Exists(VareListPath))
            {
                File.WriteAllText(VareListPath, "");
            }

            string SavedLine = "";
            foreach (Vare vare in VareList)
            {
                SavedLine += $"{vare.VareNummer},{vare.VareNavn},{vare.VarePris}\n";
            }
            File.WriteAllText(VareListPath, SavedLine);
        }
        public static List<Vare> LoadVareList()
        {
            List<Vare> VareList = new List<Vare>();
            String[] Lines = File.ReadAllLines(VareListPath);
            foreach(string line in Lines)
            {
                string[] split = line.Split(",");
                Vare vare = new Vare(Convert.ToInt32(split[0]), split[1], Convert.ToInt32(split[2]));
                VareList.Add(vare);
            }
            return VareList;
        }
    }

    public static class KundeList
    {
        public static string KundeListPath = @"C:\Users\anto3\WebshopLister\KundeList.txt";

    public static void SaveKundeList(List<Kunde> KundeList)
        {
            if (!File.Exists(KundeListPath))
            {
                File.WriteAllText(KundeListPath, "");
            }
            string SavedLine = "";
            foreach (Kunde kunde in KundeList)
            {
                SavedLine += $"{kunde.Brugernavn},{kunde.Adgangskode},{kunde.KundeID}\n";
            }
            File.WriteAllText(KundeListPath, SavedLine);
        }

        public static List<Kunde> LoadKundeList()
        {
            List<Kunde> KundeList = new List<Kunde>();
            String[] Lines = File.ReadAllLines(KundeListPath);
            foreach (string line in Lines)
            {
                string[] split = line.Split(",");
                Kunde kunde = new Kunde(split[0], split[1], Convert.ToInt32(split[2]));
                KundeList.Add(kunde);
            }
            return KundeList;

        }
    }
}