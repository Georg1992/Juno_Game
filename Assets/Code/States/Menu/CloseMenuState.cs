using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CloseMenuState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Close Menu state enter.");
        Scene s = SceneManager.GetSceneByName("UI");
        GameObject go = Game.FindControllerFromScene(s);
        UIController c = go.GetComponent<UIController>();
        c.HideMenu();


    }
}
