using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay
{
	public class UIUpgradeProgressIndicator : MonoBehaviour
	{
		[SerializeField]
		private UIUpgradeProgressItem[] _progressItems;

		private GameplayUpgradesPresenter _gameplayUpgradesPresenter;

		private int _currentIndex;

		[Inject]
		private void Inject(GameplayUpgradesPresenter gameplayUpgradesPresenter)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		private void OnPendingUpgradesCountChanged(int remainingCount)
		{
		}
	}
}
