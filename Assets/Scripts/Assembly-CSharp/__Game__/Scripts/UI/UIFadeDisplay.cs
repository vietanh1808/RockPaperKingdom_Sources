using System;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UIFadeDisplay : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _curtain;

		[SerializeField]
		private float _fadeInDuration;

		[SerializeField]
		private float _fadeOutDuration;

		public void Show()
		{
		}

		public void FadeIn(Action onComplete)
		{
		}

		public void FadeOut()
		{
		}
	}
}
