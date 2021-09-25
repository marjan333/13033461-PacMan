using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3[] positions = {new Vector3(-12.0f,7.5f,0.0f), new Vector3(10.0f,7.5f,0.0f), new Vector3(10.0f,-0.5f,0.0f), new Vector3(-12.0f,-0.5f,0.0f)};
    public bool repeat = false; 
    IEnumerator Start() {
        while(!repeat){
             yield return Positions(positions, 1f);
        }
       
    }
 
 
    IEnumerator Positions(Vector3[] pos, float speed) {
        for (int i = 0; i < pos.Length; i++) {
            Vector3 startPos = transform.position;
            float rate = 0f;
            while (rate <= 1f) {
                rate += Time.deltaTime * speed;
                Vector3 newPos = Vector3.Lerp(startPos, pos[i], rate);
                transform.position = newPos;
                yield return new WaitForEndOfFrame();
            }

            transform.position = pos[i];
            startPos = pos[i];
        }

        yield return null;
    }
}
