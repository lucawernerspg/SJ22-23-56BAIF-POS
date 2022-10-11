namespace ExProperties.App
{
    internal class Lehrer
    {

        public string Zuname
        {
            get;
            set;
        }
        public string Vorname
        {
            get;
            set;
        } = String.Empty;
        private decimal? wert;
        public decimal? Bruttogehalt

        {
            get
            {
                return wert;
            }
            set
            {
                if (wert == null)
                {
                    wert = value;

                }

            }

        }

        public decimal Nettogehalt
        {
            get
            {
                return (Bruttogehalt ?? 0) * 0.8M;
            }
        }

        public string Kuerzel
        {
            get
            {
                return Zuname != null ? (Zuname.Length <= 3 ? Zuname.ToUpper() : Zuname[..3].ToUpper()) : string.Empty;
            }
        }

    }
}