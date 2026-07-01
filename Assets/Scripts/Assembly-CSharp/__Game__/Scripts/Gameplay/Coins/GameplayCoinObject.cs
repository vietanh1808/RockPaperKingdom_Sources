using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.Coins
{
	public class GameplayCoinObject : MonoBehaviour, IPoolElement
	{
		[SerializeField]
		private float _moveSpeed;

		[Header("SFX")]
		[SerializeField]
		private SoundData _collectSound;

		private int _coinValue;

		private GameplayCoinObjectManager _manager;

		private Tween _moveTween;

		public void Initialize(int coinValue, GameplayCoinObjectManager manager)
		{
		}

		public void StartCollection(Vector3 collectionTarget)
		{
		}

		private void CompleteCollection()
		{
		}

		public void OnPoolGet()
		{
		}

		public void OnPoolRelease()
		{
		}
	}
}
