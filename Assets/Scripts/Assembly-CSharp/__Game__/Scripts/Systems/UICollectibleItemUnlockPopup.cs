using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleItemUnlockPopup : UIBasePopup
	{
		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private TMP_Text _itemTitle;

		private BaseCollectibleItemData _itemData;

		private Action<string> _onClosed;

		public void SetItem(BaseCollectibleItemData itemData, Action<string> onClosed)
		{
		}

		protected override void OnDisable()
		{
		}
	}
}
