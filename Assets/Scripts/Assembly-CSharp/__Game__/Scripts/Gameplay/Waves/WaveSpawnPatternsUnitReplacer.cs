using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class WaveSpawnPatternsUnitReplacer : SerializedMonoBehaviour
	{
		[SerializeField]
		private Dictionary<UnitData, UnitData> _unitDataReplacements;

		private bool IsEditMode => false;
	}
}
