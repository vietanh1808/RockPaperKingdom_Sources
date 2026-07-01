using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.UI
{
	public class UIMenuHeader : MonoBehaviour
	{
		[SerializeField]
		private Canvas _resourcesCanvas;

		[SerializeField]
		private GraphicRaycaster _graphicRaycaster;

		[SerializeField]
		private Image[] _resourcesBackgroundImages;

		[SerializeField]
		private TMP_Text[] _resourcesTexts;

		[SerializeField]
		private Color _defaultTextColor;

		[SerializeField]
		private Color _overlayedTextColor;

		[Header("Swappable Containers")]
		[SerializeField]
		private GameObject _energyContainer;

		[SerializeField]
		private GameObject _talentResourceContainer;

		public void ShowResourcesOverlay(bool isShow)
		{
		}

		public void SetTalentResourceView(bool isActive)
		{
		}
	}
}
