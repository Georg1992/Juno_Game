using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial_NewGame_Step1State : StateMachineBehaviour
{

    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Tutorial State Step1 Enter");

        Game.SetDialogueText("Hello commander. Welcome to the Juno");
    
    }
    public override void OnStateUpdate(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        if(Input.anyKeyDown){
            Game.gameStateMachine.SetTrigger("Tutorial_NewGame_Step2");
        }
    }
}

