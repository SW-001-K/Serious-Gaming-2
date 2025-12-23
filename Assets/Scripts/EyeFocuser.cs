using UnitEye;
using UnityEngine;

/// <summary>
/// This using UnitEye;

/// <summary>
/// This class showcases a small game where multiple objects can be moved with your eyes.
/// In this class the UnitEye pipeline is accessed by using a reference to the Gaze object.
/// Alternatively you could also inherit from Gaze itself to access its features.
/// </summary>
public class EyeFocuser : MonoBehaviour /*Gaze*/
{
    public float drainRate = 1f;
    private int focusedCount;
    private AOITagList tagList;

    bool moving;

    //When inheriting, remove gaze reference
    public Gaze gaze;

    RaycastHit hitObject = new RaycastHit();

    //When inheriting
    /*public override */void Start()
    {
        //When inheriting, call base.Start() before own Start()
        /*base.Start()*/
        tagList = new AOITagList("eyeFocusRay");
        tagList.AddTag("Focus Anchor");
        //When inheriting, use base instead of gaze
        //base.AOIManager.AddAOI(tagList);
        gaze.AOIManager.AddAOI(tagList);
        FocusManager.Instance.drainRate = drainRate;
        
    }

    void Update()
    {
        if (focusedCount > 29)
        {
            focusedCount = 30;
            drainRate = 1f; 
            FocusManager.Instance.drainRate = drainRate;
            ScoreManager.Instance.currScore += 10* Time.deltaTime; 
                    
        }

        else if (tagList.focused)
            focusedCount++;
        else if (!moving)
            focusedCount = 0;

        if (!moving && focusedCount > 29)
        {
            hitObject = tagList.hitRaycast;
            hitObject.collider.gameObject.GetComponent<Renderer>().material.color = Color.green;

            moving = true;
        }
        //When inheriting, "gaze." is no longer necessary
        else if (/*Blinking*/gaze.Blinking)
        {
            focusedCount = 0;
            if (hitObject.collider != null) hitObject.collider.gameObject.GetComponent<Renderer>().material.color = Color.grey;
            hitObject = new RaycastHit();
            moving = false;

            drainRate = 5f; 
            FocusManager.Instance.drainRate = drainRate;
        }

        if (hitObject.collider != null)
        {
            // var vector = hitObject.transform.localPosition;
            //When inheriting, "gaze." is no longer necessary
            //var gazeVector = new Vector2(gazeLocation.x, Screen.height - gazeLocation.y);
            // var gazeVector = new Vector2(gaze.gazeLocation.x, Screen.height - gaze.gazeLocation.y);
            // var vectorGaze = Camera.main.ScreenToWorldPoint(gazeVector);
            // vector.x = vectorGaze.x;
            // vector.y = vectorGaze.y;
            // hitObject.transform.localPosition = vector;

             Debug.Log("Focused");
        }
    }

    //When inheriting
    /*public override */void OnGUI()
    {
        //When inheriting, call base.OnGUI()
        /*base.OnGUI()*/
        GUI.Label(new Rect(100, 300, 100, 100), $"{focusedCount}");
        GUI.Label(new Rect(100, 320, 100, 100), $"{(tagList.hitRaycast.collider != null ? tagList.hitRaycast.collider.gameObject.name : "None")}");
    }
}
