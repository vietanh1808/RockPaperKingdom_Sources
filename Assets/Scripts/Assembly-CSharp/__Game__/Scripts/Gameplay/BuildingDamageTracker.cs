using System;
using System.Collections.Generic;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingDamageTracker : IInitializable, IDisposable
	{
		private readonly BuildingRepository _buildingRepository;

		private readonly UnitRepository _enemyUnitRepository;

		private readonly UnitRepository _playerUnitRepository;

		private readonly Dictionary<BaseBuildingData, BuildingDamageRecord> _records;

		private readonly Dictionary<IDamageable, BaseBuildingData> _damageableToBuilding;

		private readonly Dictionary<UnitData, BaseBuildingData> _unitDataToBuilding;

		private readonly Dictionary<IDamageable, Action<Damage>> _damageReceivedHandlers;

		public BuildingDamageTracker(BuildingRepository buildingRepository, UnitRepositoryFactory unitRepositoryFactory)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public IReadOnlyList<BuildingDamageRecord> GetRecords()
		{
			return null;
		}

		public List<DamageStatsSaveData> CollectDamageStats()
		{
			return null;
		}

		public void RestoreRecords(List<DamageStatsSaveData> damageStats)
		{
		}

		private BaseBuildingData FindBuildingDataByGuid(string guid)
		{
			return null;
		}

		private void OnBuildingAdded(BaseBuilding building)
		{
		}

		private void OnBuildingRemoved(BaseBuilding building)
		{
		}

		private void OnPlayerUnitAdded(BaseUnit unit)
		{
		}

		private void OnPlayerUnitRemoved(BaseUnit unit)
		{
		}

		private void OnEnemyUnitAdded(BaseUnit unit)
		{
		}

		private void OnEnemyUnitRemoved(BaseUnit unit)
		{
		}

		private void RegisterDamageable(IDamageable damageable, BaseBuildingData buildingData, UnitHealthPoints healthPoints)
		{
		}

		private void RegisterDamageable(IDamageable damageable, BaseBuildingData buildingData, BuildHealthPoints healthPoints)
		{
		}

		private void UnregisterDamageable(BaseBuilding building, BuildHealthPoints healthPoints)
		{
		}

		private void UnregisterDamageable(BaseUnit unit, UnitHealthPoints healthPoints)
		{
		}

		private void RegisterUnitSpawnMapping(UnitSpawnBuilding unitSpawnBuilding)
		{
		}

		private BuildingDamageRecord GetOrCreateRecord(BaseBuildingData buildingData)
		{
			return null;
		}

		private void TrackDamageReceived(BaseBuildingData buildingData, Damage damage)
		{
		}

		private void TrackDamageDealtBySource(Damage damage)
		{
		}
	}
}
