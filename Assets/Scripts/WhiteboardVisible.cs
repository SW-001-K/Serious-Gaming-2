using UnityEngine;

public class WhiteboardVisible : MonoBehaviour
{   public float drainRate = 1f;
    Renderer m_Renderer;
    // Use this for initialization
    void Start()
    {
        m_Renderer = GetComponent<Renderer>();
        FocusManager.Instance.drainRate = drainRate;
    }

    // void OnEnable()
    // {
    //     m_Renderer.OnBecameVisible += onVisible;
    // }

    // Update is called once per frame
    // void Update()
    // {
    //     if (m_Renderer.isVisible)
    //     {   drainRate = 0.01f; 
    //         FocusManager.Instance.drainRate = drainRate;
    //         Debug.Log("Object is visible" + drainRate);
            

    //     }
    //     else{
    //         drainRate = 100f;
    //         FocusManager.Instance.drainRate = drainRate;
    //         Debug.Log("Object is no longer visible" + drainRate);
            
            
    //     }
    // }

    void OnBecameVisible()
    {
        
        drainRate = 0.01f; 
        FocusManager.Instance.drainRate = drainRate;
        Debug.Log("Object is visible" + drainRate);


    }

    void OnBecameInvisible()
    {   
        drainRate = 100f;
        FocusManager.Instance.drainRate = drainRate;
        Debug.Log("Object is no longer visible" + drainRate);
        

    }
}
