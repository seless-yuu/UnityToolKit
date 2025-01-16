
namespace HW.Logic
{
    public interface ISceneCommand : ICommand
    {
    }

    public interface ISceneUpdateCommand : ISceneCommand
    {
        public float DeltaTime { get; }
    }

    public interface ISceneInputCommand : ISceneCommand
    {
    }

    public interface ISceneSleepCommand : ISceneCommand
    {
    }

    public interface ISceneWakeupCommand : ISceneCommand
    {
    }

    public interface ISceneNode
    {
        public void DoCommand(ISceneCommand command)
        {
        }

        protected void OnUpdate(ISceneUpdateCommand param);
        protected void OnInput(ISceneInputCommand param);
        protected void OnSleep(ISceneSleepCommand param);
        protected void OnWakeup(ISceneWakeupCommand param);

        protected void OnEvent(ISceneCommand param);
    }
}
