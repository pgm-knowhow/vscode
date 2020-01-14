using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

    public class MainViewModel
    {
        public static ObservableCollection<string> ComboBox1 { get; private set; }
        public static Dictionary<int, string> ComboBox2 { get; private set; }
        public ObservableCollection<Row> DataGrid1 { get; private set; }

        public MainViewModel()
        {
            MainViewModel.ComboBox1 = new ObservableCollection<string>()        
            {
                "Item.1", "Item.2", "Item.3"
            };

            this.DataGrid1 = new ObservableCollection<Row>();
            for( int i = 1; i < 100; i++ )
            {
                this.DataGrid1.Add( new Row() { LabelColumn = i } );
            }
        }      
    }

    public class Row 
    {
        public int LabelColumn { get; set; }
        public string TextBlockColumn { get; set; }
        public string TextBoxColumn { get; set; }
        public bool CheckBoxColumn { get; set; }
        public string ComboBoxColumn { get; set; }

        public Row()
        {
            this.LabelColumn = 0;
            this.TextBlockColumn = "TextBlock";
            this.TextBoxColumn = "TextBox";
            this.CheckBoxColumn = false;
            this.ComboBoxColumn = MainViewModel.ComboBox1.FirstOrDefault();
        }
    } 
