using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay.Coins
{
	public class GameplayCoinObjectManager : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _collectionTarget;

		[SerializeField]
		private GameplayCoinObject _coinObjectPrefab;

		[SerializeField]
		private float _spawnRandomOffsetX;

		[SerializeField]
		private float _spawnRandomOffsetZ;

		private readonly List<GameplayCoinObject> _activeCoinObjects;

		private ObjectPool<GameplayCoinObject> _coinPool;

		private GameplayInventorySystem _gameplayInventorySystem;

		private GameplayConfig _gameplayConfig;

		private Camera _camera;

		private Tween _scaleTween;

		private int _spawnedCoins;

		private int _collectedCoins;

		public bool HasCoinsToCollect => false;

		public event Action OnAllCoinsCollected
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event Action OnCoinRewardAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		[Inject]
		private void Inject(DiContainer diContainer, GameplayInventorySystem gameplayInventorySystem, GameplayConfig gameplayConfig, Camera mainCamera)
		{
		}

		public void SpawnCoin(Vector3 position, int coinValue)
		{
		}

		private Vector3 GetRandomSpawnOffset()
		{
			return default(Vector3);
		}

		public void StartCollectionPhase()
		{
		}

		public void CollectCoin(int coinValue)
		{
		}

		public void DiscardAllCoins()
		{
		}

		public void ReturnToPool(GameplayCoinObject coinObject)
		{
		}

		private void CompleteCollection()
		{
		}

		private void TriggerCollectionAnimation()
		{
		}

		private void OnDestroy()
		{
		}

		private Vector3 GetPositionFromScreen(Vector3 screenPosition)
		{
			return default(Vector3);
		}
	}
}
