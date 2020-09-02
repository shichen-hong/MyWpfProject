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
using System.Diagnostics;
using myData_ns;

namespace MyWpfProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        myData mylist;
        Boolean doClear;
        public MainWindow()
        {
            this.mylist = new myData();
            InitializeComponent();
            
        }
        private void Clear_Button_Click(object sender, RoutedEventArgs e)
        {
            doClear = true;
            this.mylist.uri = "";
            bt_Start.IsEnabled = false;
            MessageBox.Show("Let's start over. Please choose group, series and type");
            lb_Group.IsEnabled = true;
            lb_Series.IsEnabled = true;
            lb_Type.IsEnabled = true;
            lb_Group.UnselectAll();
            lb_Series.UnselectAll();
            lb_Type.UnselectAll();
            doClear = false;
        }

        private void Start_Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.mylist.uri == null){
                MessageBox.Show("Please choose group, series and type");
            }
            else
            {
                Process.Start(new ProcessStartInfo(this.mylist.uri){UseShellExecute = true});
            }
        }
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri){UseShellExecute = true});
            e.Handled = true;
        }

        private void getLbGroup(object sender, SelectionChangedEventArgs e)
        {
            if(doClear){
                return;
            }
            var item = (ListBox)sender;
            item.IsEnabled = false;
            string group = (string)item.SelectedItem.ToString();
            switch (group)
            {
                case "System.Windows.Controls.ListBoxItem: High Performance":
                    group = "High";
                    break;
                case "System.Windows.Controls.ListBoxItem: Mainstream":
                    group = "Main";
                    break;
                case "System.Windows.Controls.ListBoxItem: Ultra Low Power":
                    group = "Ultra";
                    break;

            }
            this.mylist.updateGroup(group);
            lb_Series.Items.Clear();
            foreach (string n in this.mylist.series_list)
            {
                lb_Series.Items.Add(n);
            }
            bt_Clear.IsEnabled = true;
        }
        private void getLbSeries(object sender, SelectionChangedEventArgs e) {
            if(doClear){
                return;
            }
            var item = (ListBox)sender;
            item.IsEnabled = false;
            this.mylist.series = (string)item.SelectedItem.ToString();
            this.mylist.updateSeries();
            this.mylist.getSeriesUrl();
            bt_Start.IsEnabled = true;
            lb_Type.Items.Clear();
            foreach (string n in this.mylist.type_list)
            {
                lb_Type.Items.Add(n);
            }
            bt_Clear.IsEnabled = true;
        }
        private void getLbType(object sender, SelectionChangedEventArgs e) {
            if(doClear){
                return;
            }
            var item = (ListBox)sender;
            item.IsEnabled = false;
            this.mylist.type = (string)item.SelectedItem.ToString();
            this.mylist.getTypeUrl();
            if(!bt_Start.IsEnabled)
            {
                bt_Start.IsEnabled = true;
            }
            bt_Clear.IsEnabled = true;
        }
    }

}
