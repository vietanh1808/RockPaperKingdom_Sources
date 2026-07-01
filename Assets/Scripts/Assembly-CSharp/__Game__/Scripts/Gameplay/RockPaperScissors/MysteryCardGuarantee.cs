using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.RockPaperScissors
{
	[Serializable]
	public class MysteryCardGuarantee
	{
		[SerializeField]
		private int _byWaveIndex;

		[SerializeField]
		private int _minimumCards;

		public int ByWaveIndex => 0;

		public int MinimumCards => 0;
	}
}
