using TMPro;
using UnityEngine;
using UnityEngine.UI;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay
{
	public class UIFortuneWheelResultElement : MonoBehaviour
	{
		[SerializeField]
		private Transform _container;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TMP_Text _title;

		[SerializeField]
		private TMP_Text _description;

		[Header("Audio")]
		[SerializeField]
		private SoundData _appearSound;

		private float _appearDelay;

		private void OnEnable()
		{
		}

		public void Construct(FortuneWheelItem fortuneWheelItem, float appearDelay)
		{
		}

		private void SetItem(FortuneWheelItem fortuneWheelItem)
		{
		}

		private void AppearAnimate()
		{
		}

		private void PlayAppearSound()
		{
		}
	}
}
