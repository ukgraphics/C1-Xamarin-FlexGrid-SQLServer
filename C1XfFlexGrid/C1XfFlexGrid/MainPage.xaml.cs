using EFCoreClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace C1XfFlexGrid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var db = new grapecitytestdbContext();

            flexgrid.ItemsSource = db.Customer.ToList();
        }
    }
}
