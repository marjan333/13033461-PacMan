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
    // Start is called before the first frame update
    void Start()
    {
        GameObject mainSceneCam = GameObject.Find("Camera");
        Camera cam = mainSceneCam.GetComponent<Camera>();
        Transform camPos = cam.transform;

        // minCam = Camera.main.orthographicSize;
        // maxCam = Camera.main.orthographicSize + 2;

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

        Instantiate(prefab, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);
        yield return new WaitForSeconds(10.0f);


    }
}
