using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using FirstApp.Annotations;
using FirstApp.Interfaces;
using FirstApp.Models;
using Xamarin.Forms;

namespace FirstApp.ViewModels
{
    public class FriendViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private FriendsListViewModel lvm;

        //public ICommand LoadImageCommand { protected set; get; }

        public Friend Friend { get; set; }

        public FriendViewModel()
        {
            Friend = new Friend();
            //LoadImageCommand = new Command(LoadImage);
        }

        //private async void LoadImage(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    button.IsEnabled = false;
        //    Stream stream = await DependencyService.Get<IPicturePicker>().GetImageStreamAsync();

        //    if (stream != null)
        //    {
        //        Image image = new Image
        //        {
        //            Source = ImageSource.FromStream(() => stream),
        //            BackgroundColor = Color.Gray
        //        };

        //        LogoOrg.Source = image.Source;
        //        LogoOrg.HeightRequest = 100;
        //        LogoOrg.WidthRequest = 100;
        //        button.IsVisible = false;
        //    }
        //    else
        //    {
        //        button.IsEnabled = true;

        //    }
        //}

        public FriendsListViewModel ListViewModel
        {
            get { return lvm; }
            set
            {
                if (lvm != value)
                {
                    lvm = value;
                    OnPropertyChanged("ListViewModel");
                }
            }
        }

        public string Name
        {
            get { return Friend.Name; }
            set
            {
                if (Friend.Name != value)
                {
                    Friend.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }

        public string Email
        {
            get { return Friend.Email; }
            set
            {
                if (Friend.Email != value)
                {
                    Friend.Email = value;
                    OnPropertyChanged("Email");
                }
            }
        }
        public string Phone
        {
            get { return Friend.Phone; }
            set
            {
                if (Friend.Phone != value)
                {
                    Friend.Phone = value;
                    OnPropertyChanged("Phone");
                }
            }
        }

        public string Image
        {
            get { return Friend.Image; }
            set
            {
                if (Friend.Image != value)
                {
                    Friend.Image = value;
                    OnPropertyChanged("Image");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return ((!string.IsNullOrEmpty(Name.Trim())) ||
                        (!string.IsNullOrEmpty(Phone.Trim())) ||
                        (!string.IsNullOrEmpty(Email.Trim())));
            }
        }
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        }
    }
}
