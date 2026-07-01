using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace __Game__.Scripts.Gameplay.BossChest.UI
{
	public class UIIconRoller : MonoBehaviour
	{
		[SerializeField]
		private Image[] _iconImages;

		[SerializeField]
		private float _iconStep;

		[SerializeField]
		private float _thresholdY;

		[SerializeField]
		private float _baseSpeed;

		private readonly Queue<Image> _pool;

		private readonly List<Image> _activeImages;

		private readonly List<Sprite> _availableIcons;

		private bool _isRolling;

		private Action _onComplete;

		private float _rollingDuration;

		private float _elapsedTime;

		private void Awake()
		{
		}

		public void SetIcons(Sprite[] rollerIcons)
		{
		}

		public void StartRolling(float duration, Action onComplete)
		{
		}

		private void SetDuration(float duration, Action onComplete)
		{
		}

		private void SpawnInitialIcons()
		{
		}

		public void StopRolling()
		{
		}

		private void Update()
		{
		}

		private void MoveActiveImages(float delta)
		{
		}

		private void CheckForNewSpawn()
		{
		}

		private void CheckForRecycle()
		{
		}

		private void SpawnNextIcon(float positionY)
		{
		}

		private void ReturnToPool(Image icon)
		{
		}

		private void ReturnAllToPool()
		{
		}

		private Sprite GetRandomIcon()
		{
			return null;
		}
	}
}
