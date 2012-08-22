using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace UnitConverter
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void convertTypeListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBoxItem selectedItem = (ListBoxItem) convertTypeListBox.SelectedItem;
            String convertType = selectedItem.Content.ToString();
            String convertPageUrlWData = string.Format("/ConvertPage.xaml?convertType={0}", convertType);

            NavigationService.Navigate(new Uri(convertPageUrlWData, UriKind.Relative));
        }
    }
}