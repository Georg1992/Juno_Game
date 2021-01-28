using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Game 
{
    public static UIController uiController;
    public static Animator gameStateMachine;
    public static Camera gameCamera;


    public static GameObject FindControllerFromScene(Scene s){
        foreach(GameObject go in s.GetRootGameObjects()){
            if(go.name.ToLower() == "controller"){
                return go;
            }
        }
        return null;
    }

     public static bool SceneValidation(Scene [] scenes){
        foreach(Scene s in scenes){
            if( s != null && s.isLoaded){
                return true;
            }
            else{
                Debug.Log($"{s} is not loaded");
            }
        }
        return false;
    }

    public static GameObject FindGeometryFromScene(Scene s){
        foreach(GameObject go in s.GetRootGameObjects()){
            if(go.name.ToLower() == "geometry"){
                return go;
            }
        }
        return null;
    }

    public static void SetDialogueText(string text){
        if(uiController == null){
            Scene s = SceneManager.GetSceneByName("UI");
            GameObject go = FindControllerFromScene(s);
            uiController = go.GetComponent<UIController>();
        }
        Dialogue d = uiController.m_dialoguePrefab.GetComponent<Dialogue>();
        d.Show();
        d.SetText(text);
    }
}
