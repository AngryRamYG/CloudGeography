using AngryMonkey.Cloud;
using AngryMonkey.Cloud.Geography;
using System.Text.Json;
using data;

CloudGeography cloudGeography = new CloudGeography();


//Remove Comment for Serializing------------

//List<Country> countries = await cloudGeography.Countries.GetAllAsync();
//List<CountryModel> models = new();
//CountryModel model = new();


//foreach (Country c in countries)
//{
//    List<CountryLanguage> languages = new();
//    List<CountryCurrency> currencies = new();

//    List<LanguageModel> languagesList = new();
//    List<CurrencieModel> currencieList = new();
//    try
//    {
//        languages = await cloudGeography.Languages.GetByCountryAsync(c.TwoLettersCode);
//        currencies = await cloudGeography.Currencies.GetByCountryAsync(c.TwoLettersCode);
//    }
//    catch (Exception e)
//    {
//    }
//    languages.ForEach(result =>
//    {
//        LanguageModel language = new()
//        {
//            Code = result.Language.TwoLettersCode,
//            IsOffical=result.IsOfficial
//        };
//        languagesList.Add(language);
//    });
//    currencies.ForEach(result =>
//    {
//        CurrencieModel currencie = new()
//        {
//            Code = result.Currency.ThreeLettersCode,
//            IsOffical = result.IsOfficial
//        };
//        currencieList.Add(currencie);
//    });
//    model =new()
//    {
//        Area= c.Area,
//        CallingCode= c.CallingCode,
//        Capital=c.Capital,
//        ThreeLettersCode=c.ThreeLettersCode,
//        TwoLettersCode=c.TwoLettersCode,
//        Demonym=c.Demonym,
//        Latitude = c.Latitude,
//        LocalName = c.LocalName,
//        Longitude = c.Longitude,
//        Name = c.Name,
//        ShortName = c.ShortName,
//        Languages=languagesList,
//        Currencies=currencieList

//    };
//    models.Add(model);

//}


string fileName = "../../../Jsonfiles/CloudGeography.json";
//string jsonString = JsonSerializer.Serialize(models);
//File.WriteAllText(fileName, jsonString);


string jsonString = File.ReadAllText(fileName);
List <CountryModel> country = JsonSerializer.Deserialize<List<CountryModel>>(jsonString);

//CountryModel? geographyModel =
//                JsonSerializer.Deserialize<CountryModel>(fileName);

Console.WriteLine(country[0].Area);

