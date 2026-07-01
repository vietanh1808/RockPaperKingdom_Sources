using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIHeroInventoryElement : UIBaseCollectibleInventoryElement<HeroItem, HeroItemData>
	{
		[SerializeField]
		private GameObject _activatedContainer;

		[SerializeField]
		private UIHeroUnitCardNewAlert _unitCardNewAlert;

		[Header("Stage Unlock")]
		[SerializeField]
		private GameObject _stageUnlockContainer;

		[SerializeField]
		private TMP_Text _stageRequirementText;

		[Header("Inventory Item Unlock")]
		[SerializeField]
		private GameObject _inventoryItemUnlockContainer;

		[SerializeField]
		private TMP_Text _inventoryItemRequirementText;

		[SerializeField]
		private Image _unlockResourceIcon;

		private InventorySystem _inventorySystem;

		private InventoryItem _unlockInventoryItem;

		[Inject]
		private void Inject(InventorySystem inventorySystem)
		{
		}

		public override void Construct(HeroItem item, BaseCollectibleSystem<HeroItem, HeroItemData> baseCollectibleSystem, RarityConfig rarityConfig)
		{
		}

		protected override string GetLockedInfo()
		{
			return null;
		}

		protected override void Subscribe()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void RefreshActiveStatus(HeroItem heroItem)
		{
		}

		private void SetupLockedContainers()
		{
		}

		private void OnUnlockResourceAmountChanged(InventoryItem inventoryItem)
		{
		}

		private string GetStageRequirementMessage()
		{
			return null;
		}

		private string GetInventoryItemRequirementMessage()
		{
			return null;
		}

		private string GetDailyRewardRequirementMessage()
		{
			return null;
		}
	}
}
