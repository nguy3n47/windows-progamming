using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace BTLT08
{
    public class Phone : INotifyPropertyChanged
    {
        // Properties
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Manufacturer { get; set; }
        public string Prices { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}