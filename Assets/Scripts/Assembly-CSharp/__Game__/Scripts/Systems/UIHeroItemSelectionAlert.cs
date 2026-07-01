using UnityEngine;

namespace __Game__.Scripts.Systems
{
	public class UIHeroItemSelectionAlert : MonoBehaviour
	{
		[SerializeField]
		private UIHeroInventoryElement _heroInventoryElement;

		[SerializeField]
		private GameObject _alertMark;

		private HeroItem _heroItem;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnHeroItemConstructed(HeroItem heroItem)
		{
		}

		private void UpdateAlertSelectionStatus()
		{
		}
	}
}
