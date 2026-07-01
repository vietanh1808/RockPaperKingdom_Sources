using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UnitDeathSpawner : MonoBehaviour
	{
		[SerializeField]
		private UnitData _unitData;

		[SerializeField]
		private int _amount;

		[SerializeField]
		private float _spawnRadius;

		private BaseUnit _unit;

		private UnitPoolManager _unitPoolManager;

		private SharedUnitRepository _sharedUnitRepository;

		[Inject]
		private void Inject(UnitPoolManager unitPoolManager, SharedUnitRepository sharedUnitRepository)
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

		private void OnDied()
		{
		}

		private Vector3 GetSpawnPosition()
		{
			return default(Vector3);
		}
	}
}
