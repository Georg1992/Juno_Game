using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial_NewGame_Step2 : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Tutorial State Step2 Enter");

        Game.SetDialogueText("BLALBLBLALBA");
    
    }
}
