using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Systems
{
	public class UIStageController : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _stageTitle;

		[SerializeField]
		private Image _stageIcon;

		[SerializeField]
		private UIButtonClick _backButton;

		[SerializeField]
		private UIButtonClick _nextButton;

		[SerializeField]
		private GameObject _lockMark;

		[SerializeField]
		private GameObject _completedMark;

		[SerializeField]
		private Color _lockedIconColor;

		private StageSystem _stageSystem;

		[Inject]
		public void Inject(StageSystem stageSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshView()
		{
		}

		private void BackButtonClicked()
		{
		}

		private void NextButtonClicked()
		{
		}
	}
}
