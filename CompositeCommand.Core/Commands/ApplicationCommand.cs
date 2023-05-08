using Prism.Commands;

namespace CompositeCommands.Core.Commands
{
    public interface IApplicationCommand
    {
        CompositeCommand SaveAllCommand { get; }
    }

    public class ApplicationCommand : IApplicationCommand
    {
        public CompositeCommand SaveAllCommand { get; } = new CompositeCommand();
    }
}
