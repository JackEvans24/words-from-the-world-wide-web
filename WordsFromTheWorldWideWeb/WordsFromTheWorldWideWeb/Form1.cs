using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace WordsFromTheWorldWideWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> randomWords = new List<string>();
        List<string> searchTerms = new List<string>();

        public bool isRunning = false;
        private async void StartStopButton_Click(object sender, EventArgs e)
        {
            if (!isRunning)
            {
                isRunning = true;
                StartStopButton.Text = "Stop";

                await Task.Run(() =>
                {
                    while (isRunning)
                    {
                        string randomWord = GetWord();

                        if (randomWord.Length > 0)
                        {
                            UpdateTextbox(randomWord);
                            UpdateLabel();
                        }
                    }

                    UpdateButtonText();
                });
            }
            else
            {
                isRunning = false;
                StartStopButton.Text = "Stopping...";
            }
        }
        
        private string GetWord()
        {
            Random rnd = new Random();

            IWebDriver driver = new ChromeDriver();
            string searchString = RandomWord.Get();

            driver.Url = "http://www.google.co.uk";

            driver.FindElement(By.Name("q")).SendKeys(searchString + OpenQA.Selenium.Keys.Return);

            /*
            try
            {
                IList<IWebElement> h3Links = driver.FindElements(By.TagName("h3"));

                h3Links[2].FindElement(By.TagName("a")).Click();
            }
            catch (InvalidOperationException)
            {
                driver.Quit();
                return "";
            }
            catch (NoSuchElementException)
            {
                driver.Quit();
                return "";
            }
            */

            List<IWebElement> spans = new List<IWebElement>();
            IWebElement bigSpan;
            try
            {
                spans = driver.FindElements(By.ClassName("st")).OrderByDescending(p => p.Text.Length).ToList();
                switch (rnd.Next(1, 6))
                {
                    default:
                        bigSpan = spans[0];
                        break;
                    case 2:
                        bigSpan = spans[1];
                        break;
                    case 3:
                        bigSpan = spans[2];
                        break;
                    case 4:
                        bigSpan = spans[3];
                        break;
                    case 5:
                        bigSpan = spans[4];
                        break;
                }
            }
            catch (IndexOutOfRangeException)
            {
                driver.Quit();
                return "";
            }
            catch (NoSuchElementException)
            {
                driver.Quit();
                return "";
            }

            char[] space = { ' ', '\r', '\n', '\t', '.', ',', '"', '\'', '(', ')', '/', '\\', '|', '<', '>' , '^', '&', '*', ':', ';', '@', '#', '~', '•'};
            string[] allWords = bigSpan.Text.Split(space, StringSplitOptions.RemoveEmptyEntries);

            string randomWord = String.Empty;
            if (allWords.Length > 1)
                randomWord = allWords[rnd.Next(0, allWords.Length - 1)].ToLowerInvariant();

            if (!searchTerms.Contains(searchString))
                searchTerms.Add(searchString);

            if (!randomWords.Contains(randomWord))
                randomWords.Add(randomWord);

            driver.Quit();
            return randomWord;
        }

        public void UpdateTextbox(string text)
        {
            BeginInvoke((MethodInvoker)delegate 
                { DisplayTextbox.AppendText(text + " ");
                    DisplayTextbox.Refresh();
                    DisplayTextbox.Parent.Refresh();
                });
        }

        public void UpdateLabel()
        {
            BeginInvoke((MethodInvoker)delegate 
                {   WordInfoLabel.Text = String.Format("Pulled {0} unique words", randomWords.Count);
                    TermInfoLabel.Text = String.Format("using {0} different search terms", searchTerms.Count);
                    DisplayTextbox.Refresh();
                    DisplayTextbox.Parent.Refresh();
                });
        }

        public void UpdateButtonText()
        {
            BeginInvoke((MethodInvoker)delegate
            {
                StartStopButton.Text = "Start";
                StartStopButton.Refresh();
                DisplayTextbox.Parent.Refresh();
            });

        }
    }
}
