using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Arena.Enemy
{
	public class EnemyBuildingSlotGridView : MonoBehaviour
	{
		[SerializeField]
		private List<EnemyBuildingSlotView> _slotViews;

		public void Initialize(BuildingSlotGrid enemyGrid)
		{
		}
	}
}
