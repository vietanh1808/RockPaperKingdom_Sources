using System;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	[Serializable]
	public class GameplayDebugUnitSettings
	{
		[SerializeField]
		private HeroItemData _unitCollectibleData;

		[SerializeField]
		private int _level;

		[HideInInspector]
		[SerializeField]
		private bool _showLevel;

		public HeroItemData UnitCollectibleData => null;

		public int Level => 0;

		public void SetShowLevel(bool showLevel)
		{
		}
	}
}
