using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace ScrollViewBug
{
    public class MainPageViewModel
    {
        private static Random r = new Random();
        public ObservableCollection<string> Data { get; set; }

        public MainPageViewModel()
        {
            AddDataCommand = new Command(AddData);
            Data = new ObservableCollection<string>();
        }


        public ICommand AddDataCommand { get; set; }

        public void AddData()
        {
            Data.Add(r.Next(1000, 10000).ToString());
        }
    }
}