using System.Collections.Generic;
using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems.UnitsGraph
{
	public class UISimulationHeroUpgradeSnapshot : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _snapshotContainer;

		[SerializeField]
		private TMP_Text _unitsUpgradePowerText;

		[SerializeField]
		private UISimulationHeroUpgradeItem _uiSimulationHeroUpgradePrefab;

		public void Construct(SimulationSnapshot simulationSnapshot, HeroConfig heroConfig)
		{
		}

		private static Dictionary<string, HeroItem> BuildHeroesByGuid(List<HeroItem> heroItems)
		{
			return null;
		}
	}
}
