using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    class ToInfoPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset - memberlogin']/div[3]/div")]
        private IWebElement ErrorMesagesLoginArt { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset - memberlogin']/div[1]/div[2]/input")]
        private IWebElement EmailArt { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset - memberlogin']/div[2]/div[2]/input")]
        private IWebElement PasswordArd { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset - memberlogin']/div[3]/div/div/input")]
        private IWebElement EinloggenArt { get; set; }
        //*[@id="sidebar"]/div[1]
        [FindsBy(How = How.XPath, Using = "//*[@id='sidebar']/div[1]")]
        private IWebElement InfoLoggin { get; set; }

        private readonly IWebDriver browser;

        public ToInfoPage(IWebDriver browser)
        {
            this.browser = browser;
            PageFactory.InitElements(browser, this);
        }

       

        public string GetNameErrorText() => ErrorMesagesLoginArt.Text;
        public string Infolog() => InfoLoggin.Text;
        public void InfoMail(string email) => EmailArt.SendKeys(email);
        public void InfoPass(string pass) => PasswordArd.SendKeys(pass);
        public void Einloggen() => EinloggenArt.Click();
    }
}
