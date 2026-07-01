using System.Collections.Generic;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems;
using __Simulation__.Systems.UnitsGraph;

namespace __Simulation__.Systems.UnitCardGraph
{
	public class UISimulationUnitCardUpgradeSnapshot : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _snapshotContainer;

		[SerializeField]
		private TMP_Text _averageLevelText;

		[SerializeField]
		private UISimulationHeroUpgradeItem _unitCardItemPrefab;

		public void Construct(SimulationSnapshot simulationSnapshot, Dictionary<string, int> cardOrder)
		{
		}

		private static int GetOrder(UnitCardItem card, Dictionary<string, int> cardOrder)
		{
			return 0;
		}

		private static List<UnitCardItem> CollectUnlockedCards(List<UnitCardItem> unitCardItems)
		{
			return null;
		}
	}
}
