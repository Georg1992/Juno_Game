using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PositionPrefab : MonoBehaviour
{
    private Collider m_collider;

    private void Start()
    {
        m_collider = this.GetComponent<Collider>();
    }
    private void Update()
    {
        MissionTargeting();

    }

    private void MissionTargeting(){
        Ray r = Game.gameCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(m_collider.Raycast(r, out hit, float.MaxValue)){
            Debug.Log(m_collider.name);
            if(Input.GetMouseButtonUp(0)){
            SceneManager.LoadScene(m_collider.name, LoadSceneMode.Additive);
            }

        }

    }
}
