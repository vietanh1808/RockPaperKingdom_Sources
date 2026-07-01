using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIFeatureUnlockTargetRegistry : SerializedMonoBehaviour
	{
		[SerializeField]
		private Dictionary<FeatureItemData, List<RectTransform>> _targets;

		public bool TryGetTarget(FeatureItemData data, out RectTransform target)
		{
			target = null;
			return false;
		}
	}
}
