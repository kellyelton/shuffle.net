namespace Shuffle.Net
{
	public class QuantumState<T>
	{
		public T Item { get; set; }
		public bool Observed { get; set; }

		public QuantumState(T item , bool observed = false)
		{
			Item = item;
			Observed = observed;
		}
	}
}