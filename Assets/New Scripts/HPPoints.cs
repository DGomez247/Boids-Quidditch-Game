using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPPoints : MonoBehaviour
{
    Text HPText;
    GameObject HPPanel;
    int score = 0;

    public void Start()
    {
        HPPanel = GameObject.FindWithTag("HPSCORE");
        HPText = HPPanel.GetComponent<Text>();
    }
    public void Update()
    {
        HPText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Quaffle")
        {
            score = score + 10;
            HPText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
