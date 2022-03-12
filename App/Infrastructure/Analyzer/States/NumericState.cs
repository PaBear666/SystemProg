using App.Infrastructure.Analyzer.Abstractions;
using App.Infrastructure.Analyzer.States;

namespace App.Infrastructure.States.Analyzer
{
    class NumericState : State
    {
        private string _variableName;
        private string _number;
        public NumericState()
        {
        
        }

        public NumericState(string variableName)
        {
            _variableName = variableName;
        }

        public override void Execute(string code)
        {
            string memory = "";
            int index = 0;

            while (index < code.Length
                && code[index] != ' '
                && code[index] != ';'
                )
            {
                memory += code[index];
                index++;
            }

            if (index >= code.Length)
            {
                Context.TransitionTo(new ErrorState());
                return;
            }

            if(code[index] == ';')
            {
                Context.TransitionTo(new FinishState(), index);
                return;
            }

            if (code[index] == ' ')
            {
                if (index + 1 < code.Length && code[index + 1] == ';')
                {
                    Context.TransitionTo(new FinishState(), index);
                }
                else
                {
                    Context.TransitionTo(new ErrorState());
                }
                return;
            }
        }
    }
}
