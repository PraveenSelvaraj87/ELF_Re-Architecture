using ELF;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Earlens.ELF.BootStrapper
{
    public class EarlensBootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return ServiceLocator.Current.GetInstance<ELFUI>();
         //   ELFUI ElfAPP = new  ELFUI();
           // Shell = ElfAPP;            
           // return Shell;// base.CreateShell();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow = new ELFUI(); 
            Application.Current.MainWindow.Show();
        }
    }
}
