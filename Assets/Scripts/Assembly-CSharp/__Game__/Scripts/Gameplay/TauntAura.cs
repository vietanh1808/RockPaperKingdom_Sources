using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class TauntAura : AbilityObjectComponent
	{
		private readonly Dictionary<BaseUnit, Action> _tauntedUnits;

		private AbilityObject _abilityObject;

		private UnitData _priorityUnitData;

		private Transform _followTransform;

		public override void ReadyToUse(AbilityObject abilityObject)
		{
		}

		private void Update()
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerExit(Collider other)
		{
		}

		private void OnTauntedUnitDied(BaseUnit deadUnit)
		{
		}

		private void OnAbilityDeactivated()
		{
		}

		private void AddTauntedUnit(BaseUnit targetUnit)
		{
		}

		private void RemoveTauntedUnit(BaseUnit targetUnit)
		{
		}
	}
}
