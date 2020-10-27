using BookShop.AcceptanceTests.Drivers;
using TechTalk.SpecFlow;

namespace BookShop.AcceptanceTests.StepDefinitions
{
    [Binding]
    public class HomeSteps
    {
        private readonly IHomeDriver _homeDriver;

        public HomeSteps(IHomeDriver driver)
        {
            _homeDriver = driver;
        }

        [When(@"Ingreso a la tienda virtual")]
        public void WhenIEnterTheShop()
        {
            _homeDriver.Navigate();
        }

        [Then(@"La pantalla de inicio deberia mostrar el libro '(.*)'")]
        public void ThenTheHomeScreenShouldShowTheBook(string expectedTitle)
        {
            _homeDriver.ShowsBook(expectedTitle);
        }

        [Then(@"La pantalla de inicio deberia mostrar los libros (.*)")]
        public void ThenTheHomeScreenShouldShowTheBooks(string expectedTitleList)
        {
            _homeDriver.ShowsBooks(expectedTitleList);
        }

        [Then(@"La pantalla de inicio deberia mostrar los libros")]
        public void ThenTheHomeScreenShouldShowTheFollowingBooks(Table expectedBooks)
        {
            _homeDriver.ShowsBooks(expectedBooks);
         }

    }
}
