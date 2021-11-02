using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tweener : MonoBehaviour
{
    private Tween activeTween;
    //private float overallDist; 
    private float ratioT;
    private float cubic;
    private float dist;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // consider: position at ratio = start + (duration * ratio t)
        // duration = range = end - start 
        // To find ratio t: rearrange the formula to get ratio t = (position at t - start)/duration
        // t = time/ duration 

        if (activeTween != null)
        {

            //overallDist = Vector3.Distance(activeTween.StartPos, activeTween.EndPos);
            //ratioT = Time.time/activeTween.Duration; 
            //ratioT = (Time.time - activeTween.StartTime)/overallDist; 
            ratioT = (Time.time - activeTween.StartTime) / activeTween.Duration;
            cubic = ratioT * ratioT * ratioT;
            // between target current position and end position.
            dist = Vector3.Distance(activeTween.Target.position, activeTween.EndPos);

            if (dist > 0.1f)
            {
                //lerp: Vector3(a,b,ratio t)
                activeTween.Target.position = Vector3.Lerp(activeTween.StartPos, activeTween.EndPos, cubic);
            }

            if (dist <= 0.1f)
            {
                Debug.Log("Null reached");
                activeTween.Target.position = activeTween.EndPos;
                activeTween = null;
            }
        }
    }

    public void AddTween(Transform targetObject, Vector3 startPos, Vector3 endPos, float duration)
    {
        if (activeTween == null)
        {
            activeTween = new Tween(targetObject, startPos, endPos, Time.time, duration);
        }
    }
}
