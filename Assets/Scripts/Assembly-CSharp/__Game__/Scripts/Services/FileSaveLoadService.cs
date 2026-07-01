using System.Collections.Generic;
using __Game__.Scripts.Systems;
using __Game__.Scripts.Systems.DailyStreakQuest;

namespace __Game__.Scripts.Services
{
	public class FileSaveLoadService : ISaveLoadDataService
	{
		private readonly List<BaseSaveLoadHandler> _saveLoadHandlers;

		public FileSaveLoadService(GameDataSaveLoadHandler gameDataSaveLoadHandler, GameplayDataSaveLoadHandler gameplayDataSaveLoadHandler, EquipmentSaveLoadHandler equipmentSaveLoadHandler, InventorySaveLoadHandler inventorySaveLoadHandler, PlayerDataSaveLoadHandler playerDataSaveLoadHandler, HeroSaveLoadHandler heroSaveLoadHandler, UnitCardSaveLoadHandler unitCardSaveLoadHandler, TalentCollectionSaveLoadHandler talentCollectionSaveLoadHandler, DailyStreakQuestSaveLoadHandler dailyStreakQuestSaveLoadHandler)
		{
		}

		public void LoadAll()
		{
		}

		public void SaveAll()
		{
		}

		public void ClearData()
		{
		}

		public static T LoadData<T>(string path) where T : new()
		{
			return default(T);
		}

		public static void SaveData(string path, object data)
		{
		}

		private static void DeleteData(string path)
		{
		}

		private static void CheckDictionaryPath(string path)
		{
		}
	}
}
