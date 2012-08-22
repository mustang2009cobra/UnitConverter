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
    public class Area : Units
    {
        public double Convert(String fromType, String toType, double value)
        {
            if (fromType == ConvertConstants.AREA_SQ_CENT && toType == ConvertConstants.AREA_SQ_CENT)
            {
                return value;
            }
            else if (fromType == ConvertConstants.AREA_SQ_CENT && toType == ConvertConstants.AREA_SQ_FEET)
            {
                return value * 0.032808399;
            }
            else if (fromType == ConvertConstants.AREA_SQ_CENT && toType == ConvertConstants.AREA_SQ_INCH)
            {
                return value * 0.393700787;
            }
            else if (fromType == ConvertConstants.AREA_SQ_CENT && toType == ConvertConstants.AREA_SQ_METER)
            {
                return value * 0.01;
            }
            else if (fromType == ConvertConstants.AREA_SQ_FEET && toType == ConvertConstants.AREA_SQ_CENT)
            {
                return value * 30.48;
            }
            else if (fromType == ConvertConstants.AREA_SQ_FEET && toType == ConvertConstants.AREA_SQ_FEET)
            {
                return value;
            }
            else if (fromType == ConvertConstants.AREA_SQ_FEET && toType == ConvertConstants.AREA_SQ_INCH)
            {
                return value * 12; 
            }
            else if (fromType == ConvertConstants.AREA_SQ_FEET && toType == ConvertConstants.AREA_SQ_METER)
            {
                return value * .3048;
            }
            else if (fromType == ConvertConstants.AREA_SQ_INCH && toType == ConvertConstants.AREA_SQ_CENT)
            {
                return value * 2.54;
            }
            else if (fromType == ConvertConstants.AREA_SQ_INCH && toType == ConvertConstants.AREA_SQ_FEET)
            {
                return value * 0.0833333333;
            }
            else if (fromType == ConvertConstants.AREA_SQ_INCH && toType == ConvertConstants.AREA_SQ_INCH)
            {
                return value;
            }
            else if (fromType == ConvertConstants.AREA_SQ_INCH && toType == ConvertConstants.AREA_SQ_METER)
            {
                return value * 0.0254;
            }
            else if (fromType == ConvertConstants.AREA_SQ_METER && toType == ConvertConstants.AREA_SQ_CENT)
            {
                return value * 100;
            }
            else if (fromType == ConvertConstants.AREA_SQ_METER && toType == ConvertConstants.AREA_SQ_FEET)
            {
                return value * 3.2808399;
            }
            else if (fromType == ConvertConstants.AREA_SQ_METER && toType == ConvertConstants.AREA_SQ_INCH)
            {
                return value * 39.3700787;
            }
            else if (fromType == ConvertConstants.AREA_SQ_METER && toType == ConvertConstants.AREA_SQ_METER)
            {
                return value;
            }
            else
            {
                throw new Exception("Unexpected Area Type");
            }
        }
    }
}
