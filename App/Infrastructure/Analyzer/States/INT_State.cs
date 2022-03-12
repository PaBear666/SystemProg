using App.Infrastructure.Analyzer.Abstractions;

namespace App.Infrastructure.Analyzer.States
{
    class INT_State : RezervedState
    {
        protected override string ReservedWord => "int";

        protected override bool NeedSpaceAfterReserved => true;

        public override void Execute(string code)
        {
            var reservedWord = string.Empty;
            int index = 0;

            while(reservedWord != ReservedWord 
                && reservedWord.Length < ReservedWord.Length
                && index < code.Length)
            {
                reservedWord += code[index];
                index++;
            }
            
            if(index >= code.Length)
            {
                Context.TransitionTo(new ErrorState());
                return;
            }

            if(NeedSpaceAfterReserved && code[index] == ' ')
            {
                Context.TransitionTo(new VariableState(), index);
            }
            else
            {
                Context.TransitionTo(new ErrorState());
            }
        }
    }
}
