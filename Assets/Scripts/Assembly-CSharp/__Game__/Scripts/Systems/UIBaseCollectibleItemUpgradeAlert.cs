using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleItemUpgradeAlert<TItem, TItemData> : MonoBehaviour where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[SerializeField]
		private UIBaseCollectibleInventoryElement<TItem, TItemData> _collectibleElement;

		[SerializeField]
		private GameObject _alertMark;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		protected void RefreshAlert(bool value)
		{
		}

		protected abstract void Construct(TItem item);

		protected abstract void Unsubscribe();
	}
}
