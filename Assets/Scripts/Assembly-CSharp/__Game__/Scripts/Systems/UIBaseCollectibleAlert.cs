using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public abstract class UIBaseCollectibleAlert<TAlert, TItem, TItemData> : MonoBehaviour where TAlert : BaseCollectibleUpgradeAlertSystem<TItem, TItemData> where TItem : BaseCollectibleItem<TItemData> where TItemData : BaseCollectibleItemData
	{
		[SerializeField]
		private GameObject _upgradeAlert;

		private TAlert _collectibleUpgradeAlertSystem;

		[Inject]
		private void Inject(TAlert collectibleUpgradeAlertSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshUpgradeCollectibleUpgradeAlert()
		{
		}
	}
}
