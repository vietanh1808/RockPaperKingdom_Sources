using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UnitEmptyNeighborScaler : MonoBehaviour
	{
		[SerializeField]
		private float _scalePerEmptyCell;

		[SerializeField]
		private Transform _scaleTarget;

		private BaseUnit _unit;

		private EmptyNeighborBonusTracker _tracker;

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

		private void UpdateScale(int emptyCount)
		{
		}
	}
}
