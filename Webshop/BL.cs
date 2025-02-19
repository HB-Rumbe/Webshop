

namespace Webshop
{
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

        public Kunde()
        {
            throw new System.NotImplementedException();
        }

        public int KundeID
        {
            get => _KundeID;
            set
            {
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
        private int _VareNavn;

        public Vare()
        {
            throw new System.NotImplementedException();
        }

        public int Pris
        {
            get => _Pris;
            set
            {
            }
        }

        public int VareNavn
        {
            get => _VareNavn;
            set
            {
            }
        }

        public int VareNummer
        {
            get => _VareNummer;
            set
            {
            }
        }
    }

    public abstract class Bruger
    {
        private int _Adgangskode;

        private int _Brugernavn;
        private int _Kurv;

        public Bruger()
        {
            throw new System.NotImplementedException();
        }

        public int Adgangskode
        {
            get => default;
            set
            {
            }
        }

        public int Brugernavn
        {
            get => default;
            set
            {
            }
        }

        public int Kurv
        {
            get => default;
            set
            {
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

    public static class Global
    {
        public static void KundeList()
        {
            throw new System.NotImplementedException();
        }

        public static void VareList()
        {
            throw new System.NotImplementedException();
        }
    }
}