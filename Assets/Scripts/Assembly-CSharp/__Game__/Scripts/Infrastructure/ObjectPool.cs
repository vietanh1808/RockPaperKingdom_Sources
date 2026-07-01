using System;
using System.Collections.Generic;

namespace __Game__.Scripts.Infrastructure
{
	public class ObjectPool<T> where T : IPoolElement
	{
		private readonly List<T> _pool;

		private readonly Func<T> _factoryMethod;

		public ObjectPool(Func<T> factoryMethod, int initialStock = 0)
		{
		}

		public ObjectPool(Func<T> factoryMethod, List<T> initialStock)
		{
		}

		public T GetObject()
		{
			return default(T);
		}

		public void ReleaseObject(T o)
		{
		}
	}
}
