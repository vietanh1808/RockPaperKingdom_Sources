using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.EnemyHint
{
	[CreateAssetMenu(fileName = "Config_EnemyHint", menuName = "TapHub/Configs/Enemy Hint Config")]
	public class EnemyHintConfig : ScriptableObject
	{
		[SerializeField]
		private List<EnemyHintEntry> _entries;

		public bool TryGetEntry(string unitDataGuid, out EnemyHintEntry entry)
		{
			entry = null;
			return false;
		}
	}
}
