using TMPro;
using UnityEngine;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay.Arena.UI
{
	public class UIArenaLeaderboardRow : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text _nameText;

		[SerializeField]
		private TMP_Text _ratingText;

		public void SetData(ArenaLeaderboardEntry entry)
		{
		}
	}
}
