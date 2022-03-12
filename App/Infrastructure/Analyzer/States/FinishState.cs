using App.Infrastructure.Analyzer.Abstractions;

namespace App.Infrastructure.Analyzer.States
{
    class FinishState : State
    {
        public override void Execute(string code)
        {
            Context.FinishResult();
        }
    }
}
