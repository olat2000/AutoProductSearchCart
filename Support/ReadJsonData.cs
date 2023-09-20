using Microsoft.Extensions.Configuration;

namespace AutoProductSearchCart.Support
{
    public class ReadJsonData
    {
        public IConfigurationRoot _config;

        public ReadJsonData()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("Support\\settings.json");
            _config = builder.Build();
        }

        public string GetData(string key) => _config[key]!;
    }
}
