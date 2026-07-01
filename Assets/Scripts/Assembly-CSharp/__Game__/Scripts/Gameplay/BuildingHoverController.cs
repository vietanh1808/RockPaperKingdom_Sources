using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class BuildingHoverController : MonoBehaviour
	{
		[SerializeField]
		private LayerMask _raycastLayerMask;

		private Camera _camera;

		private BuildingPlacementHand _placementHand;

		private GridExpandSystem _gridExpandSystem;

		private bool _isInputDown;

		public BaseBuilding HoveredBuilding { get; private set; }

		public event Action OnHoverStateChanged
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
		public void Inject(Camera camera, BuildingPlacementHand placementHand, GridExpandSystem gridExpandSystem)
		{
		}

		private void Update()
		{
		}

		private bool ShouldProcess()
		{
			return false;
		}

		private void HandleInput()
		{
		}

		private void TryDetectBuilding()
		{
		}

		private void SetHoveredBuilding(BaseBuilding building)
		{
		}

		private void ClearHoveredBuilding()
		{
		}
	}
}
