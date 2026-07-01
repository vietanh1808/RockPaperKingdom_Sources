using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Services
{
	public class AudioService : MonoBehaviour
	{
		[SerializeField]
		private float _musicFadeOutDuration;

		[SerializeField]
		private float _musicFadeInDuration;

		[Header("Sources")]
		[SerializeField]
		private AudioSource _sfxSource;

		[SerializeField]
		private AudioSource _musicSource;

		private const float SFX_COOLDOWN_SECONDS = 0.1f;

		private static AudioService _instance;

		private static SoundData _currentMusicData;

		private readonly Dictionary<int, float> _lastSfxPlayTimeByAssetId;

		private SettingService _settingService;

		[Inject]
		private void Inject(SettingService settingService)
		{
		}

		private void Awake()
		{
		}

		public static void PlaySfx(SoundBundleData soundBundleData)
		{
		}

		public static void PlaySfx(SoundData soundData)
		{
		}

		public static void PlayMusic(SoundData soundData)
		{
		}

		public static void StopMusic()
		{
		}

		public static SoundData GetCurrentMusicSoundData()
		{
			return null;
		}

		private void SubscribeToSettings()
		{
		}

		private void ApplySfxSettings()
		{
		}

		private void ApplyMusicSettings()
		{
		}

		private bool IsSfxOnCooldown(Object assetKey)
		{
			return false;
		}

		private void PlaySfxOneShot(AudioClip clip, float volume)
		{
		}

		private void PlayMusicInternal(SoundData soundData)
		{
		}

		private void StopMusicInternal()
		{
		}

		private void PlayMusicWithFade(SoundData soundData)
		{
		}
	}
}
