using System;
using System.Drawing;
using DotNet.Highstock.Enums;
using DotNet.Highstock.Attributes;
using DotNet.Highstock.Helpers;

namespace DotNet.Highstock.Options
{
	public class SeriesDataMarkerStates
	{
		public SeriesDataMarkerStatesHover Hover { get; set; }

		/// <summary>
		/// The appearance of the point marker when selected. In order to allow a point to be  selected, set the <code>series.allowPointSelect</code> option to true.
		/// </summary>
		public SeriesDataMarkerStatesSelect Select { get; set; }

	}

}