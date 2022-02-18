using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text ScoreText;
    private int ScoreNum;
    void Start()
    {
        ScoreNum = 0;
        ScoreText.text = ScoreNum.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Stars")
        {
            ScoreNum += 1;
            Destroy(collision.gameObject);
            ScoreText.text = ScoreNum.ToString();
        }

        if(collision.tag == "FakeStars")
        {
            ScoreNum -= 1;
            Destroy(collision.gameObject);
            ScoreText.text = ScoreNum.ToString();
            if (ScoreNum < 0)
            {
                ScoreNum += 1;
                ScoreText.text = ScoreNum.ToString();
            }
        }
    }
}
