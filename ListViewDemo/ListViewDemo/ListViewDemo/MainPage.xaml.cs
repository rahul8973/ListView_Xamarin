using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public List<DataModel> contactDetails;
        public MainPage()
        {
            InitializeComponent();
            PopulateDetails();
            listView.ItemsSource = contactDetails;
        }

        private void PopulateDetails()
        {
            if (contactDetails == null)
            {
                contactDetails = new List<DataModel>();
                contactDetails.Add(new DataModel() { Name = "Anderson", PhoneNumber = "Martin" });
                contactDetails.Add(new DataModel() { Name = "Adam", PhoneNumber = "Dev" });
                contactDetails.Add(new DataModel() { Name = "Bob", PhoneNumber = "Harry"});
                contactDetails.Add(new DataModel() { Name = "Brooke", PhoneNumber = "Clancy" });
                contactDetails.Add(new DataModel() { Name = "Bella", PhoneNumber = "Jo" });
                contactDetails.Add(new DataModel() { Name = "Charlie", PhoneNumber = "James" });
                contactDetails.Add(new DataModel() { Name = "Carla", PhoneNumber = "Buckner" });
                contactDetails.Add(new DataModel() { Name = "Dev", PhoneNumber = "Anand" });
                contactDetails.Add(new DataModel() { Name = "Fried", PhoneNumber = "Hardy" });
                contactDetails.Add(new DataModel() { Name = "Harry", PhoneNumber = "Jacob" });
                contactDetails.Add(new DataModel() { Name = "Hannah", PhoneNumber = "Icaza" });
                contactDetails.Add(new DataModel() { Name = "Michael", PhoneNumber = "Nikon" });
                contactDetails.Add(new DataModel() { Name = "Maria", PhoneNumber = "Shara"});

            }
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
