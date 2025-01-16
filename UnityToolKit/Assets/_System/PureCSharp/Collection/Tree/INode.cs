using System.Collections.Generic;

namespace HW.Collection
{
    public interface INode
    {
        public INode Parent { get; }
        public List<INode> Children { get; }

        public void SetParent(INode parent);
        public INode RemoveParent();

        public void AddChild(INode node);
        public void RemoveChildAll();
    }
}
