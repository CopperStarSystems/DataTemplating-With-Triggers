//  --------------------------------------------------------------------------------------
// DataTemplatingWithTriggers.MainViewModel.cs
// 2017/07/31
//  --------------------------------------------------------------------------------------

using System.Collections.ObjectModel;
using System.ComponentModel;

namespace DataTemplatingWithTriggers.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        ListItemViewModel selectedListItem;

        public MainViewModel()
        {
            ListItems = new ObservableCollection<ListItemViewModel>();
            CreateListItems();
        }

        void CreateListItems()
        {
            ListItems.Add(new ListItemViewModel("Item 1"));
            ListItems.Add(new ListItemViewModel("Item 2"));
            ListItems.Add(new ListItemViewModel("Item 3"));
        }

        public ListItemViewModel SelectedListItem
        {
            get => selectedListItem;
            set
            {
                selectedListItem = value;
                OnPropertyChanged(nameof(SelectedListItem));
            }
        }

        public ObservableCollection<ListItemViewModel> ListItems { get; }

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}