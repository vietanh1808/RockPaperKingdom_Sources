using UnityEngine.Pool;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class TowerAttackFactory
	{
		private const int DEFAULT_CAPACITY = 4;

		private readonly DiContainer _diContainer;

		private readonly TowerAttackObject _towerAttackPrefab;

		private readonly ObjectPool<TowerAttackObject> _attackPool;

		public TowerAttackFactory(DiContainer diContainer, TowerAttackObject towerAttackPrefab)
		{
		}

		public TowerAttackObject GetProjectile()
		{
			return null;
		}

		private TowerAttackObject CreateProjectile()
		{
			return null;
		}

		private void OnGetProjectile(TowerAttackObject projectile)
		{
		}

		private void OnReleaseProjectile(TowerAttackObject projectile)
		{
		}
	}
}
