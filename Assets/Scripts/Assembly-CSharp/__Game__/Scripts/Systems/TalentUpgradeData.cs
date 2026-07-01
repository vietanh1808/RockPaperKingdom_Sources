using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "TalentUpgradeData", menuName = "TapHub/Talents/Talent Upgrade Data")]
	public class TalentUpgradeData : BaseTalentData
	{
		[Header("Modifier")]
		[SerializeField]
		private AssetModuleHolder<BaseModifier> _assetModuleHolder;

		[Header("Generate Settings")]
		[SerializeField]
		private int _modifiersAmount;

		[SerializeField]
		private float _multiplierPerLevel;

		public override int MaxLevelIndex => 0;

		private bool ShowGenerateModulesButton => false;

		private void OnEnable()
		{
		}

		public BaseModifier GetModifierPerLevelIndex(int levelIndex)
		{
			return null;
		}

		public override string GetDescription(int levelIndex)
		{
			return null;
		}
	}
}
