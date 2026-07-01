using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __BattleSimulation__.Scripts
{
	[CreateAssetMenu(fileName = "Config_BattleSimulation", menuName = "TapHub/BattleSimulation/BattleSimulationConfig")]
	public class BattleSimulationConfig : SerializedScriptableObject
	{
		[SerializeField]
		private List<UnitBattleSimulationData> _units;

		public List<UnitBattleSimulationData> Units => null;
	}
}
