using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace AutoProductSearchCart
{
    public static class CustomExtensions
    {
        /// <summary>
        /// This method allows user to click
        /// </summary>
        /// <param name="element"></param>
        public static void ClicktheElement(this IWebElement element) => element.Click();

        /// <summary>
        /// Theis method allow user to input text 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void InputTextToElement(this IWebElement element, string value) 
            => element.SendKeys(value);

        /// <summary>
        /// This method will find an element with wait
        /// </summary>
        /// <param name="Driver"></param>
        /// <param name="locator"></param>
        public static IWebElement FindthisElement(this IWebDriver Driver, By locator)
        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            return wait.Until(ExpectedConditions.ElementToBeClickable(locator));
        }  
    }
}
