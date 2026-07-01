using UnityEngine;
using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIProjectHolder : MonoBehaviour
	{
		[SerializeField]
		private UISettingsPopup _uiSettingsPopup;

		[SerializeField]
		private UIFadeDisplay _uiFadeDisplay;

		[SerializeField]
		private UIPurchaseOverlay _uiPurchaseOverlay;

		[SerializeField]
		private UITutorialTap _uiTutorialTap;

		[SerializeField]
		private UIEquipmentInfoPopup _uiEquipmentInfoPopup;

		[SerializeField]
		private UIHeroInfoPopup _uiHeroInfoPopup;

		public UISettingsPopup Settings => null;

		public UIFadeDisplay FadeDisplay => null;

		public UIPurchaseOverlay PurchaseOverlay => null;

		public UITutorialTap TutorialTap => null;

		public UIEquipmentInfoPopup EquipmentInfo => null;

		public UIHeroInfoPopup HeroInfo => null;
	}
}
