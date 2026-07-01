using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitAdjacentUnitsScaler : MonoBehaviour
	{
		[SerializeField]
		private float _scalePerAdjacentUnit;

		[SerializeField]
		private float _maxScale;

		[SerializeField]
		private Transform _scaleTarget;

		private BaseUnit _unit;

		private AdjacentUnitsCountBonusTracker _tracker;

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

		private void UpdateScale(int unitsCount)
		{
		}
	}
}
