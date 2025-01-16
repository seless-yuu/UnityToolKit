
namespace HW.Logic
{
    public interface ICommand
    {
        public string Name { get; }
        public int Priority { get; }

        public void Execute();
    }
}
