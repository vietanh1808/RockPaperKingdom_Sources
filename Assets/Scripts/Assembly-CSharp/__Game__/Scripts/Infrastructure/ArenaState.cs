using __Game__.Scripts.Services;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Infrastructure
{
	public class ArenaState : BaseGameState
	{
		private readonly SceneController _sceneController;

		private readonly ArenaSystem _arenaSystem;

		private readonly ArenaTicketSystem _arenaTicketSystem;

		private readonly ISaveLoadDataService _saveLoadDataService;

		public ArenaState(SceneController sceneController, ArenaSystem arenaSystem, ArenaTicketSystem arenaTicketSystem, ISaveLoadDataService saveLoadDataService)
		{
		}

		public override void Enter()
		{
		}

		public override void Exit()
		{
		}
	}
}
