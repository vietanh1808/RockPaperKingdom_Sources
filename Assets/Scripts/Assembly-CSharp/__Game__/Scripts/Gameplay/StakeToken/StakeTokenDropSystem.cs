using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.Revive;
using __Game__.Scripts.Gameplay.Waves;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.StakeToken
{
	public class StakeTokenDropSystem : IInitializable, IDisposable
	{
		private readonly UnitRepository _enemyRepository;

		private readonly GameplayCoinObjectManager _coinObjectManager;

		private readonly WaveSystem _waveSystem;

		private readonly StageSystem _stageSystem;

		private readonly ReviveSystem _reviveSystem;

		private StakeTokenSettings _settings;

		private WaveStakeTokenDropModel _currentWaveDropModel;

		private readonly HashSet<BaseUnit> _tokenDroppers;

		private int _totalTokensDropped;

		private int _waveTokenTarget;

		private bool _shouldDropThisWave;

		private Vector3 _lastEnemyPosition;

		public StakeTokenDropSystem(UnitRepositoryFactory unitRepositoryFactory, GameplayCoinObjectManager coinObjectManager, WaveSystem waveSystem, StageSystem stageSystem, ReviveSystem reviveSystem)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		private void OnWaveStarted()
		{
		}

		private void OnUnitAdded(BaseUnit unit)
		{
		}

		private void OnWaveStateChanged()
		{
		}

		private void OnUnitRemoved(BaseUnit unit)
		{
		}

		private void SpawnMinimumGuaranteedTokens()
		{
		}

		private void SpawnToken(Vector3 position)
		{
		}

		private void MarkRandomEnemiesAsTokenDroppers()
		{
		}

		private void TryAddTokenDropper(BaseUnit unit)
		{
		}
	}
}
