using SQLite;
using SqliteSample.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace SqliteSample.Models
{
    public class Todo: PropertyChangedHandler
    {
        private int _id;
        private string _title;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get => _id;
            set
            {
                _id = value;
                OnPropertyChanged();
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
            }
        }
    }
}
