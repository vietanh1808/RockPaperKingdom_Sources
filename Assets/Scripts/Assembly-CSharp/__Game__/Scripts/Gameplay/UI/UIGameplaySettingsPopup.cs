using UnityEngine;
using Zenject;
using __Game__.Scripts.Services;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.UI
{
	public class UIGameplaySettingsPopup : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _closeButton;

		[SerializeField]
		private UIButtonClick _quitButton;

		[SerializeField]
		private UIConfirmationPopup _uiConfirmationPopup;

		[Header("Settings Switchers")]
		[SerializeField]
		private UIButtonClickSwitch _soundSwitcher;

		[SerializeField]
		private UIButtonClickSwitch _musicSwitcher;

		[SerializeField]
		private UIButtonClickSwitch _vibrationSwitcher;

		private SettingService _settingService;

		private ISurrenderHandler _surrenderHandler;

		[Inject]
		public void Inject(SettingService settingService, ISurrenderHandler surrenderHandler)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void OnSoundSwitchChanged(bool isOn)
		{
		}

		private void OnMusicSwitchChanged(bool isOn)
		{
		}

		private void OnVibrationSwitchChanged(bool isOn)
		{
		}

		private void OnQuitButtonClicked()
		{
		}

		private void Quit()
		{
		}

		private void Close()
		{
		}
	}
}
