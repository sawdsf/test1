using NUnit.Framework;
using GitHubAutomation.Pages;
using GitHubAutomation.Services;
using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using NUnit.Framework;
using log4net;
using log4net.Config;
using GitHubAutomation.Driver;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace GitHubAutomation.Tests
{
    [TestFixture]
    public class WebTests : GeneralConfig
    {
        [Test]
        public void test1()
        {
            TakeScreenshotWhenTestFailed(() =>
            {//Leider konnten wir keine Reiseziele oder Hotels finden - Bitte passen Sie Ihre Suche an
                const string emptyFieldErrorText = "Wir haben die folgenden Ergebnisse für Sie gefunden - Bitte wählen sie ein Ziel";
                var index = new MainPage(Driver);
                index.Name_Entry("minsk");
                index.SelectClick();
                Assert.AreEqual(emptyFieldErrorText, index.GetNameErrorText());
            });
        }
        [Test]
        public void test8()
        {
            TakeScreenshotWhenTestFailed(() =>
            {//Leider konnten wir keine Reiseziele oder Hotels finden - Bitte passen Sie Ihre Suche an
                const string emptyFieldErrorText = "Bitte geben Sie Ihr gewünschtes Reiseziel an.";
                var index = new MainPage(Driver);
                index.SelectClick();
                Assert.AreEqual(emptyFieldErrorText, index.NullError());
            });
        }
        [Test]
        public void test6()
        {
            TakeScreenshotWhenTestFailed(() =>
            {//Leider konnten wir keine Reiseziele oder Hotels finden - Bitte passen Sie Ihre Suche an
                const string emptyFieldErrorText = "Leider konnten wir keine Reiseziele oder Hotels finden - Bitte passen Sie Ihre Suche an";
                var index = new MainPage(Driver);
                index.Name_Entry("qwertyuioooooooplkjh");
                index.SelectClick();
                Assert.AreEqual(emptyFieldErrorText, index.GetNameErrorText());
            });
        }
        [Test]
        public void test2()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Sie haben Schwierigkeiten beim Einloggen?\nTragen Sie bitte Ihre E - Mail - Adresse ein, mit der Sie sich bei uns registriert haben und wir werden Ihnen in Kürze Ihren neuen Aktivierungslink zuschicken.";
                var index = new MainPage(Driver);
                index.Autoriz1_st();
                index.Send_Email("p.lev4ik@yandex.ru");
                index.Send_Password("qwe123qw");
                index.Enter();
                
                System.Threading.Thread.Sleep(1000);
                var screenshot = Driver.TakeScreenshot();
                Driver.SwitchTo().Window(Driver.WindowHandles[1]);
                
                index = new MainPage(Driver);
                System.Threading.Thread.Sleep(1000);
                screenshot = Driver.TakeScreenshot();
                Assert.AreEqual(emptyFieldErrorText, index.Infolog());
            });
        }
        [Test]
        public void test4()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Ihre Kundennummer: 3955759";
                var index = new MainPage(Driver);
                index.Autoriz1_st();
                index.Send_Email("p.lev4ik@yandex.ru");
                index.Send_Password("QWERTYqwerty");
                index.Enter();

                System.Threading.Thread.Sleep(1000);
                Driver.SwitchTo().Window(Driver.WindowHandles[1]);
                var info = new ToInfoPage(Driver);
                System.Threading.Thread.Sleep(1000);
                Assert.AreEqual(emptyFieldErrorText, info.Infolog());
            });
        }
        [Test]
        public void Test3()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Sie haben Schwierigkeiten beim Einloggen?\nTragen Sie bitte Ihre E - Mail - Adresse ein, mit der Sie sich bei uns registriert haben und wir werden Ihnen in Kürze Ihren neuen Aktivierungslink zuschicken.";
                Driver.Navigate().GoToUrl("https://login.hotelreservierung.de");
                
                var Logpage = new LogginPage(Driver);

                Logpage.Email("p.lev4ik@yandex.ru");
                Logpage.Password("qwe123qwe");
                System.Threading.Thread.Sleep(1000);
                Logpage.EinLogen();
                System.Threading.Thread.Sleep(1000);
                Assert.AreEqual(emptyFieldErrorText, Logpage.Infolog());
            });
        }

        [Test]
        public void Test5()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Vielen Dank für Ihre Registrierung.";
                Driver.Navigate().GoToUrl("https://login.hotelreservierung.de");

                var Logpage = new LogginPage(Driver);

                Logpage.Reg();
                var Regis = new RegisterPage(Driver);
                Regis.anrede("Frau");
                Regis.FisrtName("Левчик");
                Regis.SekondName("Павел");
                Regis.Street("Nadej");
                Regis.Home("19");
                Regis.Index("123");
                Regis.Stade("Minsk");
                Regis.Cuontry("Weißrussland");
                Regis.Email1("lew@yande.ru");
                Regis.Email2("lew@yande.ru");
                Regis.Chek1();
                Regis.chek2();
                Regis.RegisterClick();
                Assert.AreEqual(emptyFieldErrorText, Regis.GetNameErrorText());
            });
        }
        [Test]
        public void Test7()
        {
            TakeScreenshotWhenTestFailed(() =>
            {
                const string emptyFieldErrorText = "Bitte geben Sie das Captcha korrekt ein.";
                Driver.Navigate().GoToUrl("https://login.hotelreservierung.de");

                var Logpage = new LogginPage(Driver);

                Logpage.Reg();
                var Regis = new RegisterPage(Driver);
                Regis.anrede("Frau");
                Regis.FisrtName("Левчик");
                Regis.SekondName("Павел");
                Regis.Street("Nadej");
                Regis.Home("19");
                Regis.Index("123");
                Regis.Stade("Minsk");
                Regis.Cuontry("Weißrussland");
                Regis.Email1("lew@yandex.ru");
                Regis.Email2("lew@yandex.ru");
                Regis.Chek1();
                Regis.chek2();
                Regis.RegisterClick();
                Assert.AreEqual(emptyFieldErrorText, Regis.CapthError());
            });
        }
        //[Test]
        //public void Register_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string passwordErrorText = "Минимум 6 символов";
        //        var mainPage = new MainPage(Driver);
        //        var registerPage = new RegisterPage(Driver);

        //        mainPage.LoginClick();
        //        mainPage.RegisterClick();
        //        registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
        //        registerPage.RegisterClick();

        //        Assert.AreEqual(passwordErrorText, registerPage.GetPasswordError());
        //    });
        //}

        //[Test]
        //public void Register_EnterInvalidMail_InvalidEmailErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string emailErrorText = "Неверный формат";
        //        var mainPage = new MainPage(Driver);
        //        var registerPage = new RegisterPage(Driver);

        //        mainPage.LoginClick();
        //        mainPage.RegisterClick();
        //        registerPage.EnterEmail(TestDataReader.GetTestData("Email"));
        //        registerPage.RegisterClick();

        //        Assert.AreEqual(emailErrorText, registerPage.GetEmailError());
        //    });
        //}

        //[Test]
        //public void Register_EnterDifferentPasswords_NotMatchingPasswordsErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string CpasswordErrorText = "Пароли не совпадают";
        //        var mainPage = new MainPage(Driver);
        //        var registerPage = new RegisterPage(Driver);

        //        mainPage.LoginClick();
        //        mainPage.RegisterClick();
        //        registerPage.EnterPassword(TestDataReader.GetTestData("Password"));
        //        registerPage.EnterCPassword(TestDataReader.GetTestData("Password2"));
        //        registerPage.RegisterClick();

        //        Assert.AreEqual(CpasswordErrorText, registerPage.GetConfirmPasswordError());
        //    });
        //}

        //[Test]
        //public void Login_EnterWrongCredentials_WrongCredentialsErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        var mainPage = new MainPage(Driver);
        //        var registerPage = new RegisterPage(Driver);

        //        mainPage.LoginClick();
        //        mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
        //        mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
        //        mainPage.EnterLogin(TestDataReader.GetTestData("email"));
        //        mainPage.Login2Click();
        //        Assert.IsTrue(mainPage.GetWrongCredentialsError());
        //    });
        //}

        //[Test]
        //public void Login_EnterThreeSymbolsInPasswordField_PasswordLengthErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string passwordErrorText = "Минимум 6 символов";
        //        var mainPage = new MainPage(Driver);
        //        var registerPage = new RegisterPage(Driver);

        //        mainPage.LoginClick();
        //        mainPage.EnterPassword(TestDataReader.GetTestData("Password"));
        //        mainPage.Login2Click();

        //        Assert.AreEqual(passwordErrorText, mainPage.GetPasswordError());
        //    });
        //}

        //[Test]
        //public void PurchaseToy_EnterInvalidMail_InvalidEmailErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string emailErrorText = "Неверный формат";
        //        var mainPage = new MainPage(Driver);
        //        var toyInfoPage = new ToyInfoPage(Driver);

        //        mainPage.SelectToyClick();
        //        toyInfoPage.PurchaseToyClick();
        //        toyInfoPage.EnterEmail(TestDataReader.GetTestData("Email"));
        //        toyInfoPage.SendOrderClick();

        //        Assert.AreEqual(emailErrorText, toyInfoPage.GetEmailError());
        //    });
        //}

        //[Test]
        //public void PurchaseToy_EnterEmptyNameInChipForms_EmptyFieldErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string emptyFieldErrorText = "Заполните это поле";
        //        var mainPage = new MainPage(Driver);
        //        var toyInfoPage = new ToyInfoPage(Driver);

        //        mainPage.SelectToyClick();
        //        toyInfoPage.CheaperClick();
        //        toyInfoPage.SendChiperClick();

        //        Assert.AreEqual(emptyFieldErrorText, toyInfoPage.GetChipNameErrorText());
        //    });
        //}

        //[Test]
        //public void PurchaseToy_EnterInvalidMailForChiperItem_InvalidEmailErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string emailErrorText = "Неверный формат";
        //        var mainPage = new MainPage(Driver);
        //        var toyInfoPage = new ToyInfoPage(Driver);

        //        mainPage.SelectToyClick();
        //        toyInfoPage.PurchaseToyClick();
        //        toyInfoPage.ChiperEnterEmail(TestDataReader.GetTestData("Email"));
        //        toyInfoPage.SendOrderClick();

        //        Assert.AreEqual(emailErrorText, toyInfoPage.ChiperGetEmailError());
        //    });
        //}

        //[Test]
        //public void Login_EnterEmptyLogin_InvalidLoginErrorAppears()
        //{
        //    TakeScreenshotWhenTestFailed(() =>
        //    {
        //        const string emailErrorText = "Заполните это поле";
        //        var mainPage = new MainPage(Driver);
        //        mainPage.LoginClick();
        //        mainPage.Login2Click();

        //        Assert.AreEqual(emailErrorText, mainPage.GetLoginError());
        //    });
        //}
    }
}
