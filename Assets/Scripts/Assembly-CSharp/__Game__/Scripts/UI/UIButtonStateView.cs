using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.UI
{
	public class UIButtonStateView : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _text;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private Color _activeTextColor;

		[SerializeField]
		private Color _inactiveTextColor;

		[SerializeField]
		private Sprite _activeIconSprite;

		[SerializeField]
		private Sprite _inactiveIconSprite;

		[SerializeField]
		private Sprite _activeBackgroundSprite;

		[SerializeField]
		private Sprite _inactiveBackgroundSprite;

		[SerializeField]
		private List<GameObject> _activeStateObjects;

		public void SetActiveState(bool isActive)
		{
		}
	}
}
