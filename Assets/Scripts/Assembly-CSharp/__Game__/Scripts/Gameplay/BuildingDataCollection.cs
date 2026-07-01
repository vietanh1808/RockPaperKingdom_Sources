using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "Collection_BuildingData", menuName = "TapHub/Buildings/Building Data Collection")]
	public class BuildingDataCollection : ScriptableObject
	{
		[SerializeField]
		private string _folderPath;

		[SerializeField]
		private List<BaseBuildingData> _buildingDataList;

		private Dictionary<string, BaseBuildingData> _guidToData;

		public IReadOnlyList<BaseBuildingData> BuildingDataList => null;

		public void Initialize()
		{
		}

		public BaseBuildingData GetByGuid(string guid)
		{
			return null;
		}
	}
}
