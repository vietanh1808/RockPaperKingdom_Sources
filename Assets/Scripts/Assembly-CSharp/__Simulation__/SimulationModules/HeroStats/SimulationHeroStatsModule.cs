using System.Collections.Generic;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Systems;
using __Simulation__.Systems;

namespace __Simulation__.SimulationModules.HeroStats
{
	public class SimulationHeroStatsModule : ISimulationModule
	{
		private const int TOP_HERO_COUNT = 3;

		private readonly HeroSystem _heroSystem;

		private readonly UnitCardSystem _unitCardSystem;

		private readonly PlayerStatConfig _playerStatConfig;

		private readonly PlayerPowerSystem _playerPowerSystem;

		private readonly PlayerUpgradesSystem _playerUpgradesSystem;

		private readonly TalentCollectionSystem _talentCollectionSystem;

		public SimulationHeroStatsModule(HeroSystem heroSystem, UnitCardSystem unitCardSystem, PlayerStatConfig playerStatConfig, PlayerPowerSystem playerPowerSystem, PlayerUpgradesSystem playerUpgradesSystem, TalentCollectionSystem talentCollectionSystem)
		{
		}

		public void Iterate(SimulationSnapshot simulationSnapshot)
		{
		}

		private void CollectMultipliersBySource(List<HeroItem> strongestHeroes, SimulationSnapshot simulationSnapshot)
		{
		}

		private static void CollectHeroBaseMultipliers(List<HeroItem> strongestHeroes, Dictionary<string, float> hpBySource, Dictionary<string, float> dmgBySource)
		{
		}

		private static void CollectHeroModifierMultipliers(List<HeroItem> strongestHeroes, Dictionary<string, float> hpBySource, Dictionary<string, float> dmgBySource)
		{
		}

		private static void CollectModifierMultipliers(List<BaseModifier> modifiers, string source, Dictionary<string, float> hpBySource, Dictionary<string, float> dmgBySource)
		{
		}

		private static void AddMultiplier(Dictionary<string, float> multipliersBySource, string source, Dictionary<UnitStatType, float> unitStatMultipliers, UnitStatType statType)
		{
		}

		private static void AddToSource(Dictionary<string, float> multipliersBySource, string source, float value)
		{
		}

		private List<HeroItem> GetStrongestHeroes(int count)
		{
			return null;
		}
	}
}
