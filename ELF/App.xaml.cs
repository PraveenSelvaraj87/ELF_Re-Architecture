using Earlens.ELF.BootStrapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ELF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            EarlensBootStrapper bootStrapper = new EarlensBootStrapper();
            bootStrapper.Run();

            base.OnStartup(e);
        }
    }
}
