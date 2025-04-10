namespace Resume_NicolasCastillo_Backend.Servicios
{
    public interface IConfigurationService
    {
        string GetSetting(string section, string key);
    }

    public class ConfigurationService : IConfigurationService
    {
        private readonly IConfiguration _IConfig;

        public ConfigurationService(IConfiguration configuration)
        {
            _IConfig = configuration;
        }

        public string GetSetting(string section, string key)
        {
            if (String.IsNullOrEmpty(section))
                return _IConfig.GetConnectionString(key);
            else
                return _IConfig.GetSection(section)[key];
        }
    }
}
