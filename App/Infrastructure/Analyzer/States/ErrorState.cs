using App.Infrastructure.Analyzer.Abstractions;

namespace App.Infrastructure.Analyzer.States
{
    class ErrorState : State
    { 
        public override void Execute(string code)
        {
            Context.ErrorResult();
        }
    }
}
