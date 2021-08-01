
namespace HBFramework
{
    /// <summary>
    /// 命令抽象基类
    /// </summary>
    public abstract class Command
    {
        /// <summary>
        /// 执行命令
        /// </summary>
        public abstract void Execute();
        /// <summary>
        /// 命令是否执行完毕
        /// </summary>
        public abstract bool IsFinished { get; }
    }
}
