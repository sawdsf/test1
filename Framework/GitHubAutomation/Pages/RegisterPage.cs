using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace GitHubAutomation.Pages
{
    public class RegisterPage
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerDataSalutation']")]
        private IWebElement Anrede { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerDataFirstName']")]
        private IWebElement Vorname { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerLastName']")]
        private IWebElement Nachname { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerStreet']")]
        private IWebElement Strasse { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerStreetNumber']")]
        private IWebElement Hausnr { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerZip']")]
        private IWebElement PLZ { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerCity']")]
        private IWebElement ORT { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='CustomerCountry']")]
        private IWebElement Contry { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registerForm']/div[5]/div[2]/input")]
        private IWebElement Mail { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registerForm']/div[6]/div[2]/input")]
        private IWebElement Mail_sek { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registerForm']/div[9]/div[1]/input[2]")]
        private IWebElement Check1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='agb']")]
        private IWebElement Check2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='registerForm']/div[11]/div/div/input")]
        private IWebElement Speichern { get; set; }
        //*[@id="content"]/div/div[2]/div/ul/li
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[2]/div/ul/li")]
        private IWebElement ErrorC { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[2]/div/div[2]/p[1]/strong")]
        private IWebElement OK { get; set; }
        public RegisterPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void anrede(string mal) =>new SelectElement(Anrede).SelectByText(mal);

        public void FisrtName(string name) => Vorname.SendKeys(name);

        public void SekondName(string Name) => Nachname.SendKeys(Name);

        public void Street(string Name) => Strasse.SendKeys(Name);
        public void Home(string Name) => Hausnr.SendKeys(Name);
        public void Index(string Name) => PLZ.SendKeys(Name);
        public void Stade(string Name) => ORT.SendKeys(Name);
        public void Cuontry(string Name) => new SelectElement(Contry).SelectByText(Name);
        public void Email1(string Name) => Mail.SendKeys(Name);
        public void Email2(string Name) => Mail_sek.SendKeys(Name);
        public string GetNameErrorText() => OK.Text;
        public string CapthError() => ErrorC.Text;
        public void Chek1() => Check1.Click();
        public void chek2() => Check2.Click();
        public void RegisterClick() => Speichern.Click();


        
    }
}