using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Common
{
	public static class DictionaryUtils
	{
		public static Dictionary<int, float> ToIntKeyDictionary<TEnum>(Dictionary<TEnum, float> source) where TEnum : Enum
		{
			return null;
		}

		public static void FromIntKeyDictionary<TEnum>(Dictionary<int, float> source, Dictionary<TEnum, float> target) where TEnum : Enum
		{
		}
	}
}
