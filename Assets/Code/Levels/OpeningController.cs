using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OpeningController : MonoBehaviour
{
    public VideoPlayer m_videoPlayer;
    public void PlayVideoOnCamera(Camera cam){
        m_videoPlayer.Play();
    }
}
