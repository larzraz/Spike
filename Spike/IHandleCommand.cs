using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spike
{
    public interface IHandleCommand<in T> { Task Handle(T command); }
    
}
