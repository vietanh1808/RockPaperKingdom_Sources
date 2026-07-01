using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleInfoPopup<TSystem, TItem, TItemData> : UIBasePopup where TSystem : BaseCollectibleSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[Header("Collectible Info Popup")]
		[SerializeField]
		private Image _itemIcon;

		[SerializeField]
		private Image _rarityIcon;

		[SerializeField]
		private TMP_Text _rarityValue;

		[SerializeField]
		private TMP_Text _titleValue;

		[SerializeField]
		private TMP_Text _levelValue;

		[SerializeField]
		private string _levelFormat;

		[SerializeField]
		private TMP_Text _descriptionValue;

		protected TItem CollectibleItem;

		protected TSystem CollectibleSystem;

		private TItemData _collectibleItemData;

		protected RarityConfig _RarityConfig;

		[Inject]
		private void Inject(TSystem collectibleSystem, RarityConfig rarityConfig)
		{
		}

		public void SetItem(TItem item)
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		protected virtual void SetupView()
		{
		}

		private void OnLevelChanged(BaseCollectibleItem<TItemData> collectibleItem)
		{
		}

		protected virtual void RefreshLevel(BaseCollectibleItem<TItemData> collectibleItem, bool animated)
		{
		}

		protected virtual string GetTitleValue(string itemDataTitle)
		{
			return null;
		}
	}
}
