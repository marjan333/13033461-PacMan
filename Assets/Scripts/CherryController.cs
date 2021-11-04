using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("CherrySpawn");
    }

    IEnumerator CherrySpawn()
    {
        while (true)
        {
            Instantiate(prefab);
            yield return new WaitForSeconds(10.0f);
        }

    }
}
