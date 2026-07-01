using AssetKits.ParticleImage;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class UIFortuneWheelElement : MonoBehaviour
	{
		[SerializeField]
		private Image _icon;

		[Header("Focus")]
		[SerializeField]
		private ParticleImage _focusEffect;

		[SerializeField]
		private CanvasGroup _focusMark;

		[Header("Selected")]
		[SerializeField]
		private ParticleImage _selectedEffect;

		[SerializeField]
		private RectTransform _selectedMark;

		[Header("Audio")]
		[SerializeField]
		private SoundData[] _selectSounds;

		public bool IsSelected { get; private set; }

		public void RefreshView(FortuneWheelItem fortuneWheelItem)
		{
		}

		public void ShowSelectedMark(int index)
		{
		}

		public void ShowFocusMark(float duration = 0.35f)
		{
		}
	}
}
