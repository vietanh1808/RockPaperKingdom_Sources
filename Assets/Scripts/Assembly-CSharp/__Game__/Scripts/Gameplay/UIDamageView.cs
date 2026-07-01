using UnityEngine;
using Zenject;
using __Game__.Scripts.Infrastructure;

namespace __Game__.Scripts.Gameplay
{
	public class UIDamageView : MonoBehaviour
	{
		[SerializeField]
		private UIDamageItem _uiDamageItemPrefab;

		[SerializeField]
		private Vector3 _damageOffset;

		private Camera _camera;

		private ObjectPool<UIDamageItem> _pool;

		[Inject]
		private void Inject(Camera mainCamera)
		{
		}

		private void Awake()
		{
		}

		public void ShowDamage(Damage damage)
		{
		}
	}
}
