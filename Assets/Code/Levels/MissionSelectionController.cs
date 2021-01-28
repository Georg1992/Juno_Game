using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionSelectionController : MonoBehaviour
{
    private GameObject m_geometry;
    public Camera m_camera;

    public void Start()
    {
        Scene s = SceneManager.GetSceneByName("MissionSelection");
        m_geometry = Game.FindGeometryFromScene(s);
        Hide();
    }

    public void Hide(){
        m_geometry.SetActive(false);
        m_camera.enabled = false;
    }
    
    public void Show(){
        m_geometry.SetActive(true);
        m_camera.enabled = true;
        Game.gameCamera.transform.position = m_camera.transform.position;
        Game.gameCamera.transform.rotation = m_camera.transform.rotation;


    }

}
                  
