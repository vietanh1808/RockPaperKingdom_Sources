using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIDailyRewardsButton : MonoBehaviour
	{
		[SerializeField]
		private FeatureItemData _featureItemData;

		[SerializeField]
		private UIButtonClick _buttonClick;

		[SerializeField]
		private Image _featureIcon;

		[SerializeField]
		private TMP_Text _featureTitle;

		private FeatureItem _featureItem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		public void Inject(FeatureUnlockSystem featureUnlockSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnFeatureItemStatusChanged(FeatureItem featureItem)
		{
		}

		private void OpenRewardsPopup()
		{
		}
	}
}
