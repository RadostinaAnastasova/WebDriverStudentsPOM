using OpenQA.Selenium;

namespace WebDriverStudentsPOM.Pages
{
    public class HomePage : BasePage
    {
        private readonly IWebDriver driver;
        // may not be readonly
        public HomePage(WebDriver driver) : base(driver)
        {
        }

        public override string BaseUrl => "https://studentregistry.softuniqa.repl.co/";

        public IWebElement RegisteredStudentsLable => driver.FindElement(By.CssSelector("body > p"));
    }
}
