using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitAdjacentBuildingScaler : MonoBehaviour
	{
		[SerializeField]
		private float _scalePerAdjacentBuilding;

		[SerializeField]
		private float _maxScale;

		[SerializeField]
		private Transform _scaleTarget;

		private BaseUnit _unit;

		private AdjacentBuildingBonusTracker _tracker;

		private float _baseScale;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		private void Unsubscribe()
		{
		}

		private void UpdateScale(int buildingCount)
		{
		}
	}
}
