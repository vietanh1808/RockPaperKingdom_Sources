using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleInventoryElement<TItem, TItemData> : MonoBehaviour where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[Header("Default")]
		[SerializeField]
		private Image _backgroundImage;

		[SerializeField]
		private Image _titleBackgroundImage;

		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private TMP_Text _titleValue;

		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private UICollectibleAmountElement _uiCollectibleAmount;

		[SerializeField]
		private TMP_Text _lockedInfo;

		[SerializeField]
		private GameObject _newMark;

		[SerializeField]
		private GameObject _rewardMark;

		[Header("Containers")]
		[SerializeField]
		private GameObject _unlockedContainer;

		[SerializeField]
		private GameObject _lockedContainer;

		private BaseCollectibleSystem<TItem, TItemData> _collectibleSystem;

		protected RarityConfig _RarityConfig;

		private InventoryItem _materialItem;

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

		public virtual void Construct(TItem item, BaseCollectibleSystem<TItem, TItemData> baseCollectibleSystem, RarityConfig rarityConfig)
		{
		}

		protected virtual void Subscribe()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void SetupView()
		{
		}

		protected void RefreshLockedInfo()
		{
		}

		private void RefreshLevel(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		private void RefreshAmount(InventoryItem materialItem)
		{
		}

		private void RefreshUnlocked()
		{
		}

		private void ButtonClickHandler()
		{
		}

		protected virtual string GetLockedInfo()
		{
			return null;
		}

		private void RefreshNewMark(bool isNew)
		{
		}

		private void OnRewardCollectedChanged(bool isRewardCollected)
		{
		}

		private void RefreshRewardMark()
		{
		}
	}
}
