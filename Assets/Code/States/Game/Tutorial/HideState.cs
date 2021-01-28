using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HideState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Hiding Juno Geometry");

        Scene s = SceneManager.GetSceneByName("Juno");
        GameObject go = Game.FindControllerFromScene(s);
        UIController ui = Game.uiController;
        Dialogue d = ui.m_dialogue;
        d.Hide();
        JunoController c = go.GetComponent<JunoController>();
        c.Hide();
    }
}
