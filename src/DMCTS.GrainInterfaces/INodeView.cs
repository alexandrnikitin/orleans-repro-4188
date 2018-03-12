using System;

namespace DMCTS.GrainInterfaces
{
    public interface INodeView<TAction> where TAction : IAction
    {
        Guid Id { get; set; }
        TAction Action { get; set; }
        bool IsFinished { get; set; }
        double Score { get; set; }
    }
}