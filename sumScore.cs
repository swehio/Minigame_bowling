using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sumScore : MonoBehaviour
{
    public static int sum = 0;
    public Text SumTxt;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Screen.width / 2, Screen.height+ 50, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(!round1Score.round1 && !round2Score.round2 && !round3Score.round3)
        {
            SumTxt.text = "<Color=#FFFFFF>Total Score: " + sum.ToString() + "/18</color>";
            transform.position = new Vector3(Screen.width / 2, Screen.height / 2, 0);
        }
        
    }
}
