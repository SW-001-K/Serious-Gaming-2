using UnityEngine;
using UnityEngine.Video;
public class DoomScroll : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public VideoClip[] clips;   
    private int currentIndex = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayClip(currentIndex);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.mouseScrollDelta.y < 0)
        {
            NextVideo();
        }

        if (Input.mouseScrollDelta.y > 0)
        {
            PreviousVideo();
        }
    }

    void NextVideo()
    {
        currentIndex++;
        if (currentIndex >= clips.Length)
            currentIndex = 0; // loop back to first

        PlayClip(currentIndex);
    }

    void PreviousVideo()
    {
        currentIndex--;
        if (currentIndex < 0)
            currentIndex = clips.Length - 1; // go to last

        PlayClip(currentIndex);
    }

    void PlayClip(int index)
    {
        videoPlayer.clip = clips[index];
        videoPlayer.Play();
    }
}
