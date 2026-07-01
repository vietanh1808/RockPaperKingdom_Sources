using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Systems
{
	public class UICollectibleStatsView : MonoBehaviour
	{
		[SerializeField]
		private RectTransform _rootLayout;

		[SerializeField]
		private UIStatElement _uiStatElementPrefab;

		private readonly Dictionary<PlayerStatType, UIStatElement> _statElementPerType;

		private PlayerStatInfoCollection _playerStatInfoCollection;

		private BaseCollectibleItemData _collectibleItemData;

		[Inject]
		public void Inject(PlayerStatInfoCollection playerStatInfoCollection)
		{
		}

		public void Construct(BaseCollectibleItemData collectibleItemData, int currentLevel)
		{
		}

		public void RefreshLevel(int currentLevel)
		{
		}
	}
}
