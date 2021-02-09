using SqliteSample.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SqliteSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            GetDb();
        }

        private async Task GetDb()
        {
            var database = new SQLiteMethods(DependencyService.Get<ISQLiteDb>());
            await Task.Delay(1000);
            BindingContext = new MainViewModel(database);
        }
    }
}
