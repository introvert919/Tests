using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;
using NUnit.Framework.Legacy;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.Drawing;
using System.Configuration;

namespace UnitTestProject2
{
    [TestFixture]
    public class UnitTests
    {

        IWebDriver driver;

        [OneTimeSetUp]

        //Открываем страницу
        public void Open_url()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://npfsberbanka.ru/pds");
        }

        //Закрываем страницу
        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

        // Обновляем страницу
        [TearDown]
        public void TearDown1()
        {
            driver.Navigate().Refresh();
        }


        // Общий рассчет (демонстрационный).
        // Тест: общий рассчет. Тес-кейс: значения по умолчанию.

        [Test]

        public void Default_calculation()
        {
            // "Ваш официальный доход".
            var Оfficial_income = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/div[1]/div[1]/div[1]/div/div/div/span[2]"));
            string Оfficial_income_iter = Оfficial_income.Text;

            // "Сумма взносов в Программу в Месяц".
            var Contributions = driver.FindElement(By.XPath("//*[@id=\"Сумма взносов в Программу в месяц\"]"));
            string Contributions_iter1 = Contributions.GetAttribute("value");

            string Contributions_iter2 = "";
            string Numbers1 = "0123456789";

            for (int i = 0; i < Contributions_iter1.Length; i++)
            {
                if (Numbers1.Contains(Contributions_iter1[i]))
                {
                    Contributions_iter2 += Contributions_iter1[i];
                }
            }

            int Contributions_int = int.Parse(Contributions_iter2);

            // "Перевод накоплений ОПС в Программу".
            var Transactions = driver.FindElement(By.XPath("//*[@id=\"Перевод накоплений ОПС в Программу\"]"));
            string Transactions_iter1 = Transactions.GetAttribute("value");

            string Transactions_iter2 = "";
            string Numbers2 = "0123456789";

            for (int i = 0; i < Transactions_iter1.Length; i++)
            {
                if (Numbers2.Contains(Transactions_iter1[i]))
                {
                    Transactions_iter2 += Transactions_iter1[i];
                }
            }

            int Transaction_int = int.Parse(Transactions_iter2);

            // "Ваш возраст".
            var Age = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/div[1]/div[2]/div[1]/div[2]/div[1]/div/div[5]/div[4]"));
            string Age_iter = Age.GetAttribute("aria-valuenow");
            int Age_int = int.Parse(Age_iter);

            // "Возраст начала получения выплат".
            var Start_payment = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/div[1]/div[2]/div[2]/div[1]/div/div[5]/div[4]"));
            string Start_payment_iter = Start_payment.GetAttribute("aria-valuenow");
            int Start_payment_int = int.Parse(Start_payment_iter);

            // Срок срочной выплаты
            var Express_payment = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/div[1]/div[2]/div[3]/div[1]/div/div[5]/div[4]"));
            string Express_payment_iter = Express_payment.GetAttribute("aria-valuenow");
            int Express_payment_int = int.Parse(Express_payment_iter);

            // Вычисление резульата.

            int Actual = Contributions_int * (Start_payment_int - Age_int) + Transaction_int - Express_payment_int + 3094058;
            int Expected = 3166548;

            ClassicAssert.AreEqual(Expected, Actual);
        }

        // Поле "Калькулятор долгосрочных сбережений".
        // Тест: поле "Калькулятор долгосрочных сбережений". Тест-кейс: текст поля.

        [Test]

        public void Title1_text()
        {
            var Title1 = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/h2"));
            string Actual = Title1.Text;
            string Expected = "Калькулятор долгосрочных сбережений";
            ClassicAssert.AreEqual(Expected, Actual);
        }

        // Поле "Укажите данные".
        // Тест: поле "Укажите данные". Тест-кейс: текст поля.
        [Test]

        public void Title2_text()
        {
            var Title2 = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/p"));
            string Actual = Title2.Text;
            string Expected = "УКАЖИТЕ ДАННЫЕ";
            ClassicAssert.AreEqual(Expected, Actual);
        }

        // Поле " Ваш официальный доход".
        // Тест: поле "Ваш официальный доход", Тест-кейс: текст поля.

        [Test]

        public void Offitial_income_text()
        {
            var Оfficial_income = driver.FindElement(By.XPath("//*[@id=\"calc\"]/div/form/div[1]/div[1]/div[1]/div/label"));
            string Actual = Оfficial_income.Text;
            string Expected = "Ваш официальный доход";
            ClassicAssert.AreEqual(Expected, Actual);
        }

        // Тест: поле "Ваш официальный доход". Тест - кейс: переключение элементов списка.

        [TestCase("до 80 000 ₽", 0, "//*[@id=\"Ваш официальный доход\"]",
         "//*[@id=\"calc\"]/div/form/div[1]/div[1]/div[1]/div/div/div/span[2]")] // Значение "от 80 000".
        [TestCase("от 80 000 до 150 000 ₽", 1, "//*[@id=\"Ваш официальный доход\"]",
         "//*[@id=\"calc\"]/div/form/div[1]/div[1]/div[1]/div/div/div/span[2]")] // Значение "от 80 000 до 150 000".
        [TestCase("от 150 000 ₽", 2, "//*[@id=\"Ваш официальный доход\"]",
         "//*[@id=\"calc\"]/div/form/div[1]/div[1]/div[1]/div/div/div/span[2]")] // Значение "от 150 000".

        public void Offitial_income_value(string Expected, int Key_count, string XPath_str, string XPath_str2)
        {
            var Оfficial_income = driver.FindElement(By.XPath(XPath_str));

            Оfficial_income.SendKeys(Keys.Enter);
            for (int i = 0; i < Key_count; i++) { Оfficial_income.SendKeys(Keys.Down); }
            Оfficial_income.SendKeys(Keys.Enter);

            var Оfficial_income_text = driver.FindElement(By.XPath(XPath_str2));
            string Actual = Оfficial_income_text.Text;
            ClassicAssert.AreEqual(Expected, Actual);
        }
    }
}