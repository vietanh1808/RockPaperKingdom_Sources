using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Common
{
	[Serializable]
	public class AssetModuleHolder<T> where T : ScriptableObject
	{
		[HideInInspector]
		[SerializeField]
		private ScriptableObject _parent;

		[SerializeField]
		private List<T> _modules;

		private Type _moduleType;

		public List<T> Modules => null;

		public void Init(ScriptableObject parent, Type defaultType)
		{
		}

		private void AddModule()
		{
		}

		private bool IsParentInitialized()
		{
			return false;
		}

		private void DeleteMissingModules()
		{
		}

		private void DeleteModulesOfOtherTypes()
		{
		}

		private IEnumerable GetAvailableModules()
		{
			return null;
		}

		private static string GetModuleName(Type moduleType)
		{
			return null;
		}
	}
}
