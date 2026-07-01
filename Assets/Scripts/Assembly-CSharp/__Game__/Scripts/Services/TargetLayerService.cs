using UnityEngine;
using __Game__.Scripts.Gameplay;

namespace __Game__.Scripts.Services
{
	public class TargetLayerService
	{
		private static readonly LayerMask ENEMY_UNIT_MASK;

		private static readonly LayerMask PLAYER_UNIT_MASK;

		private static readonly LayerMask ALL_UNITS_MASK;

		public static LayerMask GetEnemyLayerMask(UnitType unitType)
		{
			return default(LayerMask);
		}
	}
}
