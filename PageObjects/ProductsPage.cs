using AutoProductSearchCart.Drivers;
using AutoProductSearchCart.Support;
using BoDi;
using OpenQA.Selenium;

namespace AutoProductSearchCart.PageObjects
{
    public class ProductsPage : DriverHelper
    {
        ReadJsonData readJsonData;
        public ProductsPage(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            readJsonData = container.Resolve<ReadJsonData>();
        }

        IWebElement loginSignBttn => Driver!.FindthisElement(By.XPath("//*[@href='/login']"));
        IWebElement userEmail => Driver!.FindthisElement(By.CssSelector("*[data-qa='login-email'"));
        IWebElement userPassword => Driver!.FindthisElement(By.CssSelector("*[data-qa='login-password'"));
        IWebElement loginBttn => Driver!.FindthisElement(By.XPath("(//*[@type='submit'])[1]"));
        IWebElement productBttn => Driver!.FindthisElement(By.XPath("//*[@href='/products']"));
        IWebElement searchBar => Driver!.FindthisElement(By.Id("search_product"));
        IWebElement search => Driver!.FindthisElement(By.CssSelector("[id='submit_search']"));
        IWebElement addToCart => Driver!.FindthisElement(By.XPath("(//a[@data-product-id='33'])[1]"));
        IWebElement viewCart => Driver!.FindthisElement(By.XPath("(//*[@href='/view_cart'])[2]"));

        public void NavigateToUrl() => 
            Driver?.Navigate().GoToUrl(readJsonData.GetData("environ:url"));

        public void ClickLoginSignBttn() => loginSignBttn.ClicktheElement();

        public void InputLoginDetails()
        {
            userEmail.InputTextToElement(readJsonData.GetData("environ:email"));
            userPassword.InputTextToElement(readJsonData.GetData("environ:password"));
        }

        public void ClickLoginBttn() => loginBttn.ClicktheElement();

        public void ClickProductsMenu()
        {
            try
            {
                productBttn.ClicktheElement();
                Thread.Sleep(500);
                Driver?.Navigate().Refresh();
                Thread.Sleep(500);
                productBttn.ClicktheElement();
            }
            catch (Exception){ throw;}
        }

        public bool ValidateProductsPage() => Driver!.Url.Equals("https://www.automationexercise.com/products");

        public void InputProductToSearch() => 
            searchBar.InputTextToElement(readJsonData.GetData("environ:searchword"));

        public void ClickSearch() => search.ClicktheElement();
        
        public bool ValidateReelatedProductsAreVisible() =>
             Driver!.Url.Equals("https://www.automationexercise.com/products?search=Jeans");

        public void ClickAddToCart() => addToCart.ClicktheElement();

        public void ClickViewCart() => viewCart.ClicktheElement();

        public bool ProductShouldBeVisibled() =>
            Driver!.Url.Equals("https://www.automationexercise.com/view_cart");
    }
 
}
