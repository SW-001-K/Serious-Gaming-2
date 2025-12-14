using UnityEngine;

public class ObjectOutline : MonoBehaviour
{
    public Material highlightMat;    
    private Material originalMat;    
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        originalMat = rend.material;
    }

    public void Highlight(bool state)
    {

        Debug.Log("Highlight called: " + state);


        if (state)
            rend.material = highlightMat;
        else
            rend.material = originalMat;
    }
}
