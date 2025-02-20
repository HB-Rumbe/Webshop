using static Webshop.KundeList;
using static Webshop.VareList;

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
                else
                MessageBox.Show("Adgangskode ikke gyldigt");
            }
        }

        public string Brugernavn
        {
            get => _Brugernavn;
            set
            {
                if (value != null)
                    _Brugernavn = value;
                else
                MessageBox.Show("Brugernavn ikke gyldigt");
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

        public bool Login(string Brugernavn, string Adgangskode)
        {
           foreach(Kunde kunde in Global.KundeList)
            {
                if(kunde.Brugernavn == Brugernavn && kunde.Adgangskode == Adgangskode)
                {
                    return true;
                }
                
            }
            return false;
            
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

        public void CreateVare(int VareID, String VareNavn, int VarePris)
        {

            Global.VareList.Add(new Vare(VareID,VareNavn,VarePris));
        }

        public void DeleteVare(int VareID)
        {
            foreach (Vare vare in Global.VareList)
            {
                if (VareID == vare.VareID)
                Global.VareList.Remove(vare);
            }
        }

        public void ReadVareList()
        {
            throw new System.NotImplementedException();
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

        public void OpretKunde()
        {
            throw new System.NotImplementedException();
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