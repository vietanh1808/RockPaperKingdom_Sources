using UnityEngine;
using Zenject;
using __Game__.Scripts.Gameplay;
using __Game__.Scripts.Services;

namespace __Game__.Scripts.Infrastructure
{
	public class ProjectDebugInstaller : MonoInstaller
	{
		[Header("Project Debug")]
		[SerializeField]
		private DebuggerOptionPanel _debuggerOptionPanel;

		[SerializeField]
		private DebuggerConfig _debuggerConfig;

		[Header("Gameplay Debug")]
		[SerializeField]
		private GameplayDebugConfig _gameplayDebugConfig;

		public override void InstallBindings()
		{
		}
	}
}
