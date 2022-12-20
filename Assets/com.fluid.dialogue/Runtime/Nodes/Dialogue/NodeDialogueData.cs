using System;
using System.Linq;
using CleverCrow.Fluid.Dialogues.Graphs;
using Gameslab.UnityLocalizationExtension;
using UnityEditor;
using UnityEngine;
using UnityEngine.Localization;

namespace CleverCrow.Fluid.Dialogues.Nodes {
    [CreateMenu("Dialogue", 1)]
    public class NodeDialogueData : NodeDataChoiceBase {
        public ActorDefinition actor;

        public SimpleLocalizedString dialogue;

        protected override string DefaultName => "Dialogue";
        public override LocalizedString Text => dialogue;

        public override INode GetRuntime (IGraph graphRuntime, IDialogueController controller) {
            return new NodeDialogue(
                graphRuntime,
                UniqueId,
                actor,
                dialogue,
                children.ToList<INodeData>(),
                choices.Select(c => c.GetRuntime(graphRuntime, controller)).ToList(),
                conditions.Select(c => c.GetRuntime(graphRuntime, controller)).ToList(),
                enterActions.Select(a => a.GetRuntime(graphRuntime, controller)).ToList(),
                exitActions.Select(a => a.GetRuntime(graphRuntime, controller)).ToList()
            );
        }
    }
}
