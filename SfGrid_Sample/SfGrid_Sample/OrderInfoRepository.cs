using Syncfusion.Data.Extensions;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfGrid_Sample
{
    public class ViewModel:NotificationObject
    {

        private ObservableCollection<OrderInfo> orderInfo;
        public ObservableCollection<OrderInfo> OrderInfoCollection
        {
            get { return orderInfo; }
            set { this.orderInfo = value; }
        }

        private int _selectedIndex;
        private object _selectedItem;
        private ObservableCollection<object> _selectedItems;
        private Command _buttonCommand;
        private double _cellTextSize;
        private List<String> _vehicleModel;
        private Columns _sampleColumn;
        private ObservableCollection<string> _customerNames;


        public int SelectedIndex
        {
            get { return _selectedIndex; }
            set { this._selectedIndex = value;RaisePropertyChanged("SelectedIndex"); }
        }

        public object SelectedItem
        {
            get { return _selectedItem; }
            set { this._selectedItem = value; RaisePropertyChanged("SelectedItem"); }
        }
        public ObservableCollection<object> SelectedItems
        {
            get { return _selectedItems; }
            set { this._selectedItems = value; RaisePropertyChanged("SelectedItems"); }
        }

        public Command ButtonCommand
        {
            get { return _buttonCommand; }
            set { this._buttonCommand = value;RaisePropertyChanged("ButtonCommand"); }
        }
        public double CellTextSize
        {
            get { return _cellTextSize; }
            set { this._cellTextSize = value; RaisePropertyChanged("CellTextSize"); }
        }
        public List<String> SelectedModels
        {
            get { return _vehicleModel; }
            set { this._vehicleModel = value;RaisePropertyChanged("SelectedCars"); }
        }

        public ObservableCollection<string> CustomerNames
        {
            get { return _customerNames; }
            set { this._customerNames = value; RaisePropertyChanged("CustomerNames"); }
        }
        public Columns SampleColumn
        {
            get { return sampleColumn; }
            //set { this._sampleColumn = value; RaisePropertyChanged("SampleColumn"); }
        }

        Columns sampleColumn = new Columns();

        public ViewModel()
        {
            orderInfo = new ObservableCollection<OrderInfo>();
            this.GenerateOrders();

            this.SelectedIndex = 5;
            this.SelectedItem = this.OrderInfoCollection[8];
            SelectedItems = new ObservableCollection<object>();
            this.SelectedItems.Add(OrderInfoCollection[1]);
            this.SelectedItems.Add(OrderInfoCollection[5]);
            this.SelectedItems.Add(OrderInfoCollection[8]);
            this.ButtonCommand = new Command(CustomMethod);
            this.CellTextSize = 20;
            this.SelectedModels = selectedModels.ToList();
            this.CustomerNames = customerNames.ToObservableCollection();
            
            
        }
        string [] selectedModels = { "Select Car", "Audi", "Bentley", "Mercedes Benz", "Porsche" };

        string[] customerNames = { "Thomas", "John", "Hanna", "Laura", "Gina" };


        void CustomMethod()
        {

        }
        private void GenerateOrders()
        {
            orderInfo.Add(new OrderInfo(1001, "Maria Anders", "Mexico", "ANATR", "Mexico D.F.",true));
            orderInfo.Add(new OrderInfo(1002, "Ana Trujillo", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1003, "Ant Fuller", "UK", "AROUT", "London", true));
            orderInfo.Add(new OrderInfo(1004, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true));
            orderInfo.Add(new OrderInfo(1005, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true));
            orderInfo.Add(new OrderInfo(1006, "John Carter", "France", "BLONP", "Strasbourg", true));
            orderInfo.Add(new OrderInfo(1007, "Laura King", "Spain", "BOLID", "Madrid", true));
            orderInfo.Add(new OrderInfo(1008, "Hanna Moos", "France", "BONAP", "Marseille", false));
            orderInfo.Add(new OrderInfo(1009, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false));
            orderInfo.Add(new OrderInfo(1010, "Hanna Moos", "UK", "AROUT", "London", false));
            orderInfo.Add(new OrderInfo(1011, "John Carter", "Germany", "BLAUS", "Mannheim", false));
            orderInfo.Add(new OrderInfo(1012, "Tim Adams", "France", "BLONP", "Strasbourg", true));
            orderInfo.Add(new OrderInfo(1013, "Hanna Moos", "UK", "AROUT", "London", false));
            orderInfo.Add(new OrderInfo(1014, "John Carter", "Germany", "ALFKI", "Berlin", true));
            orderInfo.Add(new OrderInfo(1015, "Hanna Moos", "Mexico", "ANATR", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1016, "Laura King", "Mexico", "ANTON", "Mexico D.F.", false));
            orderInfo.Add(new OrderInfo(1017, "Lenny Lin", "UK", "AROUT", "London", false));
            orderInfo.Add(new OrderInfo(1018, "Thomas Hardy", "Sweden", "BERGS", "Berlin", true));
            orderInfo.Add(new OrderInfo(1019, "Lenny Lin", "Germany", "BLAUS", "Mannheim", true));
            orderInfo.Add(new OrderInfo(1020, "Gina Irene", "France", "BLONP", "Strasbourg", true));
            orderInfo.Add(new OrderInfo(1021, "Laura King", "Spain", "BOLID", "Madrid", false));
            orderInfo.Add(new OrderInfo(1022, "Anne Wilson", "France", "BONAP", "Marseille", true));
            orderInfo.Add(new OrderInfo(1023, "Lenny Lin", "Canada", "BOTTM", "Tsawassen", false));
            orderInfo.Add(new OrderInfo(1024, "Gina Irene", "UK", "AROUT", "London", true));
            orderInfo.Add(new OrderInfo(1025, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", true));
            orderInfo.Add(new OrderInfo(1026, "Anne Wilson", "France", "BLONP", "Strasbourg", false));
            orderInfo.Add(new OrderInfo(1027, "Laura King", "UK", "AROUT", "London", true));
            orderInfo.Add(new OrderInfo(1028, "Anne Wilson", "France", "BLONP", "Strasbourg", true));
            orderInfo.Add(new OrderInfo(1029, "Gina Irene", "UK", "AROUT", "London", false));
            orderInfo.Add(new OrderInfo(1030, "Anne Wilson", "Germany", "ALFKI", "Berlin", false));
            orderInfo.Add(new OrderInfo(1031, "Tim Adams", "Mexico", "ANATR", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1032, "Anne Wilson", "Mexico", "ANTON", "Mexico D.F.", true));
            orderInfo.Add(new OrderInfo(1033, "Gina Irene", "UK", "AROUT", "London", false));
            orderInfo.Add(new OrderInfo(1034, "Ant Fuller", "Sweden", "BERGS", "Berlin", true));
            orderInfo.Add(new OrderInfo(1035, "Thomas Hardy", "Germany", "BLAUS", "Mannheim", false));
            orderInfo.Add(new OrderInfo(1036, "Gina Irene", "France", "BLONP", "Strasbourg", true));
            orderInfo.Add(new OrderInfo(1037, "Hanna Moos", "Spain", "BOLID", "Madrid", false));
            orderInfo.Add(new OrderInfo(1038, "Anne Wilson", "France", "BONAP", "Marseille", false));
            orderInfo.Add(new OrderInfo(1039, "Thomas Hardy", "Canada", "BOTTM", "Tsawassen", true));
            orderInfo.Add(new OrderInfo(1040, "Tim Adams", "UK", "AROUT", "London", true));
            orderInfo.Add(new OrderInfo(1041, "Anne Wilson", "Germany", "BLAUS", "Mannheim", true));
            orderInfo.Add(new OrderInfo(1042, "Thomas Hardy", "France", "BLONP", "Strasbourg", false));
            orderInfo.Add(new OrderInfo(1043, "Hanna Moos", "UK", "AROUT", "London", true));
            orderInfo.Add(new OrderInfo(1044, "John Carter", "Germany", "ALFKI", "Berlin", false));
        }
    }

    public class NotificationObject : INotifyPropertyChanged
    {
        public void RaisePropertyChanged(string propName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
