using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Simulation__.SimulationModules
{
	[CreateAssetMenu(fileName = "Config_OpenChest", menuName = "Game Simulation/Open Chest Config")]
	public class OpenChestModuleConfig : ScriptableObject
	{
		[SerializeField]
		private List<ChestData> _chests;

		public List<ChestData> Chests => null;
	}
}
