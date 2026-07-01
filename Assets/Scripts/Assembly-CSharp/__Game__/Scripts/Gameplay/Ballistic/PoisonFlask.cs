using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.Ballistic
{
	public class PoisonFlask : AbilityObjectComponent
	{
		[SerializeField]
		private GameObject _flaskVisual;

		[SerializeField]
		private GameObject _poisonParticleContainer;

		[SerializeField]
		private SoundData _landingSFX;

		private readonly Collider[] _results;

		private IDestinationReached _destinationReached;

		private AbilityObject _abilityObject;

		private float _radius;

		private float _tickInterval;

		private float _tickCooldown;

		private float _duration;

		private float _durationRemaining;

		private Vector3 _poisonPosition;

		private bool _isPoisonActive;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void OnLanded()
		{
		}

		private void Deactivate()
		{
		}

		private void TickDamage()
		{
		}
	}
}
