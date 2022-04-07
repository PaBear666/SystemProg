using App.Controllers.Abstractions;
using App.Infrastructure;
using App.Infrastructure.Analyzer;

namespace App.Controllers
{
    internal class AnalyzerModel : IAnalyzerModel
    {
        private readonly ILogger _logger;

        public AnalyzerModel(ILogger logger)
        {
            _logger = logger;
        }

        public AnalyzerResult Execute(string code)
        { 
            Context context = new Context(code);
            return context.Result;
        }
    }
}
