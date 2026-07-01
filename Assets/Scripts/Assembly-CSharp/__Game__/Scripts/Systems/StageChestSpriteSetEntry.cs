using System;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[Serializable]
	public class StageChestSpriteSetEntry
	{
		[SerializeField]
		private StageChestType _chestType;

		[SerializeField]
		private StageChestSpriteSet _spriteSet;

		public StageChestType ChestType => default(StageChestType);

		public StageChestSpriteSet SpriteSet => null;
	}
}
