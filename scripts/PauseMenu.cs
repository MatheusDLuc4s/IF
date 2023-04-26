using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;


public class PauseMenu : MonoBehaviour
{
    public VideoPlayer player;
    [SerializeField] private AudioSource clicSFX;

    void Start()
    {
        player = GetComponent<VideoPlayer>();
    }
    
    public void PlayPause()
    {
        if(player.isPlaying == false)
        {
            clicSFX.Play();
            player.Play();
        }
        else
        {
            clicSFX.Play();
            player.Pause();
        }
    }
}

