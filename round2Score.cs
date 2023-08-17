using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class round2Score : MonoBehaviour
{
    public Text ScriptTxt2;
    int r2Score = 0;
    public static bool round2 = false;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && ball.count == 1)
        {
            done = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (round2 && done)
            {
                ball.count--;
                r2Score = ball.score;
                sumScore.sum += ball.score;
                ScriptTxt2.text = r2Score.ToString();
                ball.score = 0;
                round2 = false;
                round3Score.round3 = true;
            }
        }
    }
}
