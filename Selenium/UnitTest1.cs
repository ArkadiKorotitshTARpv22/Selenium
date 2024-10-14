using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace Selenium_Testing
{
    [TestFixture]
    public class GoogleSearchTest1
    {
        private IWebDriver? driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver(@"C:\Users\Arkadi\source\repos\Selenium\Selenium\driver");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        [Test, Order(1)]
        public void FirstTest()
        {
            try
            {
                driver.Navigate().GoToUrl("https://arkadikorotots22.thkit.ee");

                System.Threading.Thread.Sleep(1000);

                var wpbutton = driver.FindElement(By.CssSelector("#btn4"));
                wpbutton.Click();
                
                System.Threading.Thread.Sleep(1000);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during the test " + ex.Message);
                throw;
            }
        }
        [Test, Order(2)]
        public void SecondTest()
        {
            try
            {
                driver.Navigate().GoToUrl("https://arkadikorotots22.thkit.ee");

                System.Threading.Thread.Sleep(1000);

                var toodButton = driver.FindElement(By.CssSelector("#btn3"));
                toodButton.Click();

                System.Threading.Thread.Sleep(1000);

                var jslehtLink = driver.FindElement(By.CssSelector("#myModal2 > div > div.modal-body > nav > ul > li:nth-child(12) > a"));
                jslehtLink.Click();

                System.Threading.Thread.Sleep(1000);
                var inputField = driver.FindElement(By.Id("nimi"));
                inputField.SendKeys("Arkadi");
                Assert.That(inputField.GetAttribute("value"), Is.EqualTo("Arkadi"), "Error, name in the field is not equal to input.");

                System.Threading.Thread.Sleep(1000);

                var inputFieldMeil = driver.FindElement(By.Id("emailadress"));
                inputFieldMeil.SendKeys("arkadikorotitsh@gmail.com");
                Assert.That(inputFieldMeil.GetAttribute("value"), Is.EqualTo("arkadikorotitsh@gmail.com"), "Error, name in the field is not equal to input.");
                System.Threading.Thread.Sleep(1000);

                var popCheckbox = driver.FindElement(By.Id("Pop"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click();", popCheckbox);
                Assert.That(popCheckbox.GetAttribute("checked"), Is.EqualTo("true"), "Error, Pop checkbox is not selected.");
                System.Threading.Thread.Sleep(1000);

                var select = driver.FindElement(By.Id("arvakooli"));
                var selectElement = new SelectElement(select);
                selectElement.SelectByText("Saate igal ajal muusikat kuulata.");
                Assert.That(selectElement.SelectedOption.Text, Is.EqualTo("Saate igal ajal muusikat kuulata."), "Error, select option is not selected.");
                System.Threading.Thread.Sleep(1000);

                var tundipaevasInput = driver.FindElement(By.Id("mitutundi"));
                tundipaevasInput.SendKeys("2");
                Assert.That(tundipaevasInput.GetAttribute("value"), Is.EqualTo("2"), "Error, tundipaevas value in the field is not equal to input.");
                System.Threading.Thread.Sleep(1000);

                var jahRadio = driver.FindElement(By.Id("jah"));
                jahRadio.Click();
                Assert.That(jahRadio.Selected, Is.True, "Error, jah radio button is not selected.");
                System.Threading.Thread.Sleep(1000);

                var jah2Radio = driver.FindElement(By.Id("jah2"));
                jah2Radio.Click();
                Assert.That(jah2Radio.Selected, Is.True, "Error, jah2 radio button is not selected.");
                System.Threading.Thread.Sleep(1000);

                var theBeatlesCheckbox = driver.FindElement(By.Id("The Beatles2"));
                theBeatlesCheckbox.Click();
                Assert.That(theBeatlesCheckbox.Selected, Is.True, "Error, The Beatles checkbox is not selected.");
                System.Threading.Thread.Sleep(1000);

                var esimeneInput = driver.FindElement(By.Id("1"));
                esimeneInput.SendKeys("Eminem");
                Assert.That(esimeneInput.GetAttribute("value"), Is.EqualTo("Eminem"), "Error, esimene value in the field is not equal to input.");
                System.Threading.Thread.Sleep(1000);

                var teineInput = driver.FindElement(By.Id("2"));
                teineInput.SendKeys("KSI");
                Assert.That(teineInput.GetAttribute("value"), Is.EqualTo("KSI"), "Error, teine value in the field is not equal to input.");
                System.Threading.Thread.Sleep(1000);

                var rangeSlider = driver.FindElement(By.Id("distanss"));
                IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
                js.ExecuteScript("arguments[0].value = 3; arguments[0].dispatchEvent(new Event('change'));", rangeSlider);

                Assert.That(rangeSlider.GetAttribute("value"), Is.EqualTo("3"), "Slider is not set in right position.");
                System.Threading.Thread.Sleep(1000);

                var dateInput = driver.FindElement(By.Id("111"));
                ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].value = '2022-01-01';", dateInput);
                Assert.That(dateInput.GetAttribute("value"), Is.EqualTo("2022-01-01"), "Error, date value in the field is not equal to input.");
                System.Threading.Thread.Sleep(1000);

                

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during the test " + ex.Message);
                throw;
            }
        }
        
        [Test, Order(3)]
        public void LoginTest()
        {
            try
            {
                try
                {
                    driver.Navigate().GoToUrl("https://arkadikorotots22.thkit.ee/jsleht/content/andmebaas/tantsudTahtega/haldusLeht.php");

                    System.Threading.Thread.Sleep(1000);
                    var logiSisseButton = driver.FindElement(By.Id("myBtn"));
                    logiSisseButton.Click();
                    System.Threading.Thread.Sleep(1000);

                    var loginInput = driver.FindElement(By.Name("login"));
                    loginInput.SendKeys("admin");
                    Assert.That(loginInput.GetAttribute("value"), Is.EqualTo("admin"), "Error, login input value is not correct.");
                    System.Threading.Thread.Sleep(1000);

                    var passwordInput = driver.FindElement(By.Name("pass"));
                    passwordInput.SendKeys("admin");
                    Assert.That(passwordInput.GetAttribute("value"), Is.EqualTo("admin"), "Error, password input value is not correct.");
                    System.Threading.Thread.Sleep(1000);

                    var logiSisseSubmitButton = driver.FindElement(By.CssSelector("input[type='submit']"));
                    logiSisseSubmitButton.Click();
                    Assert.That(driver.Title, Is.EqualTo("Tantsud tähtedega"), "Error, page title is not correct after login.");
                    System.Threading.Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error during the test " + ex.Message);
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during the test " + ex.Message);
                throw;
            }
        }


        [OneTimeTearDown]
        public void Teardown()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}
