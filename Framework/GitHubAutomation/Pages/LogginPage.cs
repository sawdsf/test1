using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    class LogginPage
    {
        //*[@id="fieldset-memberlogin"]/div[1]/div[2]/input
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset-memberlogin']/div[1]/div[2]/input")]
        private IWebElement Mail { get; set; }
        //*[@id='fieldset-memberlogin']/div[2]/div[2]/input
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset-memberlogin']/div[2]/div[2]/input")]
        private IWebElement Pass { get; set; }
        //*[@id="fieldset-memberlogin"]/div[3]/div/div/input
        [FindsBy(How = How.XPath, Using = "//*[@id='fieldset-memberlogin']/div[3]/div/div/input")]
        private IWebElement EinLoggenArt { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[2]/div/div[2]/div[3]/div")]
        private IWebElement Error { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[2]/div/div[2]/div/a[2]")]
        private IWebElement Registr { get; set; }
        public LogginPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }
        public void EinLogen() => EinLoggenArt.Click();
        public void Email(string Email) => Mail.SendKeys(Email);
        public void Password(string Pas) => Pass.SendKeys(Pas);
        public string Infolog() => Error.Text;
        public void Reg() => Registr.Click();
    }
}
