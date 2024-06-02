namespace Csharp_DatVeMayBay.Command_Pattern
{
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public async Task ExecuteCommand()
        {
            await _command.ExecuteAsync();
        }
    }
}
