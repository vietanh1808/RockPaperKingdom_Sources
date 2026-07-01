using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UINavigateShopButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _buttonClick;

		[Range(0f, 1f)]
		[SerializeField]
		private float _targetPosition;

		[SerializeField]
		private FeatureItemData _featureItemData;

		[SerializeField]
		private Image _plusIcon;

		private FeatureItem _featureItem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		public void Inject(FeatureUnlockSystem featureUnlockSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
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

		private void OnButtonClicked()
		{
		}
	}
}
