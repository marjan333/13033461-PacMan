using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //public Tweener tweener; 
    public GameObject obj; 
    public Transform[] targets; 

    //public Movement movement; 
    
    private bool rightTurn = false; 
    private bool leftTurn = false; 
    private bool up = false; 
    private bool down = false; 

    public Animator animator; 

    // Start is called before the first frame update
    void Start()
    {
        //tweener = GetComponent<Tweener>();
        //movement = GetComponent<Movement>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(obj.transform.position == targets[0].transform.position){

        }
        if(obj.transform.position == targets[1].transform.position){

        }
        if(obj.transform.position == targets[2].transform.position){

        }
        if(obj.transform.position == targets[3].transform.position){

        }
    }
}
