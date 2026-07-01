using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class CollectibleModifiers
	{
		[SerializeField]
		private BaseModifier _modifier;

		[SerializeField]
		private int _requiredIndex;

		public int RequiredIndex => 0;

		public BaseModifier Modifier => null;

		public bool IsLocked(int index)
		{
			return false;
		}
	}
}
