using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UISpeedUpGameplaySwitcher : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _switcherButtonClick;

		[SerializeField]
		private TMP_Text _timeScaleText;

		[Header("Image Settings")]
		[SerializeField]
		private Image _defaultSpeedImage;

		[SerializeField]
		private Image _acceleratedSpeedImage;

		[SerializeField]
		[Range(0f, 1f)]
		private float _inactiveImageAlpha;

		private SpeedUpGameplaySystem _speedUpGameplaySystem;

		[Inject]
		private void Inject(SpeedUpGameplaySystem speedUpGameplaySystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshView()
		{
		}

		private void UpdateText()
		{
		}

		private void UpdateImagesAlpha()
		{
		}

		private void SetImageAlpha(Image image, float alpha)
		{
		}

		private void OnSwitcherButtonClicked()
		{
		}
	}
}
