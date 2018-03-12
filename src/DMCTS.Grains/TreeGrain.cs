using System;
using System.Threading.Tasks;
using DMCTS.GrainInterfaces;
using Orleans;

namespace DMCTS.Grains
{
    public class TreeGrain<TAction> : Grain, ITreeGrain<TAction> where TAction : IAction
    {
        public Task<INodeView<TAction>> GetTopAction()
        {
            return Task.FromResult<INodeView<TAction>>(new NodeView<TAction>(Guid.NewGuid(), default(TAction), false, 0.0));
        }
    }
}