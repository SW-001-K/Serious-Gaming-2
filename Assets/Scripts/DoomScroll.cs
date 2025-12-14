using UnityEngine;
using UnityEngine.Video;
public class DoomScroll : MonoBehaviour
{

    public VideoPlayer videoPlayer;
    public VideoClip[] clips;   
    private int currentIndex = 0;
    public float drainRate = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Camera.main);
        PlayClip(currentIndex);
        FocusManager.Instance.drainRate = drainRate;
        
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

        if (FocusManager.Instance != null)
            FocusManager.Instance.drainRate = drainRate;
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
