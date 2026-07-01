using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Common;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseBuilding : MonoBehaviour, IDamageable
	{
		[SerializeField]
		private UIBuildingHealthPointIndicator _healthPointIndicator;

		[SerializeField]
		private UIBuildingLevelIndicator _levelIndicator;

		[SerializeField]
		private UIBuildingStatChangeDisplay _statChangeDisplay;

		[SerializeField]
		private Skin2D _skin;

		[Header("Spawn Animation")]
		[SerializeField]
		private Transform _spawnAnimationTransform;

		[SerializeField]
		private SoundData _spawnSound;

		protected BuildingSlot BuildingSlot;

		private GameplayInventorySystem _gameplayInventorySystem;

		private BuildingRepository _buildingRepository;

		public BaseBuildingData BuildingData { get; private set; }

		public BuildingRuntime BuildingRuntime { get; private set; }

		public BuildHealthPoints HealthPoints { get; }

		public Skin2D Skin => null;

		public bool IsDestroyed { get; private set; }

		public bool KeepActiveOnDestroy { get; protected set; }

		public virtual bool HasSpawnableUnits => false;

		public IDamageable LastDamageSource => null;

		public event Action<BaseBuilding> OnBeforeDestroy
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

		public event Action<BuildingState> OnBuildingStateChanged
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

		private void OnEnable()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public virtual void SetBuildingState(BuildingState state)
		{
		}

		public void SetLevelIndicatorVisible(bool visible)
		{
		}

		public void SetGameplayInventorySystem(GameplayInventorySystem gameplayInventorySystem)
		{
		}

		public void SetBuildingRepository(BuildingRepository buildingRepository)
		{
		}

		public virtual void OnBuildingPlaced(BuildingSlot buildingSlot, bool isRestore = false)
		{
		}

		public virtual void IncreaseLevel()
		{
		}

		public void Restore()
		{
		}

		public void TakeDamage(Damage damage)
		{
		}

		public Transform GetTransform()
		{
			return null;
		}

		public Vector3 GetDamagePosition(Vector3 sourcePosition)
		{
			return default(Vector3);
		}

		public bool CanTakeDamage()
		{
			return false;
		}

		public bool CanBeTargeted()
		{
			return false;
		}

		public virtual void DespawnUnits()
		{
		}

		public virtual void UpdateSkinForPlacement(BaseBuildingData selectedBuildingData, bool isInteractable, int emptyNeighborCount)
		{
		}

		public virtual void SetSkinActiveState(bool isActive)
		{
		}

		protected void Construct(BaseBuildingData baseBuildingData, BuildingRuntime buildingRuntime)
		{
		}

		protected void Construct(BaseBuildingData baseBuildingData, BuildingRuntime buildingRuntime, float overrideHealthPoints)
		{
		}

		protected void InitializeStatChangeDisplay()
		{
		}

		protected void SetHealthIndicatorEnabled(bool enabled)
		{
		}

		protected void ShowPopAnimation()
		{
		}

		private void InitializeHealthPoints()
		{
		}

		private void OnHealthStatChanged(StatValue stat)
		{
		}

		private void InitializeUIComponents()
		{
		}

		private void DestroyBuilding()
		{
		}

		private void ShowSpawnAnimation()
		{
		}

		private void LinkUIComponents()
		{
		}

		private void TestDestroyBuilding()
		{
		}
	}
}
