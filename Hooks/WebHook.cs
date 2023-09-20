using AutoProductSearchCart.Drivers;
using BoDi;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace AutoProductSearchCart.Hooks
{
    [Binding]
    public sealed class WebHook : DriverHelper
    {
        IObjectContainer container;
        public WebHook(IObjectContainer objectContainer)
        {
            container =  objectContainer;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--start-maximized", "--Incognito");
            options.AddArguments("--no-sandbox");
            options.AddArgument("--headless");
            Driver = new ChromeDriver(options);
            container.RegisterInstanceAs(Driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver?.Quit();
        }
    }
}