using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
using Ninject;

namespace DecanatPRO
{
    internal static class Program
    {
        private static readonly IKernel NinjectKernel = new StandardKernel(new SimpleConfigModule());

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Logic logic = NinjectKernel.Get<Logic>();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FromMain(logic));
        }
    }
}
