using App.Infrastructure.Analyzer.States;
using App.Infrastructure.States.Analyzer;

namespace App.Infrastructure.Analyzer.Abstractions
{
    class VariableState : State
    {
        public VariableState()
        {
           
        }
        public string Name { get; private set; }

        public override void Execute(string code)
        {
            string variable = "";
            int index = 0;
            
            while (index < code.Length 
                && code[index] != ' ' 
                && code[index] != '=')
            {
                variable += code[index];
                index++;
            }

            if(index >= code.Length)
            {
                Context.TransitionTo(new ErrorState());
                return;
            }

            if(code[index] == ' ')
            {
                if (index + 1 < code.Length && code[index + 1] == '=')
                {
                    Context.TransitionTo(new NumericState(Name), index + 1);
                }
                else
                {
                    Context.TransitionTo(new ErrorState());
                }
                return;
            }

            if(code[index] == '=')
            {
                var numericState = new NumericState(Name)
                {
                    NeedEndRow = true
                };
                Context.TransitionTo(numericState, index);
            }
        }
    }
}
