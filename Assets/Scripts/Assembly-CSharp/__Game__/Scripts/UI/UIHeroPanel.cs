using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.UI
{
	public class UIHeroPanel : MonoBehaviour
	{
		[Header("Tabs")]
		[SerializeField]
		private ToggleGroup _tabToggleGroup;

		[SerializeField]
		private Toggle _heroTab;

		[SerializeField]
		private Toggle _cardsTab;

		[Header("Containers")]
		[SerializeField]
		private GameObject _heroContainer;

		[SerializeField]
		private GameObject _cardsContainer;

		[Header("Tab Alerts")]
		[SerializeField]
		private GameObject _heroTabAlert;

		[SerializeField]
		private GameObject _cardsTabAlert;

		[Header("Selection")]
		[SerializeField]
		private GameObject _selectionTitle;

		private HeroSystem _heroSystem;

		[Inject]
		private void Inject(HeroSystem heroSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnHeroTabValueChanged(bool isOn)
		{
		}

		private void OnCardsTabValueChanged(bool isOn)
		{
		}

		private void UpdateContainers()
		{
		}

		private void UpdateAlerts()
		{
		}

		private void UpdateTabsVisibility()
		{
		}

		private void OnSelectingSlot()
		{
		}

		private void OnSelectingCanceled()
		{
		}
	}
}
