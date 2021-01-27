using UnityEngine;
using UnityEngine.SceneManagement;


public class LodingGameState : StateMachineBehaviour
{
    private Scene [] scenes;
    public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Debug.Log("Loading Game State Enter");
        SceneManager.LoadScene("Opening", LoadSceneMode.Additive);
        SceneManager.LoadScene("UI", LoadSceneMode.Additive);
    }

    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex )
    {
        Scene opening = SceneManager.GetSceneByName("Opening");
        Scene ui = SceneManager.GetSceneByName("UI");
        scenes = new Scene[2]{ui, opening};
        Game.SceneValidation(scenes);
        animator.SetTrigger("OpeningVideo");

        
        
    }

   

    
}
