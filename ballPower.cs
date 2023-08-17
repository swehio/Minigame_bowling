using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballPower : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3((ball.force % 50) * 0.1f, 1, 1);
    }
}
