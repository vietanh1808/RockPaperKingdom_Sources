using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UINavigationPurchaseAlert : MonoBehaviour
	{
		[SerializeField]
		private GameObject _alertMark;

		private PurchaseAlertSystem _purchaseAlertSystem;

		[Inject]
		public void Inject(PurchaseAlertSystem purchaseAlertSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void RefreshAlert()
		{
		}
	}
}
