using System.Collections;

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
        while (enumerator.MoveNext())
        {
            n++;
        }
        return n;
    }

    public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> that, Func<TSource, bool> predicate)
    {
        IEnumerator<TSource> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (predicate(enumerator.Current))
            {
                yield return enumerator.Current;
            }
        }
    }

    public static T MyFirst<T>(this IEnumerable<T> that, Func<T, bool> predicate)
    {
        using IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            T current = enumerator.Current;
            if (predicate(current))
            {
                return current;
            }
        }
        throw new InvalidOperationException();
    }

    public static bool MyAny<T>(this IEnumerable<T> that, Func<T, bool> predicate)
    {
        IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (predicate(enumerator.Current))
            {
                return true;
            }
        }
        return false;
    }

    public static T MyFirst<T>(this IEnumerable<T> that)
    {
        IEnumerator<T>? enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            return enumerator.Current;

        }
        throw new InvalidOperationException();
    }

    public static IEnumerable<TResult> MyMap<TSource, TResult>(this IEnumerable<TSource> that, Func<TSource, TResult> projection)
    {
        IEnumerator<TSource>? enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            yield return projection(enumerator.Current);
        }
    }

    public static bool Any<T>(this IEnumerable<T> that)
    {
        IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            return true;
        }
        return false;
    }
    public static bool Any<T>(this IEnumerable<T> that, Func<T, bool> predicate)
    {
        IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (predicate(enumerator.Current))
            {
                return true;
            }
        }
        return false;
    }
    public static bool All<T>(this IEnumerable<T> that, Func<T, bool> predicate)
    {
        IEnumerator<T> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            if (!predicate(enumerator.Current))
            {
                return false;
            }
        }
        return true;
    }

    public static TAcc MyAggregate<TAcc, TSource>(this IEnumerable<TSource> that, TAcc seed, Func<TAcc, TSource, TAcc> fold)
    {
        var value = seed;
        IEnumerator<TSource> enumerator = that.GetEnumerator();
        while (enumerator.MoveNext())
        {
            value = fold(value, enumerator.Current);
        }
        return value;
    }

    public static IEnumerable<T> MyConcat<T>(this IEnumerable<T> that, IEnumerable<T> other)
    {
        var enumerator1 = that.GetEnumerator();
        var enumerator2 = other.GetEnumerator();

        while (enumerator1.MoveNext())
        {
            yield return enumerator1.Current;
        }
        while (enumerator2.MoveNext())
        {
            yield return enumerator2.Current;
        }
    }

    public static IEnumerable<T> MyUnion<T>(this IEnumerable<T> that, IEnumerable<T> other, IEqualityComparer<T> comparer)
    {
        var set = new HashSet<T>(comparer);

        var enumerator1 = that.GetEnumerator();
        var enumerator2 = other.GetEnumerator();

        while (enumerator1.MoveNext())
        {
            if (set.Add(enumerator1.Current))
            {
                yield return enumerator1.Current;
            }
        }
        while (enumerator2.MoveNext())
        {
            if (set.Add(enumerator2.Current))
            {
                yield return enumerator2.Current;
            }
        }
    }

    public static IEnumerable<T> MyExcept<T>(this IEnumerable<T> that, IEnumerable<T> other)
    {
        var blacklist = new HashSet<T>(other);
        var enumerator1 = that.GetEnumerator();

        while (enumerator1.MoveNext())
        {
            if (blacklist.Add(enumerator1.Current))
            {
                yield return enumerator1.Current;
            }
        }
    }

    public static IEnumerable<T> MyIntersect<T>(this IEnumerable<T> that, IEnumerable<T> other)
    {
        var itemsThatExist = new HashSet<T>(other);
        var enumerator1 = that.GetEnumerator();

        while (enumerator1.MoveNext())
        {
            if (itemsThatExist.Remove(enumerator1.Current))
            {
                yield return enumerator1.Current;
            }
        }
    }

    public static Dictionary<TKey, TValue> MyToDictionary<TSource, TKey, TValue>(
        this IEnumerable<TSource> that,
        Func<TSource, TKey> keySelector,
        Func<TSource, TValue> valueSelector,
        IEqualityComparer<TSource> comparer)
    {
        var dictionary = new Dictionary<TKey, TValue>();
        foreach (var item in that)
        {
            dictionary.Add(keySelector(item), valueSelector(item));
        }
        return dictionary;
    }

    public static IEnumerable<TResult> MyCast<TResult>(this IEnumerable that)
    {
        foreach (var item in that)
        {
            yield return (TResult)item;
        }
    }

    public static IEnumerable<TResult> MyOfType<TResult>(this IEnumerable that)
    {
        foreach (var item in that)
        {
            if (item is TResult result)
            {
                yield return result;
            }
        }
    }
}

