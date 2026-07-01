using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "GameplayDebugStageSettings_", menuName = "TapHub/Debug/Stage Settings")]
	public class GameplayDebugStageSettings : ScriptableObject
	{
		[Header("Stage Settings")]
		[SerializeField]
		private StageData _stageDataOverride;

		[Header("Unit Settings")]
		[SerializeField]
		private List<GameplayDebugUnitSettings> _unitOverrides;

		[Header("Extra Unit Cards")]
		[SerializeField]
		private List<UnitCardItemData> _extraUnitCards;

		[Header("Player Settings")]
		[SerializeField]
		private int _playerUpgradeIndex;

		[Header("Multipliers Settings")]
		[SerializeField]
		private bool _useUnitPowerMultipliersAndPlayerUpgrades;

		[Header("RPS")]
		[SerializeField]
		private bool _autoApplyRPS;

		public StageData StageDataOverride => null;

		public List<GameplayDebugUnitSettings> UnitOverrides => null;

		public List<UnitCardItemData> ExtraUnitCards => null;

		public int PlayerUpgradeIndex => 0;

		public bool UseUnitPowerMultipliersAndPlayerUpgrades => false;

		public bool AutoApplyRPS => false;

		private void UpdateUnitLevelVisibility()
		{
		}
	}
}
