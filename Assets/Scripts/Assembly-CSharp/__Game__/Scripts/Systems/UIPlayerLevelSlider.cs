using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIPlayerLevelSlider : MonoBehaviour
	{
		[Header("Item")]
		[SerializeField]
		private ExperienceItemData _experienceItemData;

		[SerializeField]
		private RectTransform _targetContainer;

		[Header("View")]
		[SerializeField]
		private Slider _experienceSlider;

		[SerializeField]
		private TMP_Text _levelValue;

		private PlayerLevelSystem _playerLevelSystem;

		private UIRewardFloating _uiRewardFloating;

		[Inject]
		public void Inject(PlayerLevelSystem playerLevelSystem, UIRewardFloating uiRewardFloating)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void SetupView()
		{
		}

		private void RefreshExperience()
		{
		}

		private void RefreshLevel()
		{
		}
	}
}
