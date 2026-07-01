using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay.Experience
{
	public class ExperienceObjectManager : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _collectionTarget;

		[SerializeField]
		private ExperienceObject _experienceObjectPrefab;

		private readonly List<ExperienceObject> _activeExperienceObjects;

		private ObjectPool<ExperienceObject> _experiencePool;

		private GameplayLevelSystem _gameplayLevelSystem;

		private Camera _camera;

		private Tween _scaleTween;

		private int _spawnedExperience;

		private int _collectedExperience;

		public bool IsAllExperienceSpawned { get; private set; }

		public event Action OnAllExperienceSpawned
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

		public event Action OnAllExperienceCollected
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

		public event Action OnExperienceRewardAdded
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
		private void Inject(DiContainer diContainer, GameplayLevelSystem gameplayLevelSystem, Camera mainCamera)
		{
		}

		public void SpawnExperience(Vector3 position, int experienceValue)
		{
		}

		public void StartCollectionPhase()
		{
		}

		public void CollectExperience(int experienceValue)
		{
		}

		public void DiscardAllExperience()
		{
		}

		public void ReturnToPool(ExperienceObject experienceObject)
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
