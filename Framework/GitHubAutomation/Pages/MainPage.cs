using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace GitHubAutomation.Pages
{
    public class MainPage
    {
        [FindsBy(How = How.XPath, Using = "//*[@id='pageWrapper']/div[1]/div[2]/div/form/div[4]/button")]
        private IWebElement Angebote_suchen { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='mainsearch_baseSearchTerm']")]
        private IWebElement Stadt_Region_o_Hotel { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='mainsearch_baseArrivalDate']")]
        private IWebElement f1_st_date_pt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='ui - datepicker - div']/div[2]/table/tbody/tr[2]/td[2]/a[2]")]
        private IWebElement f1_st_date_pr2 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='mainsearch_baseDepartureDate']")]
        private IWebElement f2_st_date_pt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='ui - datepicker - div']/div[1]/table/tbody/tr[2]/td[6]/a[2]")]
        private IWebElement f2_st_date_pt2 { get; set; }
        //*[@id="pageWrapper"]/div[1]/div[2]/div/div/strong
        [FindsBy(How = How.XPath, Using = "//*[@id='pageWrapper']/div[1]/div[2]/div/div/strong")]
        private IWebElement ErrorNull { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='pageWrapper']/div[1]/div[2]/div/form/div[3]/div[1]/div")]
        //private IWebElement Persons_Zimmer { get; set; }
        //[FindsBy(How = How.XPath, Using = "//*[@id='mainsearch_baseNumberOfAdults']")]
        //private IWebElement Persons { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='pageHeader']/div[2]/header/div[2]/div[2]/label[1]")]
        private IWebElement Autoriz_pt1 { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='pageHeader']/div[2]/header/div[2]/div[2]/div/div/form/div[1]/input")]
        private IWebElement Autoriz_mail { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='pageHeader']/div[2]/header/div[2]/div[2]/div/div/form/div[2]/input")]
        private IWebElement Autoriz_password { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='pageHeader']/div[2]/header/div[2]/div[2]/div/div/form/div[2]/button")]
        private IWebElement Anmelden { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='pageWrapper']/div/div[2]/div/h2")]
        private IWebElement NameErrorLabel { get; set; }
        //*[@id="content"]/div/div[2]/div/div[2]/div[3]/div
        [FindsBy(How = How.XPath, Using = "//*[@id='content']/div/div[2]/div/div[2]/div[3]/div")]
        private IWebElement InfoLoggin { get; set; }

        public MainPage(IWebDriver browser)
        {
            PageFactory.InitElements(browser, this);
        }

        public void SelectClick() => Angebote_suchen.Click();
        public void Date_Entry11() => f1_st_date_pt1.Click();
        public void Date_Entry12() => f1_st_date_pr2.Click();
        public void Date_Entry21() => f2_st_date_pt1.Click();
        public void Date_Entry22() => f2_st_date_pt2.Click();
        public void Name_Entry(string name_hotel) => Stadt_Region_o_Hotel.SendKeys(name_hotel);
        public string GetNameErrorText() => NameErrorLabel.Text;
        public void Autoriz1_st() => Autoriz_pt1.Click();
        public void Send_Email(string mail) => Autoriz_mail.SendKeys(mail);
        public void Send_Password(string pass) => Autoriz_password.SendKeys(pass);
        public void Enter() => Anmelden.Click();
        public string Infolog() => InfoLoggin.Text;
        public string NullError() => ErrorNull.Text;


    }
}
