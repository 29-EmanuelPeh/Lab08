using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDetector : MonoBehaviour
{
    public Text scoreTxt;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreTxt.text = "Score: " + score;
    }

    public void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("Obstacle"))
        {
            Destroy(other.gameObject);
            score++;
            scoreTxt.text = "Score: " + score;
        }
    }
}
