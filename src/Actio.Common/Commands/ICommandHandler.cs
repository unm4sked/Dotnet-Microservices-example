using System.Threading.Tasks;

namespace Actio.Common.Commands
{
    //Marker
    public interface ICommandHandler<in T> where T: ICommand
    {
        Task HandleAsync(T commadn);
    }
}