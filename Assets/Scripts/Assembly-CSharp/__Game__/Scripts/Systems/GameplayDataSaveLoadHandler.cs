using __Game__.Scripts.Services;

namespace __Game__.Scripts.Systems
{
	public class GameplayDataSaveLoadHandler : BaseSaveLoadHandler
	{
		private readonly RestoreGameplayRuntimeData _restoreGameplayRuntimeData;

		private readonly TutorialsGameplayRuntimeData _tutorialsGameplayRuntimeData;

		public GameplayDataSaveLoadHandler(RestoreGameplayRuntimeData restoreGameplayRuntimeData, TutorialsGameplayRuntimeData tutorialsGameplayRuntimeData)
		{
		}

		public override void Load()
		{
		}

		public override void Save()
		{
		}

		public override string GetDataPath()
		{
			return null;
		}
	}
}
