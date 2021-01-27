using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Menu State enter.");

        Scene s = SceneManager.GetSceneByName("UI");
        GameObject go = Game.FindControllerFromScene(s);
        UIController c = go.GetComponent<UIController>();
        c.ShowMenu();

    }
}
