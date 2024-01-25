using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class BT_Node
{
    protected BT_NodeState nodeState;
    public BT_NodeState getNodeState { get { return nodeState; } }
    public abstract BT_NodeState Evaluate();
}

public enum BT_NodeState
{
    SUCCESS, FAILURE, RUNNING
}
