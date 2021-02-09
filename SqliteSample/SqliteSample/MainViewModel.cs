using SqliteSample.Database;
using SqliteSample.Models;
using SqliteSample.Util;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SqliteSample
{
    public class MainViewModel: PropertyChangedHandler
    {
        public ICommand SaveCommand { get; set; }
        private readonly ISQLiteMethods _sqlite;
        public MainViewModel(ISQLiteMethods sqlite)
        {
            _sqlite = sqlite;
            LoadItems();
            SaveCommand = new Command(async () => await AddItems());
            Items = new ObservableCollection<Todo>();
        }

        private async void LoadItems()
        {

            var items = await _sqlite.GetTodoAsync();
            Console.WriteLine(items);
            foreach(var item in items)
            {
                Items.Add(item);
            }
        }
        private async Task AddItems()
        {
            var item = new Todo
            {
                Title = EntryText
            };
            await _sqlite.AddTodo(item);
            Items.Add(item);
        }

        private string _entryText;
        public string EntryText
        {
            get => _entryText;
            set 
            {
                _entryText = value;
                OnPropertyChanged(); 
            }
        }

        private ObservableCollection<Todo> _items;
        public ObservableCollection<Todo> Items
        {
            get => _items;
            set { _items = value; }
        }
    }
}
