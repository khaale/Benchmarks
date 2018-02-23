using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace Benchmarks.Benchmarks
{
    public class FindSequenceBenchmark
    {
        private static readonly  ICollection<int> list = ImmutableList.Create(3, 1, 2, 10, 12, 228, 11, 1488, 7, 6, 8).OrderBy(x => x).ToArray();

        [Benchmark]
        public int AggregationImmutable()
        {
            // Aggregation + Immutable
            return list
                .Aggregate(ImmutableList<ImmutableList<int>>.Empty, (ints, i) =>
                    ints.IsEmpty || ints.Last().Last() != i - 1
                        ? ints.Add(ImmutableList.Create(i))
                        : ints.Replace(ints.Last(), ints.Last().Add(i)))
                .Count;
        }

        [Benchmark]
        public int AggregationMutable()
        {
            // Aggregation + Mutable
            List<T> AddToList<T>(List<T> lst, T value)
            {
                lst.Add(value);
                return lst;
            }

            List<T> ReplaceLastInList<T>(List<T> lst, T value)
            {
                lst[lst.Count - 1] = value;
                return lst;
            }

            return list
                .OrderBy(x => x)
                .Aggregate(new List<List<int>>(), (ints, i) => ints.Count == 0 || ints.Last().Last() != i - 1
                    ? AddToList(ints, new List<int>() {i})
                    : ReplaceLastInList(ints, AddToList(ints.Last(), i)))
                .Count;
        }

        [Benchmark]
        public int ForeachImmutable()
        {
            // Foreach + Immutable
            var ints1 = ImmutableList<ImmutableList<int>>.Empty;
            foreach (var i in list.OrderBy(x => x))
            {
                ints1 = ints1.IsEmpty || ints1.Last().Last() != i - 1
                    ? ints1.Add(ImmutableList.Create(i))
                    : ints1.Replace(ints1.Last(), ints1.Last().Add(i));
            }
            return ints1.Count;

        }

        [Benchmark]
        public int ForeachMutable()
        {
            // Aggregation + Mutable
            List<T> AddToList<T>(List<T> lst, T value)
            {
                lst.Add(value);
                return lst;
            }

            List<T> ReplaceLastInList<T>(List<T> lst, T value)
            {
                lst[lst.Count - 1] = value;
                return lst;
            }

            // Foreach + mutable
            var ints2 = new List<List<int>>();
            foreach (var i in list.OrderBy(x => x))
            {
                ints2 = ints2.Count == 0 || ints2.Last().Last() != i - 1
                    ? AddToList(ints2, new List<int>() { i })
                    : ReplaceLastInList(ints2, AddToList(ints2.Last(), i));
            }
            return ints2.Count;
        }

        [Benchmark]
        public int ForeachMutableWithIf()
        {
            // Foreach + mutable with if
            var ints2 = new List<List<int>>();
            foreach (var i in list.OrderBy(x => x))
            {
                if (ints2.Count == 0 || ints2.Last().Last() != i - 1)
                {
                    ints2.Add(new List<int>() { i });
                }
                else
                {
                    ints2.Last().Add(i);
                }
            }
            return ints2.Count;
        }
    }
}
