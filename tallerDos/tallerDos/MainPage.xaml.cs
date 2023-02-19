using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace tallerDos
{
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Flyout = new InteligenciaArtificial();
            this.Detail = new NavigationPage(new MachineLearning());
            App.FlyoutPage= this;

          




        }
    }
}
