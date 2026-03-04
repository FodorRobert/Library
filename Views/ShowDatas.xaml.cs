using LibraryGUI.Datas;
using LibraryGUI.Models;
using System.Collections;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


namespace LibraryGUI.Views
{
    /// <summary>
    /// Interaction logic for ShowDatas.xaml
    /// </summary>
    public partial class ShowDatas : Page
    {
        public ShowDatas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Public accessor to allow other classes to set/get the DataGrid's ItemsSource
        /// without exposing the DataGrid control itself.
        /// </summary>
        public object ItemsSource
        {
            get { return dataGrid1.ItemsSource; }
            set { dataGrid1.ItemsSource = (IEnumerable)value; }
        }

        private void dataGrid1_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.PropertyType.IsClass && e.PropertyType != typeof(string))
            {
                e.Cancel = true;
            }
        }
    }
}
