using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_PlayerStat", menuName = "TapHub/Configs/Player Stat")]
	public class PlayerStatConfig : SerializedScriptableObject
	{
		[SerializeField]
		private Dictionary<PlayerStatType, float> _stats;

		public Dictionary<PlayerStatType, float> Stats => null;
	}
}
