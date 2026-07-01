using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.Enemy
{
	public class ArenaEnemySetup : MonoBehaviour
	{
		[SerializeField]
		private BuildingUnitSpawner _enemySpawner;

		[SerializeField]
		private EnemyBuildingSlotGridView _enemyGridView;

		[SerializeField]
		private Castle _enemyCastle;

		private ArenaEnemyStaticStatSystem _arenaEnemyStaticStatSystem;

		public BuildingUnitSpawner EnemySpawner => null;

		public Castle EnemyCastle => null;

		[Inject]
		public void Inject(ArenaEnemyStaticStatSystem arenaEnemyStaticStatSystem)
		{
		}

		public void Initialize(BuildingSlotGrid enemyGrid)
		{
		}
	}
}
