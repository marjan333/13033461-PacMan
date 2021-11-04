using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private float minCam;
    private float maxCam;
    private Vector3 spawnPos;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        // minCam = Camera.main.orthographicSize;
        // maxCam = Camera.main.orthographicSize + 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(minCam);
        spawnPos.x = Random.Range(-45, 78);
        spawnPos.y = Random.Range(-53, 12);
        spawnPos.z = 0;
        StartCoroutine("CherrySpawn");
    }

    IEnumerator CherrySpawn()
    {


        while (true)
        {
            Instantiate(prefab, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
            yield return new WaitForSeconds(10.0f);
        }

    }
}
