using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class RangeUnitTargetHolder : BaseUnitTargetHolder
	{
		private bool _isMeleeDamageReceived;

		public RangeUnitTargetHolder(BaseUnit unit, UnitRepository enemyRepository)
			: base(null, null)
		{
		}

		private void OnDamageReceived(Damage damage)
		{
		}

		public override void Update()
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

		private bool CanUpdate()
		{
			return false;
		}
	}
}
