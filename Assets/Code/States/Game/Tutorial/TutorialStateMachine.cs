using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialStateMachine : StateMachineBehaviour
{
    
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Tutorial StateMachine Enter");
    }
}

