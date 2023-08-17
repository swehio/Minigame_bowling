using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class round3Score : MonoBehaviour
{
    public Text ScriptTxt3;
    int r3Score = 0;
    public static bool round3 = false;
    bool done = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0) && ball.count == 0)
        {
            done = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (round3 && done)
            {
                r3Score = ball.score;
                sumScore.sum += ball.score;
                ScriptTxt3.text = r3Score.ToString();
                round3 = false;
            }
        }
    }
}
