namespace __Game__.Scripts.Services
{
	public abstract class BaseSaveLoadHandler
	{
		public abstract void Load();

		public abstract void Save();

		public abstract string GetDataPath();
	}
}
