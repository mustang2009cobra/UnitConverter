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
    public class ConvertConstants
    {
        public const String AREA = "area";
        public const String VOLUME = "volume";
        public const String MASS = "mass";
        public const String LENGTH = "length";
        public const String TEMP = "temperature";
        public const String TIME = "time";
        public const String AREA_SQ_CENT = "Square Centimers";
        public const String AREA_SQ_FEET = "Square Feet";
        public const String AREA_SQ_INCH = "Square Inches";
        public const String AREA_SQ_METER = "Square Meters";
        public const String VOLUME_GALLON = "Gallons";
        public const String VOLUME_LITER = "Liters";
        public const String VOLUME_QUART = "Quarts";
        public const String MASS_KILOGRAM = "Kilograms";
        public const String MASS_GRAM = "Grams";
        public const String MASS_OUNCE = "Ounces";
        public const String TIME_DAYS = "Days";
        public const String TIME_SECONDS = "Seconds";
        public const String TIME_YEARS = "Years";
        public const String TEMP_FAREN = "Farenheit";
        public const String TEMP_CELSIUS = "Celsius";
        public const String TEMP_KELVIN = "Kelvin";
    }

    public partial class ConvertPage : PhoneApplicationPage
    {
        bool newPageInstance = false;

        public ConvertPage()
        {
            InitializeComponent();
            newPageInstance = true;
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string convertType;
            NavigationContext.QueryString.TryGetValue("convertType", out convertType);
            PageTitle.Text = convertType.ToLower();

            this.setConvertTypeLists(PageTitle.Text);

            if (State.ContainsKey("textbox") && newPageInstance == false)
            {
                valueTextBox.Text = (string)State["textbox"];
            }
            if (State.ContainsKey("fromSelectedItem") && newPageInstance == false)
            {
                int fromSelItem = (int)State["fromSelectedItem"];
                convertFromListBox.SelectedIndex = fromSelItem;
            }
            if (State.ContainsKey("toSelectedItem") && newPageInstance == false)
            {
                int toSelItem = (int)State["toSelectedItem"];
                convertToListBox.SelectedIndex = toSelItem;
            }
            base.OnNavigatedTo(e);
        }

        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            if (convertFromListBox.SelectedItem == null && convertToListBox.SelectedItem == null)
            {
                MessageBox.Show("Choose Convert From and Convert To types");
                return;
            }
            if (convertToListBox.SelectedItem == null)
            {
                MessageBox.Show("Choose a Convert To type");
                return;
            }
            if (convertFromListBox.SelectedItem == null)
            {
                MessageBox.Show("Choose a Convert From type");
                return;
            }

            ListBoxItem fromType = (ListBoxItem) convertFromListBox.SelectedItem;
            ListBoxItem toType = (ListBoxItem) convertToListBox.SelectedItem;
            String strFromType = fromType.Content.ToString();
            String strToType = toType.Content.ToString();
            String strValue = valueTextBox.Text;

            double value = -1;
            try
            {
                value = Double.Parse(strValue);
            }
            catch (FormatException exn)
            {
                MessageBox.Show("Enter a number value to convert");
                return;
            }

            Units unitConvert = new Time();
            double result = -1;
            switch (PageTitle.Text)
            {
                case ConvertConstants.AREA:
                    unitConvert = new Area();
                    break;
                case ConvertConstants.TIME:
                    unitConvert = new Time();
                    break;
                case ConvertConstants.TEMP:
                    unitConvert = new Temperature(); 
                    break;
            }
            result = unitConvert.Convert(strFromType, strToType, value);
            valueTextBox.Text = result.ToString();
        }

        private void setConvertTypeLists(String convertType)
        {
            switch (convertType)
            {
                case "area":
                    this.setConvertListsToArea();
                    break;
                case "mass":
                    this.setConvertListsToMass();
                    break;
                case "length":
                    this.setConvertListsToLength();
                    break;
                case "temperature":
                    this.setConvertListsToTemperature();
                    break;
                case "volume":
                    this.setConvertListsToVolume();
                    break;
                case "time":
                    this.setConvertListsToTime();
                    break;
            }
        }

        private void setConvertListsToArea()
        {
            //Set ConvertFrom and ConvertTo lists
            convertFromListBox.Items.Clear();
            convertToListBox.Items.Clear();
            ListBoxItem sq_cent = new ListBoxItem();
            sq_cent.Content = ConvertConstants.AREA_SQ_CENT;
            convertFromListBox.Items.Add(sq_cent);
            ListBoxItem sq_centTo = new ListBoxItem();
            sq_centTo.Content = ConvertConstants.AREA_SQ_CENT;
            convertToListBox.Items.Add(sq_centTo);
            ListBoxItem sq_feet = new ListBoxItem();
            sq_feet.Content = ConvertConstants.AREA_SQ_FEET;
            convertFromListBox.Items.Add(sq_feet);
            ListBoxItem sq_feetTo = new ListBoxItem();
            sq_feetTo.Content = ConvertConstants.AREA_SQ_FEET;
            convertToListBox.Items.Add(sq_feetTo);
            ListBoxItem sq_inch = new ListBoxItem();
            sq_inch.Content = ConvertConstants.AREA_SQ_INCH;
            convertFromListBox.Items.Add(sq_inch);
            ListBoxItem sq_inchTo = new ListBoxItem();
            sq_inchTo.Content = ConvertConstants.AREA_SQ_INCH;
            convertToListBox.Items.Add(sq_inchTo);
            ListBoxItem sq_meters = new ListBoxItem();
            sq_meters.Content = ConvertConstants.AREA_SQ_METER;
            convertFromListBox.Items.Add(sq_meters);
            ListBoxItem sq_metersTo = new ListBoxItem();
            sq_metersTo.Content = ConvertConstants.AREA_SQ_METER;
            convertToListBox.Items.Add(sq_metersTo);
        }

        private void setConvertListsToMass()
        {
            throw new NotImplementedException();
        }

        private void setConvertListsToLength()
        {
            throw new NotImplementedException();
        }

        private void setConvertListsToTemperature()
        {
            convertFromListBox.Items.Clear();
            convertToListBox.Items.Clear();
            ListBoxItem farenheitFrom = new ListBoxItem();
            farenheitFrom.Content = ConvertConstants.TEMP_FAREN;
            convertFromListBox.Items.Add(farenheitFrom);
            ListBoxItem farenheitTo = new ListBoxItem();
            farenheitTo.Content = ConvertConstants.TEMP_FAREN;
            convertToListBox.Items.Add(farenheitTo);

            ListBoxItem kelvinFrom = new ListBoxItem();
            kelvinFrom.Content = ConvertConstants.TEMP_KELVIN;
            convertFromListBox.Items.Add(kelvinFrom);
            ListBoxItem kelvinTo = new ListBoxItem();
            kelvinTo.Content = ConvertConstants.TEMP_KELVIN;
            convertToListBox.Items.Add(kelvinTo);

            ListBoxItem celsiusFrom = new ListBoxItem();
            celsiusFrom.Content = ConvertConstants.TEMP_CELSIUS;
            convertFromListBox.Items.Add(celsiusFrom);
            ListBoxItem celsiusTo = new ListBoxItem();
            celsiusTo.Content = ConvertConstants.TEMP_CELSIUS;
            convertToListBox.Items.Add(celsiusTo);
        }

        private void setConvertListsToVolume()
        {
            throw new NotImplementedException();
        }

        private void setConvertListsToTime()
        {
            convertFromListBox.Items.Clear();
            convertToListBox.Items.Clear();
            ListBoxItem secondsFrom = new ListBoxItem();
            secondsFrom.Content = ConvertConstants.TIME_SECONDS;
            convertFromListBox.Items.Add(secondsFrom);
            ListBoxItem secondsTo = new ListBoxItem();
            secondsTo.Content = ConvertConstants.TIME_SECONDS;
            convertToListBox.Items.Add(secondsTo);

            ListBoxItem daysFrom = new ListBoxItem();
            daysFrom.Content = ConvertConstants.TIME_DAYS;
            convertFromListBox.Items.Add(daysFrom);
            ListBoxItem daysTo = new ListBoxItem();
            daysTo.Content = ConvertConstants.TIME_DAYS;
            convertToListBox.Items.Add(daysTo);

            ListBoxItem yearsFrom = new ListBoxItem();
            yearsFrom.Content = ConvertConstants.TIME_YEARS;
            convertFromListBox.Items.Add(yearsFrom);
            ListBoxItem yearsTo = new ListBoxItem();
            yearsTo.Content = ConvertConstants.TIME_YEARS;
            convertToListBox.Items.Add(yearsTo);
        }

        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            newPageInstance = false;
            State["textbox"] = valueTextBox.Text;

            int fromSelItem = convertFromListBox.SelectedIndex;
            State["fromSelectedItem"] = fromSelItem;
            
            int toSelItem = convertToListBox.SelectedIndex;
            State["toSelectedItem"] = toSelItem;
            
            base.OnNavigatedFrom(e);
        }
    }
}