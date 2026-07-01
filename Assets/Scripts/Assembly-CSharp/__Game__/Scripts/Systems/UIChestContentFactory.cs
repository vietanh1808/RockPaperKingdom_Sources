using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UIChestContentFactory
	{
		private DiContainer _diContainer;

		private UIChestContentView _uiChestContentView;

		[Inject]
		private void Inject(DiContainer diContainer, UIChestContentView uiChestContentView)
		{
		}

		public UIChestContentView Create(RarityProbabilityItem rarityProbabilityItem, Transform parent)
		{
			return null;
		}
	}
}
