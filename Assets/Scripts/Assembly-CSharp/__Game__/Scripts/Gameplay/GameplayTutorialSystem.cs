using Zenject;
using __Game__.Scripts.Systems;

namespace __Game__.Scripts.Gameplay
{
	public class GameplayTutorialSystem : IInitializable
	{
		private readonly TutorialsGameplayRuntimeData _tutorialsGameplayRuntimeData;

		private readonly UIGameplayTutorialsNavigation _uiGameplayTutorialsNavigation;

		public GameplayTutorialSystem(TutorialsGameplayRuntimeData tutorialsGameplayRuntimeData, UIGameplayTutorialsNavigation uiGameplayTutorialsNavigation)
		{
		}

		public void Initialize()
		{
		}

		private void OnTutorialCompleted(string guid)
		{
		}
	}
}
