using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UnitConverter
{
    public class Temperature : Units
    {
        public double Convert(String fromType, String toType, double value)
        {
            if (fromType == ConvertConstants.TEMP_CELSIUS && toType == ConvertConstants.TEMP_CELSIUS)
            {
                return value;
            }
            else if (fromType == ConvertConstants.TEMP_CELSIUS && toType == ConvertConstants.TEMP_FAREN)
            {
                return ((9.0/5.0) * value) + 32;
            }
            else if (fromType == ConvertConstants.TEMP_CELSIUS && toType == ConvertConstants.TEMP_KELVIN)
            {
                return value + 273.15;
            }
            else if (fromType == ConvertConstants.TEMP_FAREN && toType == ConvertConstants.TEMP_CELSIUS)
            {
                return (5.0/9.0) * (value - 32) ;
            }
            else if (fromType == ConvertConstants.TEMP_FAREN && toType == ConvertConstants.TEMP_FAREN)
            {
                return value;
            }
            else if (fromType == ConvertConstants.TEMP_FAREN && toType == ConvertConstants.TEMP_KELVIN)
            {
                return ((5.0/9.0) * (value - 32)) + 273.15;
            }
            else if (fromType == ConvertConstants.TEMP_KELVIN && toType == ConvertConstants.TEMP_CELSIUS)
            {
                return value - 273.15;
            }
            else if (fromType == ConvertConstants.TEMP_KELVIN && toType == ConvertConstants.TEMP_FAREN)
            {
                return ((value - 273) * 1.8) + 32;
            }
            else if (fromType == ConvertConstants.TEMP_KELVIN && toType == ConvertConstants.TEMP_KELVIN)
            {
                return value;
            }
            else
            {
                throw new Exception("Unexpected Type value in Time");
            }
        }
    }
}
