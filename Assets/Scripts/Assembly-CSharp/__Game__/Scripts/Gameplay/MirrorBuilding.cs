using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class MirrorBuilding : BaseBuilding
	{
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		[Header("Sounds")]
		[SerializeField]
		private SoundData _mirrorSound;

		private const float FLASH_PEAK_VALUE = 0.8f;

		private const float FLASH_IN_DURATION = 0.15f;

		private Sequence _flashSequence;

		private BuildingUnitsHolder _unitsHolder;

		private BuildingSlotGrid _buildingSlotGrid;

		public MirrorBuildingData MirrorBuildingData { get; private set; }

		public BuildingUnitsHolder UnitsHolder => null;

		public override bool HasSpawnableUnits => false;

		public bool HasClonedUnits => false;

		public void Construct(MirrorBuildingData buildingData, BuildingRuntime buildingRuntime, BuildingUnitSpawner unitSpawner, BuildingSlotGrid buildingSlotGrid)
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void SetBuildingState(BuildingState state)
		{
		}

		public bool ProcessMirror()
		{
			return false;
		}

		public void DespawnMirrorUnits()
		{
		}

		public override void DespawnUnits()
		{
		}

		private void SetBuildingVisible(bool visible)
		{
		}

		private void CopyUnitsFromSource(BaseBuilding source)
		{
		}

		private List<BaseBuilding> GetNeighborBuildingsWithUnits()
		{
			return null;
		}

		private void PlayVisualEffects(TweenCallback onFlashPeak)
		{
		}

		public override void UpdateSkinForPlacement(BaseBuildingData selectedBuildingData, bool isInteractable, int emptyNeighborCount)
		{
		}

		public override void SetSkinActiveState(bool isActive)
		{
		}

		private void ActivateSecondaryAbilities()
		{
		}

		private void DeactivateSecondaryAbilities()
		{
		}

		private void Flash(TweenCallback onFlashPeak)
		{
		}
	}
}
