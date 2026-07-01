using System.Collections.Generic;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class SharedAbility
	{
		private StatValue _damageValue;

		public AbilityData Data { get; }

		public AbilityObjectPoolContainer AbilityObjectPoolContainer { get; }

		public AbilityStats AbilityStats { get; }

		public List<BaseDebuffData> Debuffs { get; }

		public AbilityObject AbilityObjectPrefab { get; set; }

		public AbilityObject HitEffectObjectPrefab { get; set; }

		public AbilityObject SourceEffectObjectPrefab { get; set; }

		public SharedAbility CastOnHitSharedAbility { get; set; }

		public SharedAbility(AbilityData abilityData, AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public void InitializeDamage(StatValue damageValue)
		{
		}

		private void OnDamageValueChanged(StatValue statValue)
		{
		}

		private void UpdateAbilityDamage()
		{
		}
	}
}
