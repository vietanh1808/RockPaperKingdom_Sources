using DG.Tweening;
using UnityEngine;
using __Game__.Scripts.Infrastructure;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Gameplay.Experience
{
	public class ExperienceObject : MonoBehaviour, IPoolElement
	{
		[SerializeField]
		private float _moveSpeed;

		[Header("Order Rendering")]
		[SerializeField]
		private SpriteRenderer _spriteRenderer;

		[Header("SFX")]
		[SerializeField]
		private SoundData _collectSound;

		private int _experienceValue;

		private ExperienceObjectManager _manager;

		private Tween _moveTween;

		public void Initialize(int experienceValue, ExperienceObjectManager manager)
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
