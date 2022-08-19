using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF_Destroyer.ViewModel
{
    internal class SettingsViewModel: ViewModelBase
    {
        public string SiteURL { get; set; }

        public ICommand AddSiteUrl
        {
            get
            {
                return new RelayCommand(() =>
                   {
                       Properties.Settings.Default.site_URL.Add(SiteURL);
                       Properties.Settings.Default.Save();
                   }
                ) ;
            }
        }
    }
}
