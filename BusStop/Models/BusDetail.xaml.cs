using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BusStop.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BusDetail : ContentPage
    {
        public BusDetail()
        {
            InitializeComponent();
        }
    }
}