using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class UnitPriorityOrder
	{
		private readonly List<UnitData> _defaultPriorityOrder;

		private readonly List<UnitData> _extraPriorityOrder;

		private readonly Dictionary<UnitData, int> _extraPriorityCount;

		public List<UnitData> PriorityOrder { get; }

		public UnitPriorityOrder(List<UnitData> basePriorityOrder)
		{
		}

		public void AddPriorityTarget(UnitData priorityTarget)
		{
		}

		public void RemovePriorityTarget(UnitData priorityTarget)
		{
		}

		private void UpdatePriorityOrder()
		{
		}
	}
}
