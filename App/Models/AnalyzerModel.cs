using App.Controllers.Abstractions;
using App.Infrastructure;
using App.Infrastructure.Analyzer;
using System.Windows.Forms;

namespace App.Controllers
{
    internal class AnalyzerModel : IAnalyzerModel
    {
        Analyzer _analyzer;
        CsharpDesign _design;
        private readonly ILogger _logger;

        public AnalyzerModel(ILogger logger)
        {
            _logger = logger;
            _design = CsharpDesign.DoWhile;
            _analyzer = new Analyzer();
        }

        public AnalyzerResult Execute(string code)
        {
            _analyzer.Excecute(code, _design);
            return _analyzer.Result;
        }

        public void SetDesign(CsharpDesign design)
        {
            _design = design;
        }
    }
}
