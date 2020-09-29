#I "../packages/Plotly.NET/lib/netstandard2.0/"
#r @"Plotly.NET.dll"

open Plotly.NET

(** 
## Include Chart directly*)

Chart.Line([1,2;2,3])
(*** include-it ***)

(** 
## Include Evaluated HTML string*)

Chart.Line([1,2;2,3])
|> GenericChart.toChartHtmlWithSize 700 500
(*** include-it ***)

(** 
## HTML String*)

<div id="e6b37480-9773-4002-a4c5-428cb8731fdd" style="width: 700px; height: 500px;"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-latest.min'}});
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"scatter","x":[1,2],"y":[2,3],"mode":"lines","marker":{}}];
            var layout = {};
            var config = {};
            Plotly.newPlot('e6b37480-9773-4002-a4c5-428cb8731fdd', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) { 
                var script = document.createElement("script"); 
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js"); 
                script.onload = function(){
                    renderPlotly();
                };
                document.getElementsByTagName("head")[0].appendChild(script); 
            }
            else {
                renderPlotly();
            }
</script>


(*** raw ***)

<div id="e6b37480-9773-4002-a4c5-428cb8731fdd" style="width: 700px; height: 500px;"><!-- Plotly chart will be drawn inside this DIV --></div>
<script type="text/javascript">

            var renderPlotly = function() {
            var fsharpPlotlyRequire = requirejs.config({context:'fsharp-plotly',paths:{plotly:'https://cdn.plot.ly/plotly-latest.min'}});
            fsharpPlotlyRequire(['plotly'], function(Plotly) {

            var data = [{"type":"scatter","x":[1,2],"y":[2,3],"mode":"lines","marker":{}}];
            var layout = {};
            var config = {};
            Plotly.newPlot('e6b37480-9773-4002-a4c5-428cb8731fdd', data, layout, config);
});
            };
            if ((typeof(requirejs) !==  typeof(Function)) || (typeof(requirejs.config) !== typeof(Function))) { 
                var script = document.createElement("script"); 
                script.setAttribute("src", "https://cdnjs.cloudflare.com/ajax/libs/require.js/2.3.6/require.min.js"); 
                script.onload = function(){
                    renderPlotly();
                };
                document.getElementsByTagName("head")[0].appendChild(script); 
            }
            else {
                renderPlotly();
            }
</script>
