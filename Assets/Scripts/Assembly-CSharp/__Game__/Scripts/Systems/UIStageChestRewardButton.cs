using UnityEngine;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageChestRewardButton : MonoBehaviour
	{
		[SerializeField]
		private UIButtonClick _button;

		[SerializeField]
		private GameObject _alertMark;

		private StageChestSystem _stageChestSystem;

		private UIMenuSceneNavigation _uiMenuSceneNavigation;

		[Inject]
		private void Inject(StageChestSystem stageChestSystem, UIMenuSceneNavigation uiMenuSceneNavigation)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshAlert()
		{
		}

		private void OnButtonClicked()
		{
		}
	}
}
