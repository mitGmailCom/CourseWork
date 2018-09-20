﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace MedicalApp
{
	// using for convert bool to string in datagrid
	public class BoolToStringConverter : IValueConverter
	{
		public string FalseValue { get; set; }
		public string TrueValue { get; set; }

		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			if (value == null)
				return FalseValue;
			else
				return (bool)value ? TrueValue : FalseValue;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value != null ? value.Equals(TrueValue) : false;
		}
	}
}
