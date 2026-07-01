namespace __Game__.Scripts.Systems
{
	public static class HeroMetaPowerCalculator
	{
		private const int BASE_META_POWER = 100;

		private const float UNIT_CARD_POWER_WEIGHT = 1f / 3f;

		private const float POWER_PER_HP = 10f;

		public static int Calculate(HeroItem heroItem, UnitCardSystem unitCardSystem, PlayerStatConfig playerStatConfig)
		{
			return 0;
		}

		private static void ApplyModifierContribution(BaseModifier modifier, PlayerStatConfig playerStatConfig, ref float totalDmg, ref float totalHp, ref float castleBonus)
		{
		}

		private static void ApplyUnitMultiplyModifier(UnitMultiplyStatModifier unitMultiplyStatModifier, ref float totalDmg, ref float totalHp)
		{
		}

		private static void ApplyPlayerAddModifier(PlayerAddStatModifier playerAddStatModifier, ref float castleBonus)
		{
		}

		private static void ApplyPlayerMultiplyModifier(PlayerMultiplyStatModifier playerMultiplyStatModifier, PlayerStatConfig playerStatConfig, ref float castleBonus)
		{
		}

		private static float CalculateUnitCardMultiplier(HeroItem heroItem, UnitCardSystem unitCardSystem)
		{
			return 0f;
		}
	}
}
