using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ListTutorial
{
    public partial class demo : ContentPage
    {
        private ObservableCollection<Contact> _contact;
        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
        }

        void Handle_Refreshing(object sneder, EventArgs e)
        {

        }



        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");

        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = ((MenuItem)sender).CommandParameter as Contact;

            _contact.Remove(contact);
            
            
        }
        public demo()
        {
            InitializeComponent();

         
            _contact = new ObservableCollection<Contact>
            {
                
                     new Contact { Name = "Mosh" , ImageUrl = "http://lorempixel.com/100/100/people/1" },
                
               
                    new Contact { Name = "John" , ImageUrl = "http://lorempixel.com/100/100/people/12" , Status = "Let's Talk"}
                
               
                

            };


            listView.ItemsSource = _contact;
        }
    }
}
