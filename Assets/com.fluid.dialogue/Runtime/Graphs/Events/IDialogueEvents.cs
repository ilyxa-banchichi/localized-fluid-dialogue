using System.Collections.Generic;
using CleverCrow.Fluid.Dialogues.Choices;
using CleverCrow.Fluid.Dialogues.Nodes;
using CleverCrow.Fluid.Utilities.UnityEvents;
using UnityEngine.Localization;

namespace CleverCrow.Fluid.Dialogues {
    public interface IDialogueEvents {
        IUnityEvent Begin { get; }
        IUnityEvent End { get; }
        IUnityEvent<IActor, LocalizedString> Speak { get; }
        IUnityEvent<IActor, LocalizedString, List<IChoice>> Choice { get; }
        IUnityEvent<INode> NodeEnter { get; }
    }
}
