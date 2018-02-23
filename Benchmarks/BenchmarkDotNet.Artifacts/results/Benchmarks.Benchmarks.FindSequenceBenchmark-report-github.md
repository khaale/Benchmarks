``` ini

BenchmarkDotNet=v0.10.12, OS=Windows 10 Redstone 3 [1709, Fall Creators Update] (10.0.16299.248)
Intel Core i7-4700MQ CPU 2.40GHz (Haswell), 1 CPU, 8 logical cores and 4 physical cores
Frequency=2338344 Hz, Resolution=427.6531 ns, Timer=TSC
.NET Core SDK=2.1.2
  [Host]     : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.3 (Framework 4.6.25815.02), 64bit RyuJIT


```
|               Method | Multiplier |         Mean |        Error |       StdDev | Scaled | ScaledSD |
|--------------------- |----------- |-------------:|-------------:|-------------:|-------:|---------:|
| **AggregationImmutable** |          **1** |   **7,503.2 ns** |    **42.132 ns** |    **39.410 ns** |  **32.97** |     **0.28** |
|   AggregationMutable |          1 |   1,314.8 ns |     7.169 ns |     6.706 ns |   5.78 |     0.05 |
|     ForeachImmutable |          1 |   7,437.5 ns |    25.753 ns |    24.089 ns |  32.68 |     0.24 |
|       ForeachMutable |          1 |   1,146.8 ns |    10.428 ns |     8.708 ns |   5.04 |     0.05 |
| ForeachMutableWithIf |          1 |   1,129.8 ns |     9.871 ns |     9.233 ns |   4.96 |     0.05 |
|           ForMutable |          1 |     227.6 ns |     1.697 ns |     1.588 ns |   1.00 |     0.00 |
|                      |            |              |              |              |        |          |
| **AggregationImmutable** |         **10** | **247,667.0 ns** |   **489.839 ns** |   **409.037 ns** | **125.72** |     **2.31** |
|   AggregationMutable |         10 |  13,051.1 ns |    63.313 ns |    59.223 ns |   6.62 |     0.12 |
|     ForeachImmutable |         10 | 246,832.6 ns | 1,621.160 ns | 1,516.434 ns | 125.30 |     2.42 |
|       ForeachMutable |         10 |  11,803.0 ns |   227.325 ns |   287.494 ns |   5.99 |     0.18 |
| ForeachMutableWithIf |         10 |  11,354.5 ns |   128.550 ns |   107.345 ns |   5.76 |     0.12 |
|           ForMutable |         10 |   1,970.7 ns |    46.690 ns |    38.988 ns |   1.00 |     0.00 |
