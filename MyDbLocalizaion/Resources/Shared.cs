using DbLocalizationProvider;

namespace MyDbLocalizaion.Resources
{
    public class Shared
    {
        [LocalizedResource]
        public class CommonResources
        {
            public static string Yes => "Yup";

            public string No => "Nop";
        }
    }
}
