using DiyetTakip_UI.AdminGirisi;
using DiyetTakip_UI.KullaniciIslemleri;

namespace DiyetTakip_UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new KaloriTakipcisi());
            //Application.Run(new AdminGiris());
            Application.Run(new AcilisEkrani());

        }
    }
}