namespace ExtensionMethods;

public static class MyExtensions
{
    public static int MyCount<T>(this IEnumerable<T> that, Func<T, bool> predicate)
    {
        ICollection<T>? collection = that as ICollection<T>;
        return collection != null ? collection.Count(predicate) : 0;
    }

    public static int MyCount<T>(this IEnumerable<T> that)
    {
        //return that.Count(predicate);
        IEnumerator<T> enumerator = that.GetEnumerator();
        int n = 0;
        while (enumerator.MoveNext()) {
            n++;
        }
        return n;
    }

    public static IEnumerable<TSource> MyWhere<TSource>(IEnumerable<TSource> that, Func<TSource, bool> predicate)
    {
        IEnumerator<TSource> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext()) {
            if (predicate(enumerator.Current)) {
                yield return enumerator.Current;
            }
        }
    }

    public static T MyFirst<T>(IEnumerable<T> that, Func<T, bool> predicate)
    {
        using IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext()) {
            T current = enumerator.Current;
            if (predicate(current)) {
                return current;
            }
        }
        throw new InvalidOperationException();
    }

    public static bool MyAny<T>(IEnumerable<T> that, Func<T, bool> predicate)
    {
        IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext()) {
            if (predicate(enumerator.Current)) {
                return true;
            }
        }
        return false;
    }

    public static IEnumerable<TResult> MyMap<TSource, TResult>(IEnumerable<TSource> that, Func<TSource, TResult> projection)
    {
        IEnumerator<TSource> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext()) {
            yield return projection(enumerator.Current);
        }
    }
}
