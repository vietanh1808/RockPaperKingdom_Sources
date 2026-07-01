using System;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.StakeToken
{
	[Serializable]
	public class WaveStakeTokenDropModel
	{
		[Range(0f, 1f)]
		[SerializeField]
		private float _dropChance;

		[SerializeField]
		private int _minTokenAmount;

		[SerializeField]
		private int _maxTokenAmount;

		[SerializeField]
		private int _minimumTotalTokens;

		[SerializeField]
		private int _maximumTotalTokens;

		public float DropChance => 0f;

		public int MinTokenAmount => 0;

		public int MaxTokenAmount => 0;

		public int MinimumTotalTokens => 0;

		public int MaximumTotalTokens => 0;

		public int GetRandomTokenAmount()
		{
			return 0;
		}
	}
}
