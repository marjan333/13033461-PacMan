using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject item;
    private Tweener tweener;
    private List<GameObject> itemList;

    //private string lastInput;
    private Animator anim;
    private ParticleSystem ps;
    private AudioSource walk;

    KeyCode lastInput;
    KeyCode currentInput;

    // Use this for initialization
    void Start()
    {
        tweener = GetComponent<Tweener>();
        itemList = new List<GameObject>();
        itemList.Add(item);
        anim = gameObject.GetComponent<Animator>();
        walk = GetComponent<AudioSource>();
        ps = GetComponent<ParticleSystem>();
        //ps.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        //walk.enabled = false;

        if (Input.GetKeyDown("a"))
        {
            LoopAddTween("a");
            lastInput = KeyCode.A;
            walk.Play();

        }
        else if (Input.GetKeyUp("a"))
            anim.Play("Idle_Left");
        //walk.Stop();

        if (Input.GetKeyDown("d"))
        {
            LoopAddTween("d");
            lastInput = KeyCode.D;
            walk.Play();

        }
        else if (Input.GetKeyUp("d"))
            anim.Play("Idle_Right");
        //walk.Stop();

        if (Input.GetKeyDown("s"))
        {
            LoopAddTween("s");
            lastInput = KeyCode.S;
            walk.Play();
        }
        // else if (Input.GetKeyUp("s"))
        // {
        //     walk.Stop();
        // }

        if (Input.GetKeyDown("w"))
        {
            LoopAddTween("w");
            lastInput = KeyCode.W;
            walk.Play();
        }
        // else if (Input.GetKeyUp("w"))
        // {
        //     walk.Stop();
        // }

        if (Input.GetKeyUp(lastInput)) lastInput = KeyCode.None;
        //Debug.Log(lastInput);

        Vector3 direction; // (0, 0) by default
        switch (lastInput)
        {
            case KeyCode.W: direction.y = 1; break;
            case KeyCode.A: direction.x = -1; break;
            case KeyCode.S: direction.y = -1; break;
            case KeyCode.D: direction.x = 1; break;
        }

        // if (tweener.dist < 0.1f)
        // {
        //     currentInput = lastInput;
        // }

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
    }
}
