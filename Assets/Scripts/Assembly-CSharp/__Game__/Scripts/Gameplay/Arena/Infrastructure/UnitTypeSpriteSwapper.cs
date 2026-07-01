using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Arena.Infrastructure
{
	public class UnitTypeSpriteSwapper : MonoBehaviour
	{
		[SerializeField]
		private List<SpriteRenderer> _spriteRenderers;

		[SerializeField]
		private List<Sprite> _playerSprites;

		[SerializeField]
		private List<Sprite> _enemySprites;

		public void SetSide(UnitType side)
		{
		}
	}
}
