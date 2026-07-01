namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaDebugSettings
	{
		public bool IsDebugMode { get; }

		public float DebugTimeScale { get; }

		public bool OverrideTier { get; }

		public ArenaTierData TierOverride { get; }

		public bool OverrideStrategy { get; }

		public ArenaEnemyStrategyData StrategyOverride { get; }

		public bool DisableEnemyStatMultipliers { get; }

		public bool DisablePlayerStatMultipliers { get; }

		public ArenaDebugSettings(bool isDebugMode, float debugTimeScale, bool overrideTier, ArenaTierData tierOverride, bool overrideStrategy, ArenaEnemyStrategyData strategyOverride, bool disableEnemyStatMultipliers, bool disablePlayerStatMultipliers)
		{
		}
	}
}
