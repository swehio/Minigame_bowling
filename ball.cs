using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody rb;
    public static int score;
    bool scoring = false;
    public static float force = 50.0f;
    float forceAdd = 0.06f;
    public static int count = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            if(!scoring)
            {
                Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 5);
                Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = objPosition;
                force += forceAdd;
                if(force >= 60.0 || force <= 50)
                {
                    forceAdd *= -1;
                }
            }
            
        }
        if(Input.GetMouseButtonUp(0))
        {
            if(!scoring)
            {
                rb = GetComponent<Rigidbody>();
                rb.useGravity = true;
                rb.AddForce(0, 0, force, ForceMode.Impulse);
                scoring = true;
            }
            
        }
        if(Input.GetMouseButtonDown(1))
        {
            rb.velocity = Vector3.zero;
            transform.position = new Vector3(0, 2, 0);
            scoring = false;
        }
    }
}
