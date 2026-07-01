using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitGridBuildingScaler : MonoBehaviour
	{
		[SerializeField]
		private float _scalePerBuilding;

		[SerializeField]
		private float _maxScale;

		[SerializeField]
		private Transform _scaleTarget;

		private BaseUnit _unit;

		private GlobalBuildingCountBonusTracker _tracker;

		private float _baseScale;

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
