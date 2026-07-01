using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using Zenject;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class UIRewardFloating : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _parentLayout;

		[SerializeField]
		private UIFloatingElement _uiFloatingElement;

		private ObjectPool<UIFloatingElement> _floatingElementPool;

		private readonly Dictionary<string, RectTransform> _containersDictionary;

		private readonly Dictionary<string, RectTransform> _temporarySourcesDictionary;

		private RectTransform _singleSourceContainer;

		private float _startSizeOverride;

		private SoundsConfig _soundsConfig;

		[Inject]
		private void Inject(SoundsConfig soundsConfig)
		{
		}

		private void Awake()
		{
		}

		public void AddTargetContainer(string guid, RectTransform containerTransform)
		{
		}

		public void RemoveTargetContainer(string guid)
		{
		}

		public void SetSingleSourceContainer(RectTransform container, float startSizeOverride = -1f)
		{
		}

		public void AddTemporarySourceContainer(string guid, RectTransform containerTransform)
		{
		}

		public void ClaimReward(List<Reward> rewards, Action<Reward> onTargetReached)
		{
		}

		private void ShowFloatingElement(Reward reward, Action<Reward> onTargetReached, float startSizeOverride = -1f)
		{
		}

		private RectTransform GetSourceContainer(string guid)
		{
			return null;
		}

		private UIFloatingElement InstantiateElement()
		{
			return null;
		}
	}
}
