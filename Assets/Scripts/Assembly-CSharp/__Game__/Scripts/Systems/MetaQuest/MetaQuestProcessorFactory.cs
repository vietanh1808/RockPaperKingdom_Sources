using Zenject;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public class MetaQuestProcessorFactory
	{
		private readonly DiContainer _container;

		public MetaQuestProcessorFactory(DiContainer container)
		{
		}

		public BaseMetaQuestProcessor Create(BaseMetaQuestData questData)
		{
			return null;
		}
	}
}
