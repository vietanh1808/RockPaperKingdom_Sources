using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleModifiersView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootLayout;

		[SerializeField]
		private UICollectibleModifierElement _modifierElementPrefab;

		private readonly Dictionary<int, UICollectibleModifierElement> _modifierElementPerLevel;

		private int _previousLevel;

		public void Construct(BaseCollectibleItemData itemData, int collectibleLevel)
		{
		}

		public void RefreshLevel(int currentLevel)
		{
		}
	}
}
