using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Gameplay
{
	public class UIGameplayTutorialsNavigation : MonoBehaviour
	{
		[SerializeField]
		private List<BaseGameplayTutorialPresenter> _uiTutorialsPresenters;

		[SerializeField]
		private UIDragPointer _uiDragPointer;

		public List<BaseGameplayTutorialPresenter> UITutorialsPresenters => null;

		public UIDragPointer UIDragPointer => null;
	}
}
