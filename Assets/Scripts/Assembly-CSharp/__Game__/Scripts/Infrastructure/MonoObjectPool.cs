using System;
using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Infrastructure
{
	public class MonoObjectPool<T> where T : MonoBehaviour, IPoolElement
	{
		private readonly List<T> _pool;

		private readonly List<T> _active;

		private readonly Func<T> _factoryMethod;

		public MonoObjectPool(Func<T> factoryMethod, int initialStock = 0)
		{
		}

		public MonoObjectPool(Func<T> factoryMethod, List<T> initialStock)
		{
		}

		public T GetObject(Vector3 position)
		{
			return null;
		}

		private T GetObjectInternal()
		{
			return null;
		}

		public void ReleaseObject(T o)
		{
		}

		public void ReleaseAll()
		{
		}
	}
}
