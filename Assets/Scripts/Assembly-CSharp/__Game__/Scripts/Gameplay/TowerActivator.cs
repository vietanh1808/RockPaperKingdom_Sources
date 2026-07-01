using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay
{
	public class TowerActivator : MonoBehaviour
	{
		[SerializeField]
		private List<TowerStateSwitcher> _towerStateSwitchers;

		private UnitCountTracker _playerUnitCountTracker;

		private WaveSystem _waveSystem;

		private bool _isTowersActivated;

		[Inject]
		private void Inject(UnitCountTrackerFactory unitCountTrackerFactory, WaveSystem waveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnUnitCountChanged(int unitsCount)
		{
		}

		private void DeactivateTowers()
		{
		}

		private void SetAttackState()
		{
		}

		private void SetIdleState()
		{
		}
	}
}
