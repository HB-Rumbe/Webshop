using static Webshop.VareList;
using static Webshop.KundeList;
namespace Webshop
{

    public abstract class Bruger
    {
        private string _Adgangskode;
        private string _Brugernavn;
        private List<Vare> _Kurv = new List<Vare>();

        public Bruger(string Brugernavn, string Adgangskode)
        {
            this.Brugernavn = Brugernavn;
            this.Adgangskode = Adgangskode;
        }

        public string Adgangskode
        {
            get => _Adgangskode;
            set
            {
                if (value != null)
                    _Adgangskode = value;
            }
        }

        public string Brugernavn
        {
            get => _Brugernavn;
            set
            {
                if (value != null)
                    _Brugernavn = value;
            }
        }

        public List<Vare> Kurv
        {
            get => _Kurv;
            set
            {
                _Kurv = value;
            }
        }

        public static Bruger _Login(string Brugernavn, string Adgangskode)
        {

            if (Brugernavn == "admin" && Adgangskode == "admin")
            {
                if(kunde.Brugernavn == Brugernavn && kunde.Adgangskode == Adgangskode)
                {
                    return true;
                }
                
            }
            return false;
            
        }

        public int Bestil()
        {
            int TotalPris = 0;
            foreach (Vare vare in Kurv)
            {
                TotalPris += vare.VarePris;
            }
            return TotalPris;
        }
    }

    public class Admin : Bruger
    {
        public Admin() : base("admin", "admin")
        {

        }

        public void CreateVare(int VareID, String VareNavn, int VarePris)
        { 
            Global.VareList.Add(new Vare(VareID,VareNavn,VarePris));
        }

        public void DeleteVare(int VareID)
        {
            Global.VareList.RemoveAll(vare => vare.VareID == VareID);
        }

        public List<Vare> ReadVareList()
        {
            return Global.VareList;
        }

        public void UpdateVare(int VareID, string VareNavn, int VarePris)
        {
            foreach (Vare vare in Global.VareList)
            {
                if (VareID == vare.VareID)
                {
                    vare.VareNavn = VareNavn;
                    vare.VarePris = VarePris;
                }
                    
            }
        }

        public List<Kunde> ReadKundeList()
        {
            return Global.KundeList;
        }
    }

    public class Kunde : Bruger
    {
        private int _KundeID;

        public Kunde(string Brugernavn, string Adgangskode, int KundeID) : base(Brugernavn,Adgangskode)
        {
            _Login(Brugernavn, Adgangskode);
            this.KundeID = KundeID;
        }

        public int KundeID
        {
            get => _KundeID;
            set
            {
                foreach(Kunde kunde in Global.KundeList)
                {
                    if (value == kunde.KundeID)
                    {
                        MessageBox.Show("kundeID allerede brugt");
                        return;
                    }
                }

                _KundeID = value;
            }
        }

        public static void OpretKunde(string Brugernavn, string Adgangskode)
        {
            int KundeID = 1;
            

            while(Global.KundeList.Any(KundeList => KundeList.KundeID == KundeID))
            {
                KundeID++;
            }

            Global.KundeList.Add(new Kunde(Brugernavn, Adgangskode, KundeID));
        }
    }

    public class Vare
    {
        private int _VarePris;
        private int _VareID;
        private string _VareNavn;

        public Vare(int VareID, string VareNavn, int VarePris)
        {
            this.VareID = VareID;
            this.VareNavn = VareNavn;
            this.VarePris = VarePris;
        }

        public int VarePris
        {
            get => _VarePris;
            set
            {
                _VarePris = value;
            }
        }

        public string VareNavn
        {
            get => _VareNavn;
            set
            {
                _VareNavn = value;
            }
        }

        public int VareID
        {
            get => _VareID;
            set
            {
                _VareID = value;
            }
        }
    }

    
    public static class Global
    {
        private static List<Kunde> _KundeList = LoadKundeList();
        private static List<Vare> _VareList = LoadVareList();

        public static List<Kunde> KundeList
        {
            get => _KundeList;
            set
            {
                _KundeList = value;
            }
        }

        public static List<Vare> VareList
        {
            get => _VareList;
            set
            {
                _VareList = value;
            }
        }
    }
}
