namespace __Simulation__.Systems._Upgrades.Utils
{
	public static class SimulationLauncherUtils
	{
		private const string EXECUTABLE_RELATIVE_PATH = "/Contents/MacOS/";

		private const string PROCESS_NAME = "Rock Paper Kingdoms";

		public static void LaunchInstances(string appPath, UpgradesSimulationConfig config, string stagePrefix = "")
		{
		}

		public static void LaunchInstances(string appPath, UpgradesSimulationConfig config, out string csvOutputPath, string stagePrefix = "")
		{
			csvOutputPath = null;
		}

		private static string GenerateSharedCsvPath(string csvExportFolderPath, string stagePrefix = "")
		{
			return null;
		}

		private static string FindExecutablePath(string appPath)
		{
			return null;
		}

		public static string ExtractStagePrefix(string assetName)
		{
			return null;
		}

		public static void CloseAllInstances()
		{
		}
	}
}
