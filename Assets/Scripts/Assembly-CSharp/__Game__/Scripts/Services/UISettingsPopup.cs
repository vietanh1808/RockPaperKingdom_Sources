using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Services
{
	public class UISettingsPopup : MonoBehaviour
	{
		[SerializeField]
		private GameObject _rootContainer;

		[SerializeField]
		private UIButtonClick _closeButton;

		[Header("Settings Buttons")]
		[SerializeField]
		private UIButtonClick _soundButton;

		[SerializeField]
		private UIButtonClick _musicButton;

		[SerializeField]
		private UIButtonClick _vibrationButton;

		[Header("Settings Marks")]
		[SerializeField]
		private GameObject _soundOnMark;

		[SerializeField]
		private GameObject _musicOnMark;

		[SerializeField]
		private GameObject _vibrationOnMark;

		private SettingService _settingService;

		[Inject]
		public void Inject(SettingService settingService)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open()
		{
		}

		private void OnSoundSwitchClicked()
		{
		}

		private void OnMusicSwitchClicked()
		{
		}

		private void OnVibrationSwitchClicked()
		{
		}

		private void Close()
		{
		}
	}
}
