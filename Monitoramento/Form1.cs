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
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System.Diagnostics;
using System.Runtime.InteropServices;
//using System.ComponentModel;
//using System.Diagnostics.Process.Start(url);

namespace Monitoramento
{
    public partial class Form1 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form1()
        {
            InitializeComponent();
        }

        /*
        // Inicio Função IE
        public void OpenApplication(string myFavoritesPath)
        {
            // Start Internet Explorer. Defaults to the home page.
            Process.Start("IExplore.exe");

            // Display the contents of the favorites folder in the browser.
            Process.Start(myFavoritesPath);

        }

        public void OpenWithArguments()
        {
            // url's are not considered documents. They can only be opened
            // by passing them as arguments.
            Process.Start("IExplore.exe", "https://nettv.mfmti.com.br/lang_portbr/");

            // Start a Web page using a browser associated with .html and .asp files.
            Process.Start("IExplore.exe", "C:\\myPath\\myFile.htm");
            Process.Start("IExplore.exe", "C:\\myPath\\myFile.asp");
        }
        //Fim Função IE
        */


        private void LblFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LblMonitorar_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PbxMonit_Click(object sender, EventArgs e)
        {
            IWebDriver driver = new InternetExplorerDriver(@"F:\C#\Monitoramento");
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://nettv.mfmti.com.br/lang_portbr/logon.asp?frame=true");

            //Tentar com o XPath, tendo em vista que parece ser a opção que dará resultado paraa busca do campo de digitação, fé
            driver.FindElement(By.XPath("/")).SendKeys("sj");

            //driver.FindElement(By.ClassName("passwd")).SendKeys("SHOW");
            //driver.FindElement(By.Id("entrar")).Click();

            /*Monitoramento m = new Monitoramento();
            m.Show();*/


        }
    }
}
