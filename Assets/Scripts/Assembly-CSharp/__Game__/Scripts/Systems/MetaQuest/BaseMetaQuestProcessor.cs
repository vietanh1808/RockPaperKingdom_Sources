using System;
using System.Runtime.CompilerServices;

namespace __Game__.Scripts.Systems.MetaQuest
{
	public abstract class BaseMetaQuestProcessor
	{
		protected BaseMetaQuestData _data;

		protected float _progress;

		public BaseMetaQuestData Data => null;

		public float Progress
		{
			get
			{
				return 0f;
			}
			protected set
			{
			}
		}

		public bool IsCompleted => false;

		public virtual int CurrentValue => 0;

		public virtual int TargetValue => 0;

		public event Action<float> OnProgressChanged
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

		public event Action OnCompleted
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

		public virtual void Initialize(BaseMetaQuestData data)
		{
		}

		public abstract void Activate();

		public abstract void Deactivate();
	}
}
