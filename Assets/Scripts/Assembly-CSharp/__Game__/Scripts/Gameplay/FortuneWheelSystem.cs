using System.Collections.Generic;

namespace __Game__.Scripts.Gameplay
{
	public class FortuneWheelSystem
	{
		private const int MAX_SELECTED_ITEMS = 5;

		private readonly GameplayUpgradesSystem _gameplayUpgradesSystem;

		private readonly FortuneWheelConfig _fortuneWheelConfig;

		public List<FortuneWheelItem> AllItems { get; }

		public List<FortuneWheelItem> SelectedItems { get; }

		public FortuneWheelSystem(GameplayUpgradesSystem gameplayUpgradesSystem, FortuneWheelConfig fortuneWheelConfig)
		{
		}

		public void RefreshItems(int itemsAmount)
		{
		}

		private void AddItems(int requiredAmount, bool isSelected)
		{
		}

		private void SortToRandomOrder()
		{
		}

		private void ShiftToRandomIndex()
		{
		}
	}
}
