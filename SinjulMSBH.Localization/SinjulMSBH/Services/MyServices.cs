namespace SinjulMSBH.Localization.SinjulMSBH.Services
{
    using DbLocalizationProvider;

    using Microsoft.Extensions.Localization;

    public class MyService
    {
        public MyService(IStringLocalizer localizer)
        {
            Localizer = localizer;
        }
        public MyService(LocalizationProvider provider)
        {
            Provider = provider;
        }

        public IStringLocalizer Localizer { get; }
        public LocalizationProvider Provider { get; }
    }
}
