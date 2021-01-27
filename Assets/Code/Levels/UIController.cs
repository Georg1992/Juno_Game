using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject m_menuPrefab;
    public GameObject m_dialoguePrefab;

    private void Awake()
    {

        m_menuPrefab.SetActive(false);
        m_dialoguePrefab.SetActive(false);
    }

    public void ShowMenu(){
        m_menuPrefab.SetActive(true);
    }
    public void HideMenu(){
        m_menuPrefab.SetActive(false);
    }
}
