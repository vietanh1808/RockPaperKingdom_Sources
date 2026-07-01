using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleElement<TItem, TItemData> : MonoBehaviour where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[Header("Default")]
		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private GameObject _newMark;

		private RarityConfig _rarityConfig;

		private TItemData _itemData;

		public TItem Item { get; private set; }

		public event Action<TItem> OnConstructed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action<TItem> OnButtonClicked
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Construct(TItem item, RarityConfig rarityConfig)
		{
		}

		private void OnDestroy()
		{
		}

		private void Subscribe()
		{
		}

		private void ButtonClickHandler()
		{
		}

		private void RefreshNewMark(bool isNew)
		{
		}
	}
}
