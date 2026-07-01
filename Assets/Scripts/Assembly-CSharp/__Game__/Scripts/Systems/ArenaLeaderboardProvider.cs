namespace __Game__.Scripts.Systems
{
	public class ArenaLeaderboardProvider
	{
		private const int TOTAL_PLAYERS = 10000;

		private const int MAX_RATING = 8000;

		private const int NEARBY_COUNT = 3;

		private const int PLAYER_ROW_INDEX = 4;

		private static readonly string[] NICKNAME_PREFIXES;

		private static readonly string[] NICKNAME_SUFFIXES;

		private readonly ArenaSystem _arenaSystem;

		public ArenaLeaderboardProvider(ArenaSystem arenaSystem)
		{
		}

		public ArenaLeaderboardData GetLeaderboardData()
		{
			return default(ArenaLeaderboardData);
		}

		private ArenaLeaderboardEntry CreateEntry(int position)
		{
			return default(ArenaLeaderboardEntry);
		}

		private int FindPlayerPosition(int playerRating)
		{
			return 0;
		}

		private int GetRatingForPosition(int position)
		{
			return 0;
		}

		private int GetNoisyRating(int position, int baseRating)
		{
			return 0;
		}

		private string GenerateName(int position)
		{
			return null;
		}
	}
}
