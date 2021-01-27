
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShowState : StateMachineBehaviour
{
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Show Juno State");
        Scene s = SceneManager.GetSceneByName("Juno");
        GameObject ob = Game.FindControllerFromScene(s);
        JunoController c = ob.GetComponent<JunoController>();
        c.Show();


    }
}
