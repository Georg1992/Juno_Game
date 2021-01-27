using UnityEngine;

public class GameController : MonoBehaviour
{
    private Animator m_gameStateMachine;

    private void Start()
    {
        Debug.Log("Game start up.");
        
        InitStateMachine();
    }

    private void InitStateMachine()
    {
        Debug.Log("Initialize state machine.");
        m_gameStateMachine = this.GetComponent<Animator>();
    }

    private void Update()
    {
        //Debug.Log("Update");
        
    
    }
}