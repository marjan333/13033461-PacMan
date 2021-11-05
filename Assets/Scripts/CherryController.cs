using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    private float minCam;
    private float maxCam;
    private Vector3 spawnPos;
    public GameObject prefab;
    private float duration;
    public Transform startMarker;
    private float startTime;
    private float journeyLength;

    private Bounds b;
    private float x;
    private float y;
    private float z;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        GameObject mainSceneCam = GameObject.Find("Camera");
        Camera cam = mainSceneCam.GetComponent<Camera>();
        Transform camPos = cam.transform;

        // b = new Bounds(new Vector3(13, -20, -250), new Vector3(32, 32, 0));

        // x = Random.Range(32, 35);
        // y = Random.Range(32, 35);
        // z = 0; 
        // pos = new Vector3(x, y, z);
        // transform.position = pos;

        minCam = Camera.main.orthographicSize;
        maxCam = Camera.main.orthographicSize + 2;

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(minCam);
        spawnPos.x = Random.Range(minX, maxX);
        spawnPos.y = Random.Range(minY, maxY);
        spawnPos.z = 0;
        StartCoroutine("CherrySpawn");


    }

    IEnumerator CherrySpawn()
    {
        // if () {}
        Instantiate(prefab);


        yield return new WaitForSeconds(10.0f);


    }
}
