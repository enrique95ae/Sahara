using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sahara
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class billingInfoPage : ContentPage
	{
		public billingInfoPage ()
		{
			InitializeComponent ();
		}

        private async void saveBillingInformationButton_Clicked(object sender, EventArgs e)
        {

        }
	}
}