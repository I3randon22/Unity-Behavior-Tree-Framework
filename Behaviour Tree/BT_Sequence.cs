using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Sequence : BT_Node
{
    protected List<BT_Node> nodes = new List<BT_Node>();

    public BT_Sequence(List<BT_Node> nodes)
    {
        this.nodes = nodes;
    }

    public override BT_NodeState Evaluate()
    {
        bool nodeRunning = false;
        foreach(var node in nodes)
        {
            switch(node.Evaluate())
            {
                case BT_NodeState.SUCCESS:
                    break;
                case BT_NodeState.FAILURE:
                    nodeState = BT_NodeState.FAILURE;
                    return nodeState;
                case BT_NodeState.RUNNING:
                    nodeRunning = true;
                    break;
                default:
                    break;
            }
        }
        nodeState = nodeRunning ? BT_NodeState.SUCCESS : BT_NodeState.RUNNING;
        return nodeState;
    }
}
