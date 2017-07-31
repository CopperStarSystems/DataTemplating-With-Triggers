//  --------------------------------------------------------------------------------------
// DataTemplatingWithTriggers.ListItemViewModel.cs
// 2017/07/31
//  --------------------------------------------------------------------------------------

using System.ComponentModel;

namespace DataTemplatingWithTriggers.ViewModel
{
    public class ListItemViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ListItemViewModel(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}