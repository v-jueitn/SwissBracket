using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwissBracket
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetGridColumns();
        }

        public class ItemClass
        {
            public string Team_Name { get; set;}
            public string Captain_Name { get; set; }
            public string Number { get; set; }
        }

        private void SetGridColumns() {
            List<ItemClass> items = new List<ItemClass>();
            for (int x = 0; x < 20; x++)
            {
                items.Add(new ItemClass());
            }
            teams.ItemsSource = items;
        }

        private void HideLastColumn(DataGrid dg) {
            if (dg == null)
                return;

            foreach (DataGridColumn col in dg.Columns) {
                if (col.Header.ToString() == "Team_Name")
                    col.Width = 235;
                if (col.Header.ToString() == "Captain_Name")
                    col.Width = 230;
                if (col.Header.ToString() == "Number")
                    col.Width = 110;
            } 
            
        
        }


        private void registration_Click(object sender, RoutedEventArgs e) {
            HideLastColumn(teams); 
        }

        private void rdNo_Checked(object sender, RoutedEventArgs e) {
            btnDetails.Visibility = System.Windows.Visibility.Hidden; 
        }

        private void rdNo_UnChecked(object sender, RoutedEventArgs e)
        {
            btnDetails.Visibility = System.Windows.Visibility.Visible;
        }

        private void btnDetails_Click(object sender, RoutedEventArgs e)
        {
            ChampBracketDetail ChampBracket = new ChampBracketDetail();
            App.Current.MainWindow = ChampBracket;
            ChampBracket.Show();
        }

    }
}
