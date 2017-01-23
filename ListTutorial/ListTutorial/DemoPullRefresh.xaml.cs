using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListTutorial
{
    public partial class DemoPullRefresh : ContentPage
    {
        private ObservableCollection<Contact> _contact;
        public DemoPullRefresh()
        {
            InitializeComponent();


            _contact = new ObservableCollection<Contact>
            {
                new Contact {Name = "Reyan" , Status = "Road to 4k MMR" },
                new Contact {Name = "Bob" , Status = "Road to 2k MMR" }
            };
            listView.IsPullToRefreshEnabled = true;
            listView.ItemsSource = GetContacts();

            
        }


        void Handle_Refreshing(object sender , EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            listView.EndRefresh();
        }


        ObservableCollection<Contact> GetContacts()
        {
           return new ObservableCollection<Contact>
           {
                new Contact { Name = "Reyan", Status = "Road to 4k MMR" },
                new Contact { Name = "Bob", Status = "Road to 2k MMR" }
           };
        }
    }
}
