using UnityEngine;
using UnityEngine.SceneManagement;

public class OpeningVideoState : StateMachineBehaviour
{
    private OpeningController m_controller;
   public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
   {
       Debug.Log("Opening Video State enter");
       Scene s = SceneManager.GetSceneByName("Opening");
       GameObject go = Game.FindControllerFromScene(s);
       m_controller = go.GetComponent<OpeningController>();
       m_controller.m_videoPlayer.Stop();
       m_controller.m_videoPlayer.loopPointReached +=  M_videoPlayer_loopPointReached;
       m_controller.m_videoPlayer.Play();


   }
    private void M_videoPlayer_loopPointReached(UnityEngine.Video.VideoPlayer video_player){
        SwitchToNextState();
    }

    private void SwitchToNextState(){
        m_controller.m_videoPlayer.Stop();
        SceneManager.UnloadSceneAsync("Opening");
        Game.gameStateMachine.SetTrigger("MyMenu");


    }


    


    public override void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
       if(Input.anyKeyDown){
           SwitchToNextState();
       }
    }


}
