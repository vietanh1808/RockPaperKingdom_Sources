using UnityEngine;
using Zenject;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class FurthestEnemyJump : MonoBehaviour
	{
		[SerializeField]
		private ParticlePoolElement _jumpParticlePrefab;

		private BaseUnit _unit;

		private AssassinJumpIterator _assassinJumpIterator;

		private ParticlePoolContainer _particlePoolContainer;

		[Inject]
		private void Inject(AssassinJumpIterator assassinJumpIterator, ParticlePoolContainer particlePoolContainer)
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

		public void Jump()
		{
		}
	}
}
