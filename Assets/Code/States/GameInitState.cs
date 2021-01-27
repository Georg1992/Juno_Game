using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInitState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("GameInit state enter.");
        Game.gameStateMachine = animator;
        animator.SetTrigger("LoadingGame");
    }

}
