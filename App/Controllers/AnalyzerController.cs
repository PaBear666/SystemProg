using App.Controllers.Abstractions;
using App.Infrastructure;
using App.Infrastructure.Analyzer;
using App.Infrastructure.Analyzer.States;

namespace App.Controllers
{
    internal class AnalyzerController : IAnalyzerController
    {
        private readonly ILogger _logger;

        public AnalyzerController(ILogger logger)
        {
            _logger = logger;
        }

        public AnalyzerResult Execute(string code)
        {

            Context context = new Context(new INT_State(),code);
            return context.Result;
        }
    }
}
