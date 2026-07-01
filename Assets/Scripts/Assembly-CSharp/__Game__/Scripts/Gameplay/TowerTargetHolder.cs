using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public class TowerTargetHolder : BaseTargetHolder
	{
		public TowerTargetHolder(Transform towerTransform, UnitRepository enemyRepository, StatValue attackRange)
			: base(null, null, null, null)
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
