using UnityEngine;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Systems;

namespace __Simulation__.Systems._Upgrades
{
	[CreateAssetMenu(fileName = "Config_UpgradeStrategyGenerator", menuName = "TapHub/UpgradesSimulation/Upgrade Strategy Generator Config")]
	public class UpgradeStrategyGeneratorConfig : ScriptableObject
	{
		[TextArea(10, 20)]
		[SerializeField]
		private string _csvData;

		[SerializeField]
		private StageData _stageData;

		[SerializeField]
		private BuildingPlacementConfig _buildingPlacementConfig;

		[SerializeField]
		private int _amountToGenerate;

		[SerializeField]
		private string _outputFolderPath;
	}
}
