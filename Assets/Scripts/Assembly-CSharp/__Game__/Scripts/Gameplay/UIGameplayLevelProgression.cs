using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplayLevelProgression : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _levelText;

		[SerializeField]
		private Slider _experienceSlider;

		private GameplayLevelSystem _gameplayLevelSystem;

		[Inject]
		private void Inject(GameplayLevelSystem gameplayLevelSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void UpdateView()
		{
		}

		private void UpdateLevelSystem()
		{
		}

		private void UpdateExperience()
		{
		}
	}
}
