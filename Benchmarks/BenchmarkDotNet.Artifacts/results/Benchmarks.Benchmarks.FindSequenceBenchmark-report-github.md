``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4700MQ CPU 2.40GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2338344 Hz, Resolution=427.6531 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|               Method |       Mean |      Error |     StdDev |
|--------------------- |-----------:|-----------:|-----------:|
| AggregationImmutable | 8,219.5 ns | 163.619 ns | 212.751 ns |
|   AggregationMutable | 1,782.9 ns |   8.445 ns |   6.593 ns |
|     ForeachImmutable | 8,436.5 ns |  67.136 ns |  62.799 ns |
|       ForeachMutable | 1,725.8 ns |   9.724 ns |   9.096 ns |
| ForeachMutableWithIf | 1,681.6 ns |   7.433 ns |   6.953 ns |
|           ForMutable |   260.7 ns |   1.922 ns |   1.501 ns |
