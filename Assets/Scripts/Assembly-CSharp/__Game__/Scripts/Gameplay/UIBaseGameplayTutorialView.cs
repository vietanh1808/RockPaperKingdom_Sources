using System;
using Sirenix.OdinInspector;

namespace __Game__.Scripts.Gameplay
{
	public abstract class UIBaseGameplayTutorialView : SerializedMonoBehaviour
	{
		private Action _onTutorialCompleted;

		public void StartTutorial(Action onTutorialCompleted)
		{
		}

		protected void CompleteTutorial()
		{
		}
	}
}
