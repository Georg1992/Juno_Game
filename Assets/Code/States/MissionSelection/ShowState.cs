using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Juno.JunoStates.MissionSelection{
    public class ShowState : StateMachineBehaviour
    {
        public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            Debug.Log("Show Mission Selection State");

            Scene s = SceneManager.GetSceneByName("MissionSelection");
            GameObject go = Game.FindControllerFromScene(s);
            MissionSelectionController c = go.GetComponent<MissionSelectionController>();
            SceneManager.SetActiveScene(s);
            c.Show();

        }
    }
}
