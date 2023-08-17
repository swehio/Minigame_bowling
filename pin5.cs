using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin5 : MonoBehaviour
{
    bool scoreUp = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (((transform.eulerAngles.z <= 90 && transform.eulerAngles.z > 60) || (transform.eulerAngles.z >= 270 && transform.eulerAngles.z < 300)) || ((transform.eulerAngles.x <= 90 && transform.eulerAngles.x > 60) || (transform.eulerAngles.x >= 270 && transform.eulerAngles.x < 300)))
        {
            if (scoreUp)
            {
                ball.score++;
                scoreUp = false;
            }
        }
        if (Input.GetMouseButton(1))
        {
            transform.position = new Vector3(4, 3, 94);
            transform.rotation = Quaternion.Euler(0, 0, 0);
            scoreUp = true;
        }
    }
}
