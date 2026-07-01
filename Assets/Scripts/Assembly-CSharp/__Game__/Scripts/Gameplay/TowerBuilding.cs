using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TowerBuilding : BaseBuilding
	{
		[Header("Weapon")]
		[SerializeField]
		private Transform _weaponTransform;

		[SerializeField]
		private TowerBuildingAnimation _animation;

		private AbilityFactory _abilityFactory;

		private UnitType _side;

		public TowerBuildingData TowerBuildingData { get; private set; }

		public TowerStats TowerStats => null;

		public UnitRepository EnemyRepository { get; private set; }

		public SharedAbility SharedAbility { get; private set; }

		public Ability MainAbility { get; private set; }

		public TowerTargetHolder TargetHolder { get; private set; }

		public void Construct(TowerBuildingData buildingData, BuildingRuntime building, UnitRepository enemyRepository, SharedAbility sharedAbility, AbilityFactory abilityFactory, UnitType side)
		{
		}

		private void Update()
		{
		}

		public override void SetBuildingState(BuildingState state)
		{
		}

		private void InitializeAbility()
		{
		}
	}
}
