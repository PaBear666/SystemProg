using App.Infrastructure.Analyzer.Abstractions;
using System.Text.RegularExpressions;

namespace App.Infrastructure.Analyzer
{
    public class Context
    {
        public AnalyzerResult Result { get; }
        private State _currentState;
        private string _code;

        public Context(State beginState, string code)
        {
            Result = new AnalyzerResult();
            _code = Regex.Replace(code, @"\s+", " ");
            TransitionTo(beginState);
        }

        public void TransitionTo(State state, int index = 0)
        {
            if(index != 0)
            {
                _code = _code.Remove(0, index + 1);
            }
            _code = _code.TrimStart(new[] { ' ' });
            _currentState = state;
            _currentState.SetContext(this);
            _currentState.Execute(_code);
        }

        public void ErrorResult()
        {
            Result.Compiled = false;
        }

        public void FinishResult()
        {
            Result.Compiled = true;
        }

    }
}
