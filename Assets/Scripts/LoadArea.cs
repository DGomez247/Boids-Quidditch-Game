using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using UnityEngine.UI;

public class LoadArea : MonoBehaviour
{
    public AudioSource mainmusic;
    //public AudioSource wizard;
    //public AudioClip wizard;
    float time = 50.0f;
    public GameObject mypanel;




    public void LoadCredit()
    {
        SceneManager.LoadScene(2);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
       
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(1);

    }


    public void Quitgame()
    {


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


   

}

