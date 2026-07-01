using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[CreateAssetMenu(fileName = "TowerData_", menuName = "TapHub/Data/Tower Data")]
	public class TowerData : SerializedScriptableObject
	{
		[SerializeField]
		private string _title;

		[SerializeField]
		private AbilityData _mainAbility;

		[SerializeField]
		private Dictionary<UnitStatType, float> _stats;

		public string Title => null;

		public AbilityData MainAbility => null;

		public Dictionary<UnitStatType, float> Stats => null;
	}
}
