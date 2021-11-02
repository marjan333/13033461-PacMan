using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMove : MonoBehaviour
{
    public float start;
    public float end;
    public float t = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        end = start + 1;
        if (Input.GetKeyDown("d"))
        {
            Mathf.Lerp(start, end, t);
        }
    }
}
