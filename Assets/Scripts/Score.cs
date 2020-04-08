using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    GPoints GP;
    public Text GText;
    public Text SlyText;
    public int Gscore = 0;
    int SlyScore = 0;
    LoadArea scene;
    public void Start()
    {
        GText.text = Gscore.ToString();
        SlyText.text = SlyScore.ToString();
        
    }

    public void Update()
    {
        if (Gscore == 100 | SlyScore == 100)
        {
            
            SceneManager.LoadScene(2);
        }
    }


    public void UpdateGscore()
    {
        Gscore += 10;
        GText.text = Gscore.ToString();
    }
    public void UpdateSlyScore()
    {
        SlyScore += 10;
        SlyText.text = SlyScore.ToString();
    }
}

