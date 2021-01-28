using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
   public Image m_image;
   public Image m_panel;
   public Image m_panelOutline;
   public Text m_text;


   public void Show() {
       
       this.gameObject.SetActive(true);
       m_image.enabled = true;
       m_panel.enabled = true;
       m_panelOutline.enabled = true;
       m_text.enabled = true;
       m_text.text = "";

   }
   public void Hide(){
       this.gameObject.SetActive(false);
       m_image.enabled = false;
       m_panel.enabled = false;
       m_panelOutline.enabled = false;
       m_text.enabled = false;
       m_text.text = "";

   }

   public void SetText(string text){
       m_text.enabled = true;
       m_text.text = text;
   }
}
