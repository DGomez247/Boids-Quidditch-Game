using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GPoints : MonoBehaviour
{
    Text GText;
    GameObject GPanel;
    int score = 0;

    public void Start()
    {
        GPanel = GameObject.FindWithTag("GSCORE");
        GText = GPanel.GetComponent<Text>();
    }
    public void Update()
    {
        GText.text = score.ToString();
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Quaffle")
        {
            score = score + 10;
            GText.text = score.ToString();
            Destroy(collision.gameObject);
        }
    }
}
