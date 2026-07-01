using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.UI
{
	public class UINavigationController : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootContainer;

		[SerializeField]
		private UINavigationButton _default;

		[SerializeField]
		private UINavigationButton _arena;

		[SerializeField]
		private List<UINavigationButton> _navigations;

		private UINavigationButton _previousNavigationButton;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void FocusPageByIndex(int page)
		{
		}

		public void FocusArenaPage()
		{
		}

		public void ClosePreviousPage(UINavigationButton navigationButton)
		{
		}
	}
}
