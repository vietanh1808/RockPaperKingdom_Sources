using System.Collections.Generic;
using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems;
using __Game__.Scripts.UI;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaLeaderboardPopup : UIBasePopup
	{
		[SerializeField]
		private List<UIArenaLeaderboardRow> _rows;

		private ArenaLeaderboardProvider _leaderboardProvider;

		[Inject]
		public void Construct(ArenaLeaderboardProvider leaderboardProvider)
		{
		}

		protected override void OnEnable()
		{
		}

		private void Refresh()
		{
		}
	}
}
