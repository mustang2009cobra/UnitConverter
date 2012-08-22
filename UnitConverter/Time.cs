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
    public class Time : Units
    {
        public double Convert(String fromType, String toType, double value)
        {
            if (fromType == ConvertConstants.TIME_DAYS && toType == ConvertConstants.TIME_DAYS)
            {
                return value;
            }
            else if (fromType == ConvertConstants.TIME_DAYS && toType == ConvertConstants.TIME_SECONDS)
            {
                return value * 86400;
            }
            else if (fromType == ConvertConstants.TIME_DAYS && toType == ConvertConstants.TIME_YEARS)
            {
                return value * 0.00273790926;
            }
            else if (fromType == ConvertConstants.TIME_SECONDS && toType == ConvertConstants.TIME_DAYS)
            {
                return value * .0000115740741;
            }
            else if (fromType == ConvertConstants.TIME_SECONDS && toType == ConvertConstants.TIME_SECONDS)
            {
                return value;
            }
            else if (fromType == ConvertConstants.TIME_SECONDS && toType == ConvertConstants.TIME_YEARS)
            {
                return value * .0000000316887646;
            }
            else if (fromType == ConvertConstants.TIME_YEARS && toType == ConvertConstants.TIME_DAYS)
            {
                return value * 365.242199;
            }
            else if (fromType == ConvertConstants.TIME_YEARS && toType == ConvertConstants.TIME_SECONDS)
            {
                return value * 31556926;
            }
            else if (fromType == ConvertConstants.TIME_YEARS && toType == ConvertConstants.TIME_YEARS)
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
