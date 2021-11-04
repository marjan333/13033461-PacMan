using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private Vector3 CherryPos = new Vector3(-45, -19, 0);
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
            Instantiate(prefab, CherryPos, Quaternion.identity);
            yield return new WaitForSeconds(10.0f);
        }

    }
}
