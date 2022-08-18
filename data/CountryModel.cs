
namespace data
{
    public class CountryModel
    {

        public double? Area { get; set; }


        public int CallingCode { get; set; }


        public string Capital { get; set; }


        public string ThreeLettersCode { get; set; }


        public string TwoLettersCode { get; set; }


        public string Demonym { get; set; }

        public double? Latitude { get; set; }

        public string LocalName { get; set; }

        public double? Longitude { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }
        public List<LanguageModel> Languages { get; set; }
        public List<CurrencieModel> Currencies { get; set; }

    }
}
