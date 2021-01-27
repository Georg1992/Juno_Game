using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesState : StateMachineBehaviour
{
    private Scene m_Juno;
    private Scene [] scenes;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Load Scene state enter.");
        SceneManager.LoadScene("Juno", LoadSceneMode.Additive);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_Juno = SceneManager.GetSceneByName("Juno");
        scenes = new Scene[]{m_Juno};

        if(Game.SceneValidation(scenes)){
            SceneManager.SetActiveScene(m_Juno);
            Game.gameStateMachine.SetTrigger("Juno");
        }

    }
}
