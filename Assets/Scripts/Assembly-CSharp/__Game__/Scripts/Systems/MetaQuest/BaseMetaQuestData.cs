using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public abstract class BaseMetaQuestData : ScriptableObject
	{
		[SerializeField]
		private string _guid;

		[SerializeField]
		private string _description;

		[SerializeField]
		private List<RewardData> _rewards;

		public string Guid => null;

		public string Description => null;

		public List<RewardData> Rewards => null;
	}
}
