

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
                _Adgangskode = value;
            }
        }

        public string Brugernavn
        {
            get => _Brugernavn;
            set
            {
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

        public void Login()
        {
            throw new System.NotImplementedException();
        }

        public void TilføjTilKurv()
        {
            throw new System.NotImplementedException();
        }

        public void Bestil()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Admin : Bruger
    {

        public Admin()
        {
            throw new System.NotImplementedException();
        }

        public void CreateVare()
        {
            throw new System.NotImplementedException();
        }

        public void DeleteVare()
        {
            throw new System.NotImplementedException();
        }

        public void ReadVareList()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateVare()
        {
            throw new System.NotImplementedException();
        }

        public void ReadKundeList()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Kunde : Bruger
    {
        private int _KundeID;

        public Kunde(string Brugernavn, string Adgangskode, int KundeID) : base(Brugernavn,Adgangskode)
        {
            this.KundeID = KundeID;
        }

        public int KundeID
        {
            get => _KundeID;
            set
            {
                _KundeID = value;
            }
        }

        public void OpretKunde()
        {
            throw new System.NotImplementedException();
        }
    }

    public class Vare
    {
        private int _Pris;
        private int _VareNummer;
        private string _VareNavn;

        public Vare(int VareNummer, string VareNavn, int Pris)
        {
            this.VareNummer = VareNummer;
            this.VareNavn = VareNavn;
            this.Pris = Pris;
        }

        public int Pris
        {
            get => _Pris;
            set
            {
                _Pris = value;
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

        public int VareNummer
        {
            get => _VareNummer;
            set
            {
                _VareNummer = value;
            }
        }
    }

    
    public static class Global
    {
        public static List<Kunde> KundeList()
        {
            throw new System.NotImplementedException();
        }

        public static List<Vare> VareList()
        {
            throw new System.NotImplementedException();
        }
    }
}