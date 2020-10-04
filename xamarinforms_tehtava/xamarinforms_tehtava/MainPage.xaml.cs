using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace xamarinforms_tehtava
{
    public partial class MainPage : ContentPage
    {
        IList<User> userList = new List<User>();
        int nLength;
        int aLenght;
        string name;
        string address;
        int age;
        public MainPage()
        {
            InitializeComponent();
            
        }

        async private void saveButton_Clicked(object sender, EventArgs e)
        {
            
            
            User user;
            
            try
            {
                nLength = nameEntry.Text.Length;
                aLenght = addressEntry.Text.Length;
                    
                    if ( nLength > 3 && aLenght > 3)
                    {
                        name = nameEntry.Text;
                        address = addressEntry.Text;
                        nameShow.Text = name;
                        ageShow.Text = age.ToString();
                        addShow.Text = addressEntry.Text;
                        user = new User(name, age, address);
                        userList.Add(user);
                    }
                
            }
            catch
            {
                await DisplayAlert("WARNING", "You have provided insufficient information", "Cancel");
            }
        }
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            age = (int)args.NewValue;
            sliderLabel.Text = String.Format("Ikä: {0} vuotta", age);
            

        }
        async private void addButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InfoPage(userList));
        }    
    }
}
