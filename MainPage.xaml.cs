using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Projmvvm_FlowerOnline
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void cmdThemloai_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.PageInsertLoaihoa());
        }

        private void cmdThemHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.PageThemHoa());
        }

        private void cmdDSHoa_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Views.PageHoa());
        }
    }
}
