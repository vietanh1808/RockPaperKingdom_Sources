using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "SoundBundleData", menuName = "TapHub/Audio/Sound Bundle Data")]
	public class SoundBundleData : ScriptableObject
	{
		[SerializeField]
		private float _volume;

		[SerializeField]
		private List<AudioClip> _clips;

		public float Volume => 0f;

		public AudioClip GetRandomClip()
		{
			return null;
		}
	}
}
