using System;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay.Waves;

namespace __Game__.Scripts.Gameplay.BossChest
{
	public class BossChestManager : MonoBehaviour
	{
		[SerializeField]
		private BossChestObject _chestPrefab;

		[SerializeField]
		private Vector3 _spawnOffset;

		private DiContainer _diContainer;

		private WaveSystem _waveSystem;

		private BossChestObject _activeChest;

		private bool _chestSpawnedThisWave;

		public bool HasChest => false;

		[Inject]
		private void Inject(DiContainer diContainer, WaveSystem waveSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void HandleWaveStarted()
		{
		}

		public void SpawnChest(Vector3 position)
		{
		}

		public Vector2 GetChestViewportPosition()
		{
			return default(Vector2);
		}

		public void ConsumeChest(Action onComplete)
		{
		}

		public void DestroyChest()
		{
		}
	}
}
