# FsDocsEvaluatedCharts

This repo is meant to illucidate the problem of integrating a formatted plotly chart into an evaluated FSharp script using the `FSharpFormatting` console tool [this issue](https://github.com/fsprojects/FSharp.Formatting/issues/611].)

### For reproduction do:

0. .NET Core 3.1.100 or higher 3.1 build must be installed
1. Download or clone the repo
2. Run `dotnet tool restore`
3. Run `dotnet paket restore`
4. Run `dotnet fsdocs build --eval`
5. Open `output/ChartTest.html` in your browser of choice

### Explanation:

`Include Chart directly` shows, how integrating a chart could work when using a custom FSI evaluator. Here just the regular `%O` formatting result is returned.

`Include Evaluated HTML string` shows, how integrating a chart could work in a indirect way, manually calling a function which creates a `html` string from the chart. The problem here is, that the resulting string gets put into `<code>` and `<pre>` tags, preventing it from being rendered correctly.

`HTML String` shows, how a correctly formatted, embeded chart looks like. For this the resulting HTML string from above was manually added to the FSharp script file.
