namespace __Game__.Scripts.Services
{
	public interface ISaveLoadDataService
	{
		void LoadAll();

		void SaveAll();

		void ClearData();
	}
}
