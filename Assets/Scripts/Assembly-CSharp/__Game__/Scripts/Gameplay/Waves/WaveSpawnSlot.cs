using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSpawnSlot : MonoBehaviour
	{
		[SerializeField]
		private UnitData _unitData;

		[Range(1f, 16f)]
		[SerializeField]
		private int _unitsAmount;

		[HideInInspector]
		[SerializeField]
		private SlotGridSpawnPatternsSettings _spawnPatternsSettings;

		[HideInInspector]
		[SerializeField]
		private bool _showPreviewUnits;

		public UnitData UnitData => null;

		public int UnitsAmount => 0;

		public Vector3 WorldPosition => default(Vector3);

		public void ShowPreviewUnits(SlotGridSpawnPatternsSettings spawnPatternsSettings)
		{
		}

		public void HidePreviewUnits()
		{
		}

		private void ClearAllUnits()
		{
		}

		private void CreateAllUnits()
		{
		}

		private Vector3 GetSpawnPosition(List<Vector3> spawnPoints, Vector3 slotPosition, int spawnIndex)
		{
			return default(Vector3);
		}
	}
}
