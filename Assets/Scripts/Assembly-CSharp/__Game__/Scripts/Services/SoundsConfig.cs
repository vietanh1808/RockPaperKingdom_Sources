using Sirenix.OdinInspector;
using UnityEngine;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "Config_Sounds", menuName = "TapHub/Audio/Sounds Config")]
	public class SoundsConfig : SerializedScriptableObject
	{
		[Header("Sounds")]
		[SerializeField]
		private SoundData _floatingReward;

		[Header("Musics")]
		[SerializeField]
		private SoundData _menuMusic;

		[SerializeField]
		private SoundData _gameMusic;

		[SerializeField]
		private SoundData _bossFightMusic;

		public SoundData FloatingReward => null;

		public SoundData MenuMusic => null;

		public SoundData GameMusic => null;

		public SoundData BossFightMusic => null;
	}
}
