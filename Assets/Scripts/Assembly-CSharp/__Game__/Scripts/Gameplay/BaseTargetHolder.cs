using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Gameplay
{
	public abstract class BaseTargetHolder
	{
		private IDamageable _currentTarget;

		protected Transform OwnerTransform { get; }

		protected StatValue AgroRange { get; }

		protected UnitRepository EnemyRepository { get; }

		public IDamageable CurrentTarget
		{
			get
			{
				return null;
			}
			protected set
			{
			}
		}

		public UnitPriorityOrder UnitPriorityOrder { get; }

		public bool IsForcedTarget { get; private set; }

		protected bool IsPriorityTarget { get; set; }

		public event Action OnTargetChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected BaseTargetHolder(Transform ownerTransform, UnitRepository enemyRepository, StatValue agroRange, UnitPriorityOrder unitPriorityOrder)
		{
		}

		public virtual void Update()
		{
		}

		public void Reset()
		{
		}

		public void SetForcedTarget(IDamageable forcedTarget)
		{
		}

		protected abstract BaseUnit FindPriorityTarget(Vector3 position, float range, List<UnitData> priorityOrder);

		protected abstract BaseUnit FindDefaultTarget(Vector3 position, float range);

		private void SubscribeToTarget()
		{
		}

		private void UnsubscribeFromTarget()
		{
		}

		private void OnTargetDied()
		{
		}
	}
}
