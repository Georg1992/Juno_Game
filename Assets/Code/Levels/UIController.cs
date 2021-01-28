using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] private GameObject m_menuPrefab;
    public GameObject m_dialoguePrefab;
    public Dialogue m_dialogue;

    private void Awake()
    {

        m_menuPrefab.SetActive(false);
        m_dialoguePrefab.SetActive(false);
        m_dialogue= m_dialoguePrefab.GetComponent<Dialogue>();
    }

    public void ShowMenu(){
        m_menuPrefab.SetActive(true);
    }
    public void HideMenu(){
        m_menuPrefab.SetActive(false);
    }
}
