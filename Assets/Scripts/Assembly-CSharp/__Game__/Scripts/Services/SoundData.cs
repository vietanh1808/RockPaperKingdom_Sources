using UnityEngine;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "SoundData", menuName = "TapHub/Audio/Sound Data")]
	public class SoundData : ScriptableObject
	{
		[SerializeField]
		private AudioClip _audioClip;

		[SerializeField]
		private float _volume;

		public AudioClip AudioClip => null;

		public float Volume => 0f;
	}
}
