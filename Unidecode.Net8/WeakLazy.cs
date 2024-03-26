namespace Unidecode.Net8;

public abstract class WeakLazy<T> where T : class
{
	protected readonly Func<T> valueFactory;
	internal protected WeakLazy(Func<T> valueFactory)
	{
		if (valueFactory != null)
		{
			this.valueFactory = valueFactory;
		}

	}

	public abstract T Value { get; }
}
public sealed class StaticWeakLazy<T> : WeakLazy<T> where T : class
{
	private readonly WeakReference<T> reference;
	public StaticWeakLazy(Func<T> valueFactory) : base(valueFactory)
	{
		if (valueFactory != null)
		{
			this.reference = new WeakReference<T>(null);
		}

	}

	public override T Value
	{
		get
		{
			T value;
			if (!this.reference.TryGetTarget(out value))
			{
				value = this.valueFactory();
				this.reference.SetTarget(value);
			}
			return value;
		}
	}
}
