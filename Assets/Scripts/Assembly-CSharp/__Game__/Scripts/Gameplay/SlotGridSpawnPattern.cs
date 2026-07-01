using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class SlotGridSpawnPattern : MonoBehaviour
	{
		[SerializeField]
		private List<Transform> _spawnPoints;

		public List<Vector3> GetSpawnPoints()
		{
			return null;
		}

		public Vector3 GetPointPosition(int index)
		{
			return default(Vector3);
		}
	}
}
