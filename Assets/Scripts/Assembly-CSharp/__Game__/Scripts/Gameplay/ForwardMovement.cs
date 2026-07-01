using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Environment;

namespace __Game__.Scripts.Gameplay
{
	[RequireComponent(typeof(Rigidbody))]
	public class ForwardMovement : AbilityObjectComponent
	{
		[SerializeField]
		private float _speed;

		[SerializeField]
		private bool _controlRotation;

		private EnvironmentBounds _environmentBounds;

		private GameplayDebugSettings _gameplayDebugSettings;

		private Rigidbody _rigidbody;

		private AbilityObject _abilityObject;

		private Vector3 _direction;

		[Inject]
		private void Inject(EnvironmentBounds environmentBounds, GameplayDebugSettings gameplayDebugSettings)
		{
		}

		private void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}
	}
}
