using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JunoController : MonoBehaviour
{
    private GameObject m_geometry;
    private GameObject m_lights;

    private void Start(){
        Scene s = SceneManager.GetSceneByName("Juno");
        m_geometry = Game.FindGeometryFromScene(s);
        foreach(GameObject go in s.GetRootGameObjects()){
            if(go.name.ToLower() == "lights")
            {
                m_lights = go;
            }
        }
        Hide();
    }

    public void Hide(){
        m_geometry.SetActive(false);
        m_lights.SetActive(false);
    }

    public void Show(){
        m_geometry.SetActive(true);
        m_lights.SetActive(true);
    }
}
