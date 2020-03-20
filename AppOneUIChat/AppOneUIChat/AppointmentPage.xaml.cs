
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppOneUIChat
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AppointmentPage : ContentPage
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void BtnComfirm_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ComfirmPage());
        }
    }
}