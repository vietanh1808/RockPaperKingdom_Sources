using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	[CreateAssetMenu(fileName = "Config_Waves", menuName = "TapHub/Stage/Waves Config")]
	public class WavesConfig : ScriptableObject
	{
		[SerializeField]
		private AlertData _defaultAlert;

		[SerializeField]
		private AlertData _bossAlert;

		public AlertData BossAlert => null;
	}
}
