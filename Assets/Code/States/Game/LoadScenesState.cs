using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenesState : StateMachineBehaviour
{
    private Scene m_Juno;
    private Scene m_MissionSelection;
    private Scene [] scenes;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Load Scene state enter.");
        SceneManager.LoadScene("Juno", LoadSceneMode.Additive);
        SceneManager.LoadScene("MissionSelection", LoadSceneMode.Additive);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        m_Juno = SceneManager.GetSceneByName("Juno");
        m_MissionSelection = SceneManager.GetSceneByName("MissionSelection");
        scenes = new Scene[]{m_Juno, m_MissionSelection};

        if(Game.SceneValidation(scenes)){
            SceneManager.SetActiveScene(m_Juno);
            Game.gameStateMachine.SetTrigger("Juno");
        }

    }
}
