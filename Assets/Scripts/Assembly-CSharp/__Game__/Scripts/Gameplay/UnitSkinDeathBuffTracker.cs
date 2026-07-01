using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	[RequireComponent(typeof(Skin2D))]
	public class UnitSkinDeathBuffTracker : MonoBehaviour
	{
		[SerializeField]
		private Sprite _skinSprite;

		[SerializeField]
		private List<Sprite> _defaultSprites;

		[SerializeField]
		private List<Sprite> _overrideSprites;
	}
}
