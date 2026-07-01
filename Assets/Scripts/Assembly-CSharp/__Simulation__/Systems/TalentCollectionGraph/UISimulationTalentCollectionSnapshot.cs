using System.Collections.Generic;
using UnityEngine;

namespace __Simulation__.Systems.TalentCollectionGraph
{
	public class UISimulationTalentCollectionSnapshot : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _snapshotContainer;

		[SerializeField]
		private UISimulationTalentItem _uiSimulationTalentItemPrefab;

		public void Construct(SimulationSnapshot simulationSnapshot, Dictionary<string, int> talentOrder)
		{
		}

		private static int GetOrder(TalentItemSnapshot talent, Dictionary<string, int> talentOrder)
		{
			return 0;
		}

		private static List<TalentItemSnapshot> CollectUnlockedTalents(List<TalentItemSnapshot> talents)
		{
			return null;
		}
	}
}
