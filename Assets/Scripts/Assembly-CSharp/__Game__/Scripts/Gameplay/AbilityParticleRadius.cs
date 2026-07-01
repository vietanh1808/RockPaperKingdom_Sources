using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AbilityParticleRadius : AbilityObjectComponent
	{
		[SerializeField]
		private ParticleSystem _particleSystem;

		[SerializeField]
		private float _minRadius;

		[SerializeField]
		private float _maxRadius;

		[SerializeField]
		private int _minParticlesAmount;

		[SerializeField]
		private int _maxParticlesAmount;

		private AbilityObject _abilityObject;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}
	}
}
