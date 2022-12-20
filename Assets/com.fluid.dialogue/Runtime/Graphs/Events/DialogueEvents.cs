using System.Collections.Generic;
using CleverCrow.Fluid.Dialogues.Choices;
using CleverCrow.Fluid.Dialogues.Nodes;
using CleverCrow.Fluid.Utilities.UnityEvents;
using UnityEngine.Localization;

namespace CleverCrow.Fluid.Dialogues {
    public class DialogueEvents : IDialogueEvents {
        public IUnityEvent Begin { get; } = new UnityEventPlus();
        public IUnityEvent End { get; } = new UnityEventPlus();
        public IUnityEvent<IActor, LocalizedString> Speak { get; } = new UnityEventPlus<IActor, LocalizedString>();
        public IUnityEvent<IActor, LocalizedString, List<IChoice>> Choice { get; } = new UnityEventPlus<IActor, LocalizedString, List<IChoice>>();
        public IUnityEvent<INode> NodeEnter { get; } = new UnityEventPlus<INode>();
    }
}
