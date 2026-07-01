namespace __Simulation__.Systems._Upgrades
{
	public static class CommandLineArgsParser
	{
		public static int GetInstanceIndex()
		{
			return 0;
		}

		public static string GetCsvOutputPath()
		{
			return null;
		}

		private static bool GetStringArg(string key, out string value)
		{
			value = null;
			return false;
		}
	}
}
