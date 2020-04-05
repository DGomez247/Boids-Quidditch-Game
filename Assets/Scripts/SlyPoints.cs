using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlyPoints : MonoBehaviour
{
    Text SText;
    GameObject SPanel;
    int score = 0;

    public void Start()
    {
        SPanel = GameObject.FindWithTag("GSCORE");
        SText = SPanel.GetComponent<Text>();
    }
    public void Update()
    {
        SText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Quaffle")
        {
            score = score + 10;
            SText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
