using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JunoController : MonoBehaviour
{
    private GameObject m_geometry;

    private void Start(){
        Scene s = SceneManager.GetSceneByName("Juno");
        m_geometry = Game.FindGeometryFromScene(s);
        Hide();
    }

    public void Hide(){
        m_geometry.SetActive(false);
    }

    public void Show(){
        m_geometry.SetActive(true);
    }
}
