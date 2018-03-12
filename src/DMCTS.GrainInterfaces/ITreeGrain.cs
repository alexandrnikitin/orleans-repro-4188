using System;
using System.Threading.Tasks;
using Orleans;

namespace DMCTS.GrainInterfaces
{
    public interface ITreeGrain<TAction> : IGrainWithGuidKey where TAction : IAction
    {
        Task<INodeView<TAction>> GetTopAction();
    }
}