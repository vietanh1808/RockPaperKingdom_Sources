using UnityEngine;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "StatModifier_Player_Add", menuName = "TapHub/Stats/Modifiers/Player Add Stat")]
	public class PlayerAddStatModifier : BaseModifier
	{
		[SerializeField]
		private PlayerStatType _playerStatType;

		[SerializeField]
		private float _value;

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

		public float GetValue()
		{
			return 0f;
		}
	}
}
