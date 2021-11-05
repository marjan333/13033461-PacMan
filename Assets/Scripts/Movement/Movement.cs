using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    private List<GameObject> itemList;

    private string lastInput;
    private Animator anim;
    private ParticleSystem ps;
    //private bool isMovingRight = false;
    //private bool isMovingLeft = false;

    // Use this for initialization
    void Start()
    {
        tweener = GetComponent<Tweener>();
        itemList = new List<GameObject>();
        itemList.Add(item);
        anim = gameObject.GetComponent<Animator>();

        ps = GetComponent<ParticleSystem>();
        ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("a"))
            LoopAddTween("a");
        else if (Input.GetKeyUp("a"))
            anim.Play("Idle_Left");
        if (Input.GetKeyDown("d"))
            LoopAddTween("d");
        else if (Input.GetKeyUp("d"))
            anim.Play("Idle_Right");
        if (Input.GetKeyDown("s"))
            LoopAddTween("s");
        if (Input.GetKeyDown("w"))
            LoopAddTween("w");

    }


    private void LoopAddTween(string key)
    {
        bool added = false;
        foreach (GameObject item in itemList)
        {

            if (key == "a")
            {
                added = tweener.AddTween(item.transform, item.transform.position, item.transform.position + Vector3.left, 1.5f);
                anim.Play("Bear_Walk_Left");
                //isMovingLeft = true;
            }

            if (key == "d")
            {
                added = tweener.AddTween(item.transform, item.transform.position, item.transform.position + Vector3.right, 1.5f);
                anim.Play("Bear_Walk_Right");
            }

            if (key == "s")
            {
                added = tweener.AddTween(item.transform, item.transform.position, item.transform.position + Vector3.down, 0.5f);
                anim.Play("Bear_Down");
            }
            if (key == "w")
            {
                added = tweener.AddTween(item.transform, item.transform.position, item.transform.position + Vector3.up, 0.5f);
                anim.Play("Bear_Up");
            }
            if (Input.anyKeyDown)
            {
                ps.Play();
            }
            if (added)
                break;
        }

        lastInput = key;
        Debug.Log(lastInput);

    }
}
