namespace __Game__.Scripts.Infrastructure
{
	public interface IPoolElement
	{
		void OnPoolGet();

		void OnPoolRelease();
	}
}
