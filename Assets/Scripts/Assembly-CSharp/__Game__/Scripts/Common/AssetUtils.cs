using System;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	public class AssetUtils
	{
		public static T Create<T>(Type type, ScriptableObject parent, string assetName = "") where T : ScriptableObject
		{
			return null;
		}

		public static T[] GetNested<T>(ScriptableObject parent) where T : ScriptableObject
		{
			return null;
		}

		public static void DeleteInner(ScriptableObject inner)
		{
		}
	}
}
