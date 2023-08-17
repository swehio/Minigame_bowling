using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class round1Score : MonoBehaviour
{
    public Text ScriptTxt1;
    int r1Score = 0;
    public static bool round1 = true;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && ball.count == 2)
        {
            done = true;
        }
        
        if(Input.GetMouseButtonDown(1))
        {
            if (round1 && done)
            {
                ball.count--;
                r1Score = ball.score;
                sumScore.sum += ball.score;
                ScriptTxt1.text = r1Score.ToString();
                ball.score = 0;
                round1 = false;
                round2Score.round2 = true;
            }
        }
    }
}
