using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusStop.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusFlyout : ContentPage
    {
        public ListView ListView;

        public BusFlyout()
        {
            InitializeComponent();

            BindingContext = new BusFlyoutViewModel();
            ListView = MenuItemsListView;
        }

        private class BusFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<BusFlyoutMenuItem> MenuItems { get; set; }

            public BusFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<BusFlyoutMenuItem>(new[]
                {
                    new BusFlyoutMenuItem { Id = 0, Title = "Page 1" },
                    new BusFlyoutMenuItem { Id = 1, Title = "Page 2" },
                    new BusFlyoutMenuItem { Id = 2, Title = "Page 3" },
                    new BusFlyoutMenuItem { Id = 3, Title = "Page 4" },
                    new BusFlyoutMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}