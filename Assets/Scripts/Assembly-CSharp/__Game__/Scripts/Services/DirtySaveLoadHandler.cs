namespace __Game__.Scripts.Services
{
	public abstract class DirtySaveLoadHandler<T> : BaseSaveLoadHandler where T : DirtySaveLoadProvider
	{
		private readonly T _provider;

		protected DirtySaveLoadHandler(T provider)
		{
		}

		public sealed override void Load()
		{
		}

		public sealed override void Save()
		{
		}

		protected abstract void LoadDirty();

		protected abstract void SaveDirty();
	}
}
