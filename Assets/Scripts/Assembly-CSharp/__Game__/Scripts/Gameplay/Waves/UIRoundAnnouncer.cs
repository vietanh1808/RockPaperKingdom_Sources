using DG.Tweening;
using TMPro;
using UnityEngine;

namespace __Game__.Scripts.Gameplay.Waves
{
	public class UIRoundAnnouncer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _rootContainer;

		[SerializeField]
		private TMP_Text _roundText;

		[SerializeField]
		private CanvasGroup _canvasGroup;

		private const float ANIMATION_DURATION = 0.5f;

		private const float DISPLAY_DURATION = 2f;

		private Sequence _animationSequence;

		private Tween _hideDelayTween;

		private void OnDisable()
		{
		}

		public void ShowRoundAnnouncement(int roundNumber)
		{
		}

		private void HideAnnouncement()
		{
		}
	}
}
