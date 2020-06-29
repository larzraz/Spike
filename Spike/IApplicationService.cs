using System.Threading.Tasks;

namespace Spike
{
    public interface IApplicationService { Task Handle(object command); }
}