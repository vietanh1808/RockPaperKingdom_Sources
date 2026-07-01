using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class AvoidPassiveMeleeTargetHolder : BaseUnitTargetHolder
	{
		public AvoidPassiveMeleeTargetHolder(BaseUnit unit, UnitRepository enemyRepository)
			: base(null, null)
		{
		}

		protected override BaseUnit FindPriorityTarget(Vector3 position, float range, List<UnitData> priorityOrder)
		{
			return null;
		}

		protected override BaseUnit FindDefaultTarget(Vector3 position, float range)
		{
			return null;
		}
	}
}
