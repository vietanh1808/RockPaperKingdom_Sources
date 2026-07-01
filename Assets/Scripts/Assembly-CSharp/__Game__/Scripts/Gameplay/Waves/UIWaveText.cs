using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class UIWaveText : MonoBehaviour
	{
		private const int PREVIEW_ELEMENTS_COUNT = 4;

		private const int UPCOMING_WAVES_COUNT = 3;

		[SerializeField]
		private TMP_Text _waveText;

		[SerializeField]
		private Image _waveTypeIcon;

		[SerializeField]
		private Sprite _regularSprite;

		[SerializeField]
		private Sprite _hardSprite;

		[SerializeField]
		private Sprite _bossSprite;

		[Header("Wave Preview Popup")]
		[SerializeField]
		private GameObject _wavePreviewPopup;

		[SerializeField]
		private UIWavePreviewElement[] _wavePreviewElements;

		[SerializeField]
		private UIButtonClick _toggleButton;

		private WaveSystem _waveSystem;

		[Inject]
		private void Inject(WaveSystem waveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateWaveDisplay()
		{
		}

		private void UpdateWaveTypeIcon()
		{
		}

		private void TogglePreviewPopup()
		{
		}

		private void UpdatePreviewPopup()
		{
		}

		private Sprite GetSpriteForDifficulty(WaveDifficulty difficulty)
		{
			return null;
		}

		private string GetLabelForWave(int waveIndex, WaveDifficulty difficulty)
		{
			return null;
		}
	}
}
