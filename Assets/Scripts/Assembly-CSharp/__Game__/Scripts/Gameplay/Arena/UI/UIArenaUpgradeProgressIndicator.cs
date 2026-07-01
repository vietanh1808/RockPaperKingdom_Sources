using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaUpgradeProgressIndicator : MonoBehaviour
	{
		[SerializeField]
		private UIUpgradeProgressItem[] _progressItems;

		private ArenaUpgradesPresenter _arenaUpgradesPresenter;

		private int _currentIndex;

		[Inject]
		private void Inject(ArenaUpgradesPresenter arenaUpgradesPresenter)
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
