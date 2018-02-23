``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4700MQ CPU 2.40GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2338344 Hz, Resolution=427.6531 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|               Method |     Mean |     Error |    StdDev |
|--------------------- |---------:|----------:|----------:|
| AggregationImmutable | 7.646 us | 0.0753 us | 0.0667 us |
|   AggregationMutable | 1.798 us | 0.0301 us | 0.0267 us |
|     ForeachImmutable | 8.105 us | 0.0658 us | 0.0615 us |
|       ForeachMutable | 1.694 us | 0.0102 us | 0.0095 us |
| ForeachMutableWithIf | 1.656 us | 0.0064 us | 0.0060 us |
