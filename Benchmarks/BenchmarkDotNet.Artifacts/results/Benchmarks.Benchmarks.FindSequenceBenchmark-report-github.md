``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4700MQ CPU 2.40GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2338344 Hz, Resolution=427.6531 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|               Method |       Mean |     Error |    StdDev |
|--------------------- |-----------:|----------:|----------:|
| AggregationImmutable | 7,641.3 ns | 47.257 ns | 44.205 ns |
|   AggregationMutable | 1,359.6 ns |  5.892 ns |  5.223 ns |
|     ForeachImmutable | 7,499.7 ns | 21.953 ns | 20.535 ns |
|       ForeachMutable | 1,235.1 ns | 35.712 ns | 35.074 ns |
| ForeachMutableWithIf | 1,195.3 ns |  7.140 ns |  6.679 ns |
|           ForMutable |   269.1 ns |  4.173 ns |  3.903 ns |
