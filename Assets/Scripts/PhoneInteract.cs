using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneInteract : MonoBehaviour
{

    public string sceneLoad = "Phone";

    void Update()
    {
        // if player clicks the phone collider
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    SceneManager.LoadScene(sceneLoad);
                }
            }
        }
    }

}
