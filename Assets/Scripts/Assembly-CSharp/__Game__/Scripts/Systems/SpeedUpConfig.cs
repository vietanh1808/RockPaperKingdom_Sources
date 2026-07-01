using UnityEngine;
using __Game__.Scripts.Common;

namespace __Game__.Scripts.Systems
{
	[CreateAssetMenu(fileName = "Config_SpeedUp", menuName = "TapHub/Configs/Speed Up")]
	public class SpeedUpConfig : ScriptableObject
	{
		[SerializeField]
		private float _acceleratedTimeScale;

		[SerializeField]
		private TimeData _cooldownTime;

		public float AcceleratedTimeScale => 0f;

		public TimeData CooldownTime => default(TimeData);
	}
}
