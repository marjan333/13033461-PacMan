using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tween 
{
    public Transform Target { get; private set; }
    public Vector3 StartPos {get; set; }
    public Vector3 EndPos {get; set; }
    public float StartTime {get; private set; }
    public float Duration {get; private set; }
    
    public Tween (Transform target, Vector3 startPos, Vector3 endPos, float startTime, float duration){
        Target = target; 
        StartPos = startPos;
        EndPos = endPos; 
        StartTime = Time.time; 
        Duration = duration; 
    }
}
