namespace App.Infrastructure.Analyzer.Abstractions
{
    public abstract class State
    {
        public Context Context { get; private set; }
        public State ChangeStateAfterExecute { get; set; }
        public void SetContext(Context context)
        {
            Context = context;
        }
        public bool NeedEndRow { get; set; }
        abstract public void Execute(string code);
    }
}
