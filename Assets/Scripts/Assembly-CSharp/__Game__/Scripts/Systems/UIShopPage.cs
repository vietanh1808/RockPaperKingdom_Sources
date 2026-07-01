using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Services.Analytics;

namespace __Game__.Scripts.Systems
{
	public class UIShopPage : MonoBehaviour
	{
		[SerializeField]
		private ScrollRect _scrollRect;

		private LionAnalyticsEvents _lionAnalyticsEvents;

		public event Action OnShopEnabled
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

		[Inject]
		private void Inject(LionAnalyticsEvents lionAnalyticsEvents)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Open(float targetPosition, bool isScrollToPosition)
		{
		}
	}
}
