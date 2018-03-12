using System;
using System.Runtime.Serialization;
using DMCTS.GrainInterfaces;

namespace Rides
{
    [Serializable]
    //[KnownType(typeof(MakeRideAction))]
    public class MakeRideAction : IAction
    {
    }
}