using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Player_Multiply", menuName = "TapHub/Stats/Modifiers/Player Multiply Stat")]
	public class PlayerMultiplyStatModifier : BaseModifier
	{
		[SerializeField]
		private PlayerStatType _playerStatType;

		[SerializeField]
		private float _percent;

		public override void Apply(StaticStatSystem staticStatSystem)
		{
		}

		public override string GetDescription()
		{
			return null;
		}

		public PlayerStatType GetPlayerStatType()
		{
			return default(PlayerStatType);
		}

		public float GetPercent()
		{
			return 0f;
		}
	}
}
