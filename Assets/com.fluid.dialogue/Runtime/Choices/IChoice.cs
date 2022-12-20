using CleverCrow.Fluid.Dialogues.Nodes;
using UnityEngine.Localization;

namespace CleverCrow.Fluid.Dialogues.Choices {
    public interface IChoice : IUniqueId {
        LocalizedString Text { get; }
        bool IsValid { get; }

        INode GetValidChildNode ();
    }
}
