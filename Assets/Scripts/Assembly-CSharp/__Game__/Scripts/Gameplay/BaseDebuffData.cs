using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseDebuffData : ScriptableObject
	{
		protected AbilityObjectPoolContainer AbilityObjectPoolContainer;

		public virtual void InitDebuff(AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		public abstract void Apply(IDebuffable debuffable, Ability ability);
	}
}
