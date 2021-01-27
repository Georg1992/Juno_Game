using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OpenMenuState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("OpenMenu state enter.");
        Scene s = SceneManager.GetSceneByName("UI");
        GameObject go = Game.FindControllerFromScene(s);
        UIController c = go.GetComponent<UIController>();
        c.ShowMenu();

    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if(Input.anyKeyDown){
            Game.gameStateMachine.SetTrigger("StartNewGame");
        }
    }
}
