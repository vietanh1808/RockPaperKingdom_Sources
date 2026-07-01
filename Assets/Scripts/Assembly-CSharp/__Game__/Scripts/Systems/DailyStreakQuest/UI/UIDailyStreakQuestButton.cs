using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems.DailyStreakQuest.UI
{
	public class UIDailyStreakQuestButton : MonoBehaviour
	{
		[SerializeField]
		private FeatureItemData _featureItemData;

		[SerializeField]
		private UIButtonClick _buttonClick;

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

		private void OpenPopup()
		{
		}
	}
}
