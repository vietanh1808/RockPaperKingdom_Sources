using System;
using System.Runtime.CompilerServices;
using Sirenix.OdinInspector;
using UnityEngine;
using UnityEngine.AI;
using Zenject;
using __BattleSimulation__.Scripts;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseUnit : SerializedMonoBehaviour, IPoolElement, IDamageable, IDebuffable
	{
		[SerializeField]
		private Transform _modelTransform;

		[SerializeField]
		private Transform _weaponTransform;

		[SerializeField]
		private UnitSize _size;

		[SerializeField]
		private NavMeshAgent _navMeshAgent;

		[Header("Spawn Animation")]
		[SerializeField]
		private Transform _spawnAnimationTransform;

		private UnitPoolManager _unitPoolManager;

		private UnitRepository _unitRepository;

		private UnitRepository _enemyRepository;

		private UnitTargetHolderFactory _unitTargetHolderFactory;

		private UnitStateMachineFactory _unitStateMachineFactory;

		private AbilityFactory _abilityFactory;

		private DebuffHolder _debuffHolder;

		private BaseUnitStateMachine _stateMachine;

		private bool _isTargetable;

		public UnitHealthPoints HealthPoints { get; }

		public UnitMovement Movement { get; }

		public UnitAnimation Animation { get; }

		public UnitData Data { get; private set; }

		public SharedUnit SharedUnit { get; private set; }

		public BuildingRuntime BuildingRuntime { get; private set; }

		public BaseUnitTargetHolder TargetHolder { get; private set; }

		public UnitRepository EnemyRepository => null;

		public Skin2D Skin { get; private set; }

		public Ability MainAbility { get; private set; }

		public Ability SecondaryAbility { get; private set; }

		public Ability DeathAbility { get; private set; }

		public Ability OnDamageReceivedAbility { get; private set; }

		public IDamageable LastDamageSource { get; private set; }

		public bool IsReady { get; private set; }

		public float DamageMultiplier { get; private set; }

		public float CastleDamageMultiplier { get; private set; }

		public UnitType Side { get; private set; }

		public bool IsPassive => false;

		public UnitSize Size => null;

		public event Action OnReady
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnDied
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnBuildingRuntimeChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(UnitTargetHolderFactory unitTargetHolderFactory, UnitStateMachineFactory unitStateMachineFactory, AbilityFactory abilityFactory)
		{
		}

		private void Update()
		{
		}

		public void SetUnitPoolManager(UnitPoolManager unitPoolManager)
		{
		}

		public void Construct(UnitData unitData, UnitRepository unitRepository, UnitRepository enemyRepository)
		{
		}

		public void SetSide(UnitType side)
		{
		}

		public void Init(SharedUnit sharedUnit)
		{
		}

		public void SetBuildingRuntime(BuildingRuntime buildingRuntime)
		{
		}

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public void ApplyHealthMultiplier(float healthMultiplier)
		{
		}

		public void ApplyDamageMultiplier(float damageMultiplier)
		{
		}

		public void ApplyCastleDamageMultiplier(float castleDamageMultiplier)
		{
		}

		public void TakeDamage(Damage damage)
		{
		}

		public Transform GetTransform()
		{
			return null;
		}

		public void TakeDebuff(BaseDebuff debuff)
		{
		}

		public bool CanTakeDamage()
		{
			return false;
		}

		public bool CanBeTargeted()
		{
			return false;
		}

		public Vector3 GetDamagePosition(Vector3 sourcePosition)
		{
			return default(Vector3);
		}

		public void Kill()
		{
		}

		public BaseUnitStateMachine GetStateMachine()
		{
			return null;
		}

		private void ShowSpawnAnimation()
		{
		}

		private void Death()
		{
		}

		private void InitializeAbilities()
		{
		}

		private Ability CreateAbility(SharedAbility sharedAbility)
		{
			return null;
		}

		private void SubscribeToMainAbilityEvents()
		{
		}

		private void UnsubscribeFromAbilityEvents()
		{
		}

		private void OnMainAbilityCastStart()
		{
		}

		private void OnDamageReceivedAbilityTrigger(Damage damage)
		{
		}

		public void OverrideSimulationStats(UnitBattleSimulationStats unitBattleSimulationStats)
		{
		}

		private void SetupComponents()
		{
		}

		private T GetOrAddComponent<T>() where T : Component
		{
			return null;
		}
	}
}
