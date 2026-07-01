using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class SpearThrow : MonoBehaviour
	{
		private static readonly Vector3 PLAYER_FORWARD;

		private static readonly Vector3 ENEMY_FORWARD;

		[SerializeField]
		private float _throwDelay;

		private BaseUnit _unit;

		private IRoundEventProvider _roundEventProvider;

		private AbilityObjectPoolContainer _abilityObjectPoolContainer;

		[Inject]
		private void Inject(IRoundEventProvider roundEventProvider, AbilityObjectPoolContainer abilityObjectPoolContainer)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnRoundStarted()
		{
		}

		private void SpawnWithDirectionOverride(Ability ability)
		{
		}
	}
}
