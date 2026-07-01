using UnityEngine;
using Zenject;
using __Game__.Scripts.Systems.MetaQuest;

namespace __Game__.Scripts.UI
{
	public class UIMetaQuestProgressContainer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _contentContainer;

		private MetaQuestSystem _metaQuestSystem;

		private BaseMetaQuestProcessor _currentProcessor;

		[Inject]
		private void Inject(MetaQuestSystem metaQuestSystem)
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnActiveProcessorChanged(BaseMetaQuestProcessor processor)
		{
		}
	}
}
