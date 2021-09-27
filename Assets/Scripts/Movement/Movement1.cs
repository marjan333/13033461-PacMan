using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{   
    [SerializeField] private GameObject item; 
    private Tweener tweener; 
    public Transform[] targets; 

    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if(item.transform.position == targets[1].transform.position){
            Debug.Log("condition1");
        tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f,7.5f,0.0f), 2f);
        gameObject.GetComponent<Animator>().Play("Bear_Walk_Left"); 
           
         
        }

        if(item.transform.position == targets[2].transform.position){
            Debug.Log("condition2");
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (10.0f,7.5f,0.0f), 2.5f);
             gameObject.GetComponent<Animator>().Play("Bear_Up");
            
        }

        if(item.transform.position == targets[3].transform.position){
            Debug.Log("condition3");
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (10.0f,-0.5f,0.0f), 2f);
            gameObject.GetComponent<Animator>().Play("Bear_Walk_Right"); 
        }

        if(item.transform.position == targets[0].transform.position){
             Debug.Log("condition4");
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f,-0.5f,0.0f), 2.5f);
            gameObject.GetComponent<Animator>().Play("Bear_Down"); 
        }
        
    }
}