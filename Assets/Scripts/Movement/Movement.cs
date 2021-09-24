using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject item; 
    private Tweener tweener; 
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("a")){
        tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f,7.5f,0.0f), 1.0f);
        }

        if(Input.GetKeyDown("d")){
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (10.0f,7.5f,0.0f), 1.0f);
        }

        if(Input.GetKeyDown("s")){
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (10.0f,-0.5f,0.0f), 1.0f);
        }

        if(Input.GetKeyDown("w")){
            tweener.AddTween(item.transform, item.transform.position, new Vector3 (-12.0f,-0.5f,0.0f), 1.0f);
        }
        
    }
}
