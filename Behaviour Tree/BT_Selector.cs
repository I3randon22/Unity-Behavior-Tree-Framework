using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Selector : BT_Node
{
    protected List<BT_Node> nodes = new List<BT_Node>();

    public BT_Selector(List<BT_Node> nodes)
    {
        this.nodes = nodes;
    }

    public override BT_NodeState Evaluate()
    {
        foreach (var node in nodes)
        {
            switch (node.Evaluate())
            {
                case BT_NodeState.SUCCESS:
                    nodeState = BT_NodeState.SUCCESS;
                    return nodeState;
                case BT_NodeState.FAILURE:
                    break;
                case BT_NodeState.RUNNING:
                    nodeState = BT_NodeState.RUNNING;
                    return nodeState;

                default:
                    break;
            }
        }
        nodeState = BT_NodeState.FAILURE;
        return nodeState;
    }
}
