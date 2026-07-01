using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaChestProgressView : MonoBehaviour
	{
		[SerializeField]
		private List<UIArenaChestElement> _chestElements;

		[SerializeField]
		private List<Slider> _sliders;

		private const float SLIDER_OVERFLOW_VALUE = 1.25f;

		private ArenaChestSystem _arenaChestSystem;

		[Inject]
		private void Inject(ArenaChestSystem arenaChestSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Refresh()
		{
		}

		private static void UpdateSlider(Slider slider, int rangeStart, int rangeEnd, int highestRating)
		{
		}

		private void OnElementClaimClicked(ArenaChestItem chestItem)
		{
		}
	}
}
