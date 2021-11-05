using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CherryController : MonoBehaviour
{
    private float minX, maxX, minY, maxY;
    private float minCam;
    private float maxCam;
    private float timer = 0.0f;
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
        // spawnPos.x = Random.Range(minX, maxX);
        spawnPos.x = -45;
        spawnPos.y = Random.Range(minY, maxY);
        spawnPos.y = Random.Range(-53, 12);
        spawnPos.z = 0;
        //StartCoroutine(CherrySpawn());
        //InvokeRepeating("CherrySpawn", 1, 10);

        if (Time.time - timer > 10)
        {
            CherrySpawn();
            timer = Time.time;
        }

    }

    void CherrySpawn()
    {

        // while (true)
        // {
        //yield return new WaitForSeconds(10);
        Instantiate(prefab, new Vector3(spawnPos.x, spawnPos.y, spawnPos.z), Quaternion.identity);

        //}

    }
}
