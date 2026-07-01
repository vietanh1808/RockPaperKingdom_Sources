using System.Collections.Generic;
using UnityEngine;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "Collection_Product", menuName = "TapHub/Shop/Product/Product Collection")]
	public class ProductCollection : ScriptableObject
	{
		public List<ProductData> Products;
	}
}
