using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIPowerChangeFloating : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private TMP_Text _powerValue;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private Image _arrowImage;

		[Header("Arrow Sprites")]
		[SerializeField]
		private Sprite _arrowUpSprite;

		[SerializeField]
		private Sprite _arrowDownSprite;

		[Header("Delays")]
		[SerializeField]
		private float _appearDelay;

		[SerializeField]
		private float _countDelay;

		[Header("Durations")]
		[SerializeField]
		private float _fadeInDuration;

		[SerializeField]
		private float _countDuration;

		[SerializeField]
		private float _displayDuration;

		[SerializeField]
		private float _fadeOutDuration;

		private PlayerPowerSystem _playerPowerSystem;

		private Sequence _animationSequence;

		[Inject]
		private void Inject(PlayerPowerSystem playerPowerSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnPowerChanged(int oldPower, int newPower)
		{
		}

		private void PlayAnimation(int oldPower, int newPower)
		{
		}

		private void KillAnimation()
		{
		}

		private void SetCanvasGroupActive(bool active)
		{
		}
	}
}
