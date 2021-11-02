using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            tweener.AddTween(item.transform, item.transform.position, item.transform.position += Vector3.left, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            tweener.AddTween(item.transform, item.transform.position, item.transform.position += Vector3.right, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            tweener.AddTween(item.transform, item.transform.position, item.transform.position += Vector3.back, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            tweener.AddTween(item.transform, item.transform.position, item.transform.position += Vector3.forward, 1.0f);
        }

    }
}
