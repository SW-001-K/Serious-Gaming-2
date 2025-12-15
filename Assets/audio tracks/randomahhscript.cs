using System.Collections;
using UnityEngine;

public class PlayRandomSound : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] mySounds;

    void Start()
    {
        StartCoroutine(PlayRandomSoundsLoop());
    }

    IEnumerator PlayRandomSoundsLoop()
    {
        while (true)
        {
            yield return new WaitForSeconds(5f); // interval

            if (mySounds.Length > 0)
            {
                AudioClip activeSound = mySounds[Random.Range(0, mySounds.Length)];
                audioSource.PlayOneShot(activeSound);
            }
        }
    }
}