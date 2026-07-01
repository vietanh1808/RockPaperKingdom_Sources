using System;
using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __BattleSimulation__.Scripts
{
	[Serializable]
	public class UnitBattleSimulationData
	{
		[SerializeField]
		private string _title;

		[SerializeField]
		private UnitData _attackerUnitData;

		[SerializeField]
		private UnitData _defenderUnitData;

		public string Title => null;

		public UnitData Attacker => null;

		public UnitData Defender => null;
	}
}
