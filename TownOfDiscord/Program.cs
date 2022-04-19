using System;
using System.Windows.Forms;
using TownOfDiscord.Discord;

namespace TownOfDiscord
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //var bot = new Bot();
            //bot.StartAsync().GetAwaiter().GetResult();
            Application.Run(new FormParent());
        }
    }
}