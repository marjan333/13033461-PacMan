using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public AudioClip loopAudio;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        AudioSource audio = GetComponent<AudioSource>();


        audio.Play();
        yield return new WaitForSeconds(audio.clip.length);
        audio.clip = loopAudio;
        audio.loop = true;
        audio.Play();
    }


}
