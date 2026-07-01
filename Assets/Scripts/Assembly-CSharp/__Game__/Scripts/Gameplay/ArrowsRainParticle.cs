using System;
using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class ArrowsRainParticle : MonoBehaviour, IPoolElement
	{
		private ObjectPool<ArrowsRainParticle> _objectPool;

		private Tween _tween;

		public void Init(ObjectPool<ArrowsRainParticle> pool)
		{
		}

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}

		public void DelayedRelease(float delay, Action onCompleted = null)
		{
		}
	}
}
