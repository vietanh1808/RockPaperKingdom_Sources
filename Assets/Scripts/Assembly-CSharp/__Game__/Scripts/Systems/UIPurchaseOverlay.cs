using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIPurchaseOverlay : MonoBehaviour
	{
		[SerializeField]
		private float _fadeOutDelay;

		[SerializeField]
		private float _fadeDuration;

		[SerializeField]
		private CanvasGroup _rootContainer;

		[SerializeField]
		private GameObject _loadingContainer;

		[SerializeField]
		private GameObject _successContainer;

		[SerializeField]
		private GameObject _failureContainer;

		public event Action OnPurchaseDisplayed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ShowLoading()
		{
		}

		public void Show(bool status)
		{
		}

		private void FadeOutCanvasGroup(GameObject resultContainer)
		{
		}
	}
}
