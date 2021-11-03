using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //public GameObject item; 
    public Vector3 startMarker;
    public Vector3 endMarker;    // Movement speed in units per second.

    public float speed = 1.0F;    // Time when the movement started.
    private float startTime;    // Total distance between the markers.
    private float journeyLength; void Start()
    {
        // right = Vector3.right; 
        // left = Vector3.left; 
        // Keep a note of the time the movement started.
        startTime = Time.time;        // Calculate the journey length.
        journeyLength = Vector3.Distance(startMarker, endMarker);
    }    // Move to the target end position.
    void Update()
    {
        // Distance moved equals elapsed time times speed..
        float distCovered = (Time.time - startTime) * speed;        // Fraction of journey completed equals current distance divided by total distance.
        float fractionOfJourney = distCovered / journeyLength;

        if (Input.GetKeyDown(KeyCode.D))
        {
            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker, transform.position + Vector3.right, fractionOfJourney);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker, transform.position + Vector3.left, fractionOfJourney);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker, transform.position + Vector3.up, fractionOfJourney);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Set our position as a fraction of the distance between the markers.
            transform.position = Vector3.Lerp(startMarker, transform.position + Vector3.down, fractionOfJourney);
        }
    }
}
