using AutoProductSearchCart.Drivers;
using AutoProductSearchCart.PageObjects;
using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace AutoProductSearchCart.StepDefinitions
{
    [Binding]
    public class ProductsSteps : DriverHelper
    {
        ProductsPage productsPage;
        public ProductsSteps(IObjectContainer container)
        {
            Driver = container.Resolve<IWebDriver>();
            productsPage = container.Resolve<ProductsPage>();
        }

        [Given(@"I navigate to automation website")]
        public void GivenINavigateToAutomationWebsite()
        {
            productsPage.NavigateToUrl();

        }

        [When(@"I click on Login")]
        public void WhenIClickOnLogin()
        {
             productsPage.ClickLoginSignBttn();
        }

        [When(@"Input my details")]
        public void WhenInputMyDetails()
        {
            productsPage.InputLoginDetails();  
        }

        [When(@"I click on Login button")]
        public void WhenIClickOnLoginButton()
        {
            productsPage.ClickLoginBttn();
        }

        [When(@"I click on product menu")]
        public void WhenIClickOnProductMenu()
        {
             productsPage.ClickProductsMenu();
        }

        [Given(@"I click on product menu")]
        public void GivenIClickOnProductButton()
        {
            productsPage.ClickProductsMenu(); 
        }

        [Then(@"I am on the products page")]
        public void ThenIAmOnTheProductsPage()
        {
             Assert.True(productsPage.ValidateProductsPage());
        }

        [Then(@"I enter product name in search bar")]
        public void ThenIEnterProductNameInSearchBar()
        {
            productsPage.InputProductToSearch();
        }

        [When(@"I click search button")]
        public void WhenIClickSearchButton()
        {
            productsPage.ClickSearch();
        }

        [Then(@"related products are visible")]
        public void ThenRelatedProductsAreVisible()
        {
            Thread.Sleep(1000);
            Assert.True(productsPage.ValidateReelatedProductsAreVisible());
        }
        [Then(@"I click on view product")]
        public void ThenIClickOnViewProduct()
        {

            productsPage.ClickViewProduct();
        }

        [Then(@"I add the product to the cart")]
        public void ThenIAddTheProductToTheCart()
        {
             productsPage.ClickAddToCart();
        }

        [Then(@"I click on view cart")]
        public void ThenIClickOnViewCart()
        {
             productsPage.ClickViewCart();
        }

        [Then(@"product should be visibled")]
        public void ThenProductShouldBeVisibled()
        {
            Assert.True(productsPage.ProductShouldBeVisibled());
        }
    }
}
