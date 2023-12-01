using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using NCalc;

namespace Lesson3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            chart1.ChartAreas[0].AxisX.Title = "x";
            chart1.ChartAreas[0].AxisY.Title = "Y";
        }

        private void createGraph_Click(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            var funs = input.Text.ToLower().Split(' ');

            foreach (var fun in funs)
            {
                var series = chart1.Series.Add($"fun {fun}");
                series.ChartType = SeriesChartType.Spline;
                series.MarkerStyle = MarkerStyle.Circle;
                var expression = ParserFunction(fun);
                for (var i = 0; i < 10; i++)
                {
                    expression.Parameters["x"] = i;
                    series.Points.AddXY(i, expression.Evaluate());
                }
            }
        }

        private Expression ParserFunction(string function)
        {
            var funs = new List<string>();

            var numberPattern = @"(\d+(\.\d*)?)";
            var variablePatter = @"([x])";
            var operatorPattern = @"([\+\-\*/\^])";
            var functionPattern = @"(sin|cos|tan|ctan)";

            var expressionPattern = $"{numberPattern}|{variablePatter}|{operatorPattern}|{functionPattern}";

            var matches = Regex.Matches(function, expressionPattern);

            foreach (Match match in matches)
            {
                funs.Add(match.Value);
                Console.WriteLine(match.Value);
            }

            for (var i = 0; i < funs.Count; i++)
            {
                if (Regex.IsMatch(funs[i], @"([\^])"))
                {
                    var before = funs.Take(i - 1).ToList();
                    var after = funs.Skip(i + 2).ToList();
                    var powFun = $"Pow({funs[i - 1]},{funs[i + 1]})";
                    funs = before.Concat(new[] { powFun }).Concat(after).ToList();
                    continue;
                }

                if (Regex.IsMatch(funs[i], functionPattern))
                {
                    var before = funs.Take(i).ToList();
                    var after = funs.Skip(i + 2).ToList();
                    //Делаем апперкейс первой буквы
                    var funFun = $"{funs[i][0].ToString().ToUpper()}{funs[i].Substring(1)}({funs[i + 1]})";
                    funs = before.Concat(new[] { funFun }).Concat(after).ToList();
                }
            }

            return new Expression(string.Join("", funs.ToArray()));
        }
    }
}