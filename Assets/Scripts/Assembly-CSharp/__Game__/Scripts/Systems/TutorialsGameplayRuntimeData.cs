using System.Collections.Generic;

namespace __Game__.Scripts.Systems
{
	public class TutorialsGameplayRuntimeData
	{
		public List<string> CompletedTutorials { get; private set; }

		public bool CanShowTutorials { get; private set; }

		public void SetupData(List<string> completedTutorials)
		{
		}

		public void Activate()
		{
		}
	}
}
