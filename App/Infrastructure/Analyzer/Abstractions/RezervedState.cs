namespace App.Infrastructure.Analyzer.Abstractions
{
    abstract class RezervedState : State
    {
        abstract protected string ReservedWord { get; }
        abstract protected bool NeedSpaceAfterReserved { get; }
    }
}
