using UnityEngine;

namespace __Game__.Scripts.Gameplay.Arena
{
	[CreateAssetMenu(fileName = "Config_ArenaDebug", menuName = "TapHub/Arena/Arena Debug Config")]
	public class ArenaDebugConfig : ScriptableObject
	{
		[SerializeField]
		private bool _isDebugMode;

		[Range(1f, 20f)]
		[SerializeField]
		private float _debugTimeScale;

		[Header("Tier Override")]
		[SerializeField]
		private bool _overrideTier;

		[SerializeField]
		private ArenaTierData _tierOverride;

		[Header("Strategy Override")]
		[SerializeField]
		private bool _overrideStrategy;

		[SerializeField]
		private ArenaEnemyStrategyData _strategyOverride;

		[Header("Stat Multipliers")]
		[SerializeField]
		private bool _disableEnemyStatMultipliers;

		[SerializeField]
		private bool _disablePlayerStatMultipliers;

		private bool ShowTierOverride => false;

		private bool ShowStrategyOverride => false;

		public ArenaDebugSettings GetArenaDebugSettings()
		{
			return null;
		}
	}
}
