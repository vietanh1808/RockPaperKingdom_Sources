using System.Collections.Generic;
using UnityEngine;
using __Game__.Scripts.Systems.Data;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_PlayerLevelUp", menuName = "TapHub/Player/Level Up Config")]
	public class PlayerLevelUpConfig : ScriptableObject
	{
		[SerializeField]
		private List<PlayerLevelUpData> _levelUpDataByLevel;

		public PlayerLevelUpData GetDataByLevel(int level)
		{
			return null;
		}
	}
}
