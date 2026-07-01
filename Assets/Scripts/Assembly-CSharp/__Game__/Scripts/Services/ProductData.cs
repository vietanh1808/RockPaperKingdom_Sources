using UnityEngine;
using UnityEngine.Purchasing;

namespace __Game__.Scripts.Services
{
	[CreateAssetMenu(fileName = "ProductData", menuName = "TapHub/Shop/Product/Product Data")]
	public class ProductData : ScriptableObject
	{
		[SerializeField]
		private string _productId;

		[SerializeField]
		private ProductType _productType;

		public string ProductId => null;

		public ProductType ProductType => default(ProductType);
	}
}
