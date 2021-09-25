using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //public Tweener tweener; 
    public Movement movement; 
    private bool hasReached = false; 
    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        //tweener = GetComponent<Tweener>();
        movement = GetComponent<Movement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
