using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tallerDos
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InteligenciaArtificial : ContentPage
    {
        public InteligenciaArtificial()
        {
            InitializeComponent();
        }
        private void ButtonMachineLearning (object sender, EventArgs e)
        {
            App.FlyoutPage.IsPresented= false;
            App.FlyoutPage.Detail.Navigation.PushAsync(new MachineLearning());
        }
        private void ButtonDeepLearning(object sender, EventArgs e )
        {
            App.FlyoutPage.IsPresented = false;
            App.FlyoutPage.Detail.Navigation.PushAsync(new DeepLearning());
        }
        private void ButtonArtificialVision (object sender, EventArgs e)

        {
            App.FlyoutPage.IsPresented = false;
            App.FlyoutPage.Detail.Navigation.PushAsync(new VisionArtificial());
        }
    }
}