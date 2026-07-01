using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class SlotGridSpawnPositions
	{
		[SerializeField]
		private List<Vector3> _positions;

		public List<Vector3> Positions => null;

		public SlotGridSpawnPositions(List<Vector3> positions)
		{
		}
	}
}
