using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_PlayerUpgrades", menuName = "TapHub/Player/Upgrades Config")]
	public class PlayerUpgradesConfig : ScriptableObject
	{
		[SerializeField]
		private List<PlayerUpgradeData> _upgrades;

		[HideInInspector]
		[SerializeField]
		private bool _isWrongOrder;

		[SerializeField]
		private Sprite _playerHealthPointIcon;

		[SerializeField]
		private Sprite _playerArmorIcon;

		[SerializeField]
		private Sprite _unitHpIcon;

		[SerializeField]
		private Sprite _unitDamageIcon;

		public List<PlayerUpgradeData> Upgrades => null;

		private void ValidateOrder()
		{
		}

		private void SortElements()
		{
		}

		private void ReconfigureRequiredLevels()
		{
		}

		private void SetupIcons()
		{
		}

		private Sprite GetIconForModifier(BaseModifier modifier)
		{
			return null;
		}

		private Sprite GetPlayerAddStatIcon(PlayerAddStatModifier modifier)
		{
			return null;
		}

		private Sprite GetUnitMultiplyStatIcon(UnitMultiplyStatModifier modifier)
		{
			return null;
		}
	}
}
