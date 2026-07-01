using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems
{
	public class MenuTutorialSystem
	{
		public List<string> PendingTutorials { get; private set; }

		public event Action<string> OnPendingTutorialAdded
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void LoadData(List<string> pendingTutorials)
		{
		}

		public void AddPendingTutorial(string guid)
		{
		}

		public void CompleteTutorial(string guid)
		{
		}
	}
}
