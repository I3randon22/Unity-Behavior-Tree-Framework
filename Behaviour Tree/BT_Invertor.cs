using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BT_Invertor : BT_Node
{
    protected BT_Node node;

    public BT_Invertor(BT_Node node)
    {
        this.node = node;
    }

    public override BT_NodeState Evaluate()
    {

        switch (node.Evaluate())
        {
            case BT_NodeState.SUCCESS:
                nodeState = BT_NodeState.FAILURE;
                break;
            case BT_NodeState.FAILURE:
                nodeState = BT_NodeState.SUCCESS;
                break;
            case BT_NodeState.RUNNING:
                nodeState = BT_NodeState.RUNNING;
                break;
            default:
                break;
        }
        return nodeState;
    }
}
