using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Common
{
	public class StatValue
	{
		private float _value;

		public string Title { get; }

		public float Value => 0f;

		public float OldValue { get; private set; }

		public event Action<StatValue> OnValueChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void SetValue(float value)
		{
		}

		public StatValue(float initialValue = 0f, string title = "")
		{
		}
	}
}
