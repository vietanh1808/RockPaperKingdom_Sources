using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class Tower : MonoBehaviour
	{
		[SerializeField]
		private float _attackDamage;

		[SerializeField]
		private float _attackMoveSpeed;

		[SerializeField]
		private float _attackCooldown;

		[SerializeField]
		private float _attackRange;

		[SerializeField]
		private float _preparingCastTime;

		[SerializeField]
		private Transform _spawnPoint;

		private readonly UnitAnimation _unitAnimation;

		private UnitRepository _enemyUnitRepository;

		private TowerAttackFactory _towerAttackFactory;

		private float _timer;

		[Inject]
		private void Inject(UnitRepositoryFactory unitRepositoryFactory, TowerAttackFactory towerAttackFactory)
		{
		}

		private void Awake()
		{
		}

		private void Update()
		{
		}

		private void UpdatePreparingStatus()
		{
		}

		private void UpdateAttackStatus()
		{
		}

		private void Attack(BaseUnit targetUnit)
		{
		}

		private Vector3 GetTargetPosition(BaseUnit targetUnit, Vector3 startPosition)
		{
			return default(Vector3);
		}

		public void ResetCooldown()
		{
		}
	}
}
