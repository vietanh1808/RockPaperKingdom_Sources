namespace __Game__.Scripts.Common
{
	public readonly struct StatChangeEventArgs
	{
		public string Title { get; }

		public float Delta { get; }

		public StatChangeType ChangeType { get; }

		public StatChangeEventArgs(string title, float delta, StatChangeType changeType)
		{
			Title = null;
			Delta = 0f;
			ChangeType = default(StatChangeType);
		}
	}
}
