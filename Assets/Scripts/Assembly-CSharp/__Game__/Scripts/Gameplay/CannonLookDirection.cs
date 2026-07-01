using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class CannonLookDirection : MonoBehaviour
	{
		[SerializeField]
		private TowerBuilding _towerBuilding;

		[SerializeField]
		private float _rotationSpeed;

		private Quaternion _initialRotation;

		private BuildingState _currentBuildingState;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void RotateToTarget()
		{
		}

		private void ReturnToInitialRotation()
		{
		}

		private void OnBuildingStateChanged(BuildingState state)
		{
		}
	}
}
