using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using Zenject;

namespace __Game__.Scripts.Services
{
	public class ApplicationLifecycleService : MonoBehaviour
	{
		private ISaveLoadDataService _saveLoadDataService;

		private bool _disableDataSave;

		public static event Action OnBackgroundModeEnabled
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

		public event Action<bool> OnFocusStatusChanged
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

		public event Action OnStartInvoked
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

		[Inject]
		public void Inject(ISaveLoadDataService saveLoadDataService)
		{
		}

		private void Start()
		{
		}

		private void OnApplicationFocus(bool status)
		{
		}

		private void OnApplicationQuit()
		{
		}

		public void DisableDataSave()
		{
		}

		private void SaveData()
		{
		}
	}
}
