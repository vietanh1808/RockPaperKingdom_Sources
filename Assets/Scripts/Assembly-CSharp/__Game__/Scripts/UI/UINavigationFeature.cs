using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UINavigationFeature : MonoBehaviour
	{
		[SerializeField]
		private UINavigationButton _uiNavigationButton;

		[SerializeField]
		private FeatureItemData _featureItemData;

		[Header("View")]
		[SerializeField]
		private Image _featureIcon;

		[SerializeField]
		private TMP_Text _featureTitle;

		[SerializeField]
		private GameObject _alertMark;

		[SerializeField]
		private UIButtonMessage _uiButtonMessage;

		private FeatureItem _featureItem;

		private bool _isUnlocked;

		[Inject]
		public void Inject(FeatureUnlockSystem featureUnlockSystem)
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
	}
}
