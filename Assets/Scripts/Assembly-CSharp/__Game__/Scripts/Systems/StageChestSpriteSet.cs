using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class StageChestSpriteSet
	{
		[SerializeField]
		private Sprite _lockedSprite;

		[SerializeField]
		private Sprite _unlockedSprite;

		[SerializeField]
		private Sprite _claimedSprite;

		public Sprite LockedSprite => null;

		public Sprite UnlockedSprite => null;

		public Sprite ClaimedSprite => null;
	}
}
