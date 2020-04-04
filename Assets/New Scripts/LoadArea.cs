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
    public VideoPlayer VP;
    public GameObject mypanel;




    public void LoadCredit()
    {
        SceneManager.LoadScene(3);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(1);
        Debug.Log("nope");
        StartCoroutine(Playvideo());
    }

    public void LoadGameScene()
    {
        mainmusic.Stop();
        StartCoroutine(Playvideo());

    }


    public void Quitgame()
    {


#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }


    IEnumerator Playvideo()
    {
        Debug.Log("here");
        mypanel.SetActive(false);
        VP.Play();
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(0);
    }

}

