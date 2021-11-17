using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MissingMethodExceptionSample.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string payLoadValue;
        private string retrievedValue;

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
            StoreValueCommand = new Command(StoreValue);
            StoreValueCommand = new Command(GetValue);
        }

        public ICommand OpenWebCommand { get; }
        public ICommand StoreValueCommand { get; }
        public ICommand GetValueCommand { get; }

        public string PayLoadValue
        {
            get => payLoadValue;
            set => SetProperty(ref payLoadValue, value);
        }

        public string RetrievedValue 
        { 
            get => retrievedValue; 
            set => SetProperty(ref retrievedValue, value);
        }

        private async void StoreValue(object obj)
        {
            var storage = new StorageService();

            var payload = new StorePayLoad()
            {
                Value = PayLoadValue
            };

            // THIS THROWS THE MISSING METHOD EXCEPTION
            await storage.SetAsync("key", payload);
        }

        private async void GetValue(object obj)
        {
            var storage = new StorageService();

            var storedPayload = await storage.GetAsync<StorePayLoad>("key");

            RetrievedValue = storedPayload.Value;
        }
    }

    public class StorePayLoad
    {
        public string Value { get; set; }
    }
}