using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    private Tween activeTween;
    // Start is called before the first frame update
    void Start()
    {
        tweener = GetComponent<Tweener>();
    }

    // Update is called once per frame
    void Update()
    {
        if (item != null)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Vector3 left = item.transform.position += Vector3.left;
                //tweener.AddTween(item.transform, item.transform.position, left, 1.0f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                float t = (Time.time - activeTween.StartTime) / activeTween.Duration;
                //Vector3 right = item.transform.position += Vector3.right;
                Vector3 move = Vector3.Lerp(item.transform.position, item.transform.position + Vector3.right, t);
                //tweener.AddTween(item.transform, item.transform.position, right, 1.0f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                Vector3 down = item.transform.position += Vector3.down;
                //tweener.AddTween(item.transform, item.transform.position, down, 1.0f);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                Vector3 up = item.transform.position += Vector3.up;
                //tweener.AddTween(item.transform, item.transform.position, up, 1.0f);
            }
        }


    }
}
