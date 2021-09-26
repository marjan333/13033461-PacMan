using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    //public Tweener tweener; 
    public GameObject obj; 
    public Transform[] targets; 

    //public Movement movement; 

    // private bool rightTurn = false; 
    // private bool leftTurn = false; 
    // private bool up = false; 
    // private bool down = false; 

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
            Debug.Log("condition1");
            gameObject.GetComponent<Animator>().Play("Bear_Walk_Right");
            //animator.SetBool("IsRight", true); 
        }
        if(obj.transform.position == targets[1].transform.position){
             Debug.Log("condition2");
             gameObject.GetComponent<Animator>().Play("Bear_Down");
            //animator.SetBool("IsDown", true); 
        }
        if(obj.transform.position == targets[2].transform.position){
             Debug.Log("condition3");
             gameObject.GetComponent<Animator>().Play("Bear_Walk_Left");
            //animator.SetBool("IsLeft", true); 
        }
        if(obj.transform.position == targets[3].transform.position){
             Debug.Log("condition4");
             gameObject.GetComponent<Animator>().Play("Bear_Up");
            //animator.SetBool("IsUp", true); 
        }
    }
}
