using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.AIStageGeneration
{
	[Serializable]
	public class AIUnitConfig
	{
		[SerializeField]
		private List<UnitData> _regularUnits;

		[SerializeField]
		private List<UnitData> _miniBosses;

		[SerializeField]
		private List<UnitData> _bosses;

		[NonSerialized]
		private Dictionary<string, UnitData> _unitLookup;

		[NonSerialized]
		private bool _isLookupValid;

		public List<UnitData> RegularUnits => null;

		public List<UnitData> MiniBosses => null;

		public List<UnitData> Bosses => null;

		public List<UnitData> GetAllUnits()
		{
			return null;
		}

		public UnitData GetUnitByGuid(string guid)
		{
			return null;
		}

		public List<UnitData> GetUnitsByCategory(EnemyCategory category)
		{
			return null;
		}

		private void EnsureLookupCache()
		{
		}

		private void BuildLookupCache()
		{
		}

		public void SetUnits(List<UnitData> regularUnits, List<UnitData> miniBosses, List<UnitData> bosses)
		{
		}

		private void InvalidateLookupCache()
		{
		}
	}
}
