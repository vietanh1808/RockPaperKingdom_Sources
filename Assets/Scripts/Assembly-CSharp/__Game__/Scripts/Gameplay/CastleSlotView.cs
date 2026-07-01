using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class CastleSlotView : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		private BuildingPlacementSystem _buildingPlacementSystem;

		[Inject]
		private void Inject(BuildingPlacementSystem buildingPlacementSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnCastlePlaced()
		{
		}
	}
}
