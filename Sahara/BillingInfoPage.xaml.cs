using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

            FetchBilling();
		}

        public async void saveBillingInformationButton_Clicked(object sender, EventArgs e)
        {
            var BillStuff = new BillingModel
            {
                Address1 = addressLine1Entry.Text,
                Address2 = addressLine2Entry.Text,
                City = cityEntry.Text,
                State = stateEntry.Text,
                Zip = zipEntry.Text,
            };

            await App.Database.SaveBillingAsync(BillStuff);

            var billing = await App.Database.GetBilling();

            var billingList = new ObservableCollection<BillingModel>();
            billing.ForEach(x => billingList.Add(x));

            BillingListView.ItemsSource = billingList;
        }

        public async void FetchBilling()
        {
            var billing = await App.Database.GetBilling();

            var billingList = new ObservableCollection<BillingModel>();
            billing.ForEach(x => billingList.Add(x));

            BillingListView.ItemsSource = billingList;
        }
	}
}