using System;
namespace VeeamLabs.Labs
{
	public class ImmutableRgbType
	{
		public int Red { get; }
		public int Green { get; }
		public int Blue { get; }

		public ImmutableRgbType(int red, int green, int blue)
		{
			Red = red;
			Green = green;
			Blue = blue;
		}
	}
}

