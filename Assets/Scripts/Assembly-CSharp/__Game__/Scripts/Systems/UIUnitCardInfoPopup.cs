using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Systems
{
	public class UIUnitCardInfoPopup : UIBaseCollectibleInfoPopup<UnitCardSystem, UnitCardItem, UnitCardItemData>
	{
		[Header("Rarity Badge")]
		[SerializeField]
		private Image _rarityBadgeImage;

		[SerializeField]
		private TMP_Text _rarityBadgeText;

		[Header("UnitCard Info Components")]
		[SerializeField]
		private UIStatElement _uiStatHealth;

		[SerializeField]
		private UIStatElement _uiStatDamage;

		[SerializeField]
		private UIStatElement _uiStatAttackSpeed;

		[SerializeField]
		private UICollectibleModifiersView _collectibleModifiersView;

		[Header("Card Info")]
		[SerializeField]
		private TMP_Text _buildingTypeText;

		[SerializeField]
		private TMP_Text _kingdomText;

		protected override void SetupView()
		{
		}

		protected override void RefreshLevel(BaseCollectibleItem<UnitCardItemData> collectibleItem, bool animated)
		{
		}

		private void SetupRarityBadge()
		{
		}

		private void RefreshUnitView()
		{
		}

		private void SetupStatsVisibility()
		{
		}

		protected virtual void RefreshStatsView(bool animated)
		{
		}

		private void RefreshUnitSpawnStats(bool animated)
		{
		}

		private void RefreshTowerStats(bool animated)
		{
		}

		private void SetStatValue(UIStatElement statElement, float value, bool animated)
		{
		}

		private void RefreshModifiersView()
		{
		}

		private void RefreshBuildingType()
		{
		}

		private void RefreshKingdom()
		{
		}

		private string GetBuildingTypeDisplayName(BuildingType buildingType)
		{
			return null;
		}
	}
}
