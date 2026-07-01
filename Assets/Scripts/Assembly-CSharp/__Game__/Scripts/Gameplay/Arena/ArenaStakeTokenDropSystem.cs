using System;
using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Coins;
using __Game__.Scripts.Gameplay.StakeToken;

namespace __Game__.Scripts.Gameplay.Arena
{
	public class ArenaStakeTokenDropSystem : IInitializable, IDisposable
	{
		private readonly UnitRepository _enemyRepository;

		private readonly GameplayCoinObjectManager _coinObjectManager;

		private readonly ArenaWaveSystem _arenaWaveSystem;

		private readonly ArenaConfig _config;

		private StakeTokenSettings _settings;

		private WaveStakeTokenDropModel _currentRoundDropModel;

		private readonly HashSet<BaseUnit> _tokenDroppers;

		private int _totalTokensDropped;

		private int _roundTokenTarget;

		private int _roundTokensDropped;

		private bool _shouldDropThisRound;

		private bool _isFightActive;

		private Vector3 _lastEnemyPosition;

		public int LastRoundTokensDropped { get; private set; }

		public ArenaStakeTokenDropSystem(UnitRepositoryFactory unitRepositoryFactory, GameplayCoinObjectManager coinObjectManager, ArenaWaveSystem arenaWaveSystem, ArenaConfig config)
		{
		}

		public void Initialize()
		{
		}

		public void Dispose()
		{
		}

		public void NotifyFightStarted()
		{
		}

		public void NotifyFightEnded()
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
	}
}
