using System;

namespace __Game__.Scripts.Common
{
	public static class EnumUtils
	{
		private static readonly Random Random;

		public static T GetRandom<T>() where T : Enum
		{
			return default(T);
		}
	}
}
