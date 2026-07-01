using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.EnemyHint
{
	[Serializable]
	public class EnemyHintEntry
	{
		[SerializeField]
		private UnitData _unitData;

		[TextArea(3, 6)]
		[SerializeField]
		private string _hintDescription;

		public UnitData UnitData => null;

		public string HintDescription => null;
	}
}
