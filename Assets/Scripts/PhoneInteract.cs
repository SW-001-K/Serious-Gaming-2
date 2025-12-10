using UnityEngine;
using UnityEngine.SceneManagement;

public class PhoneInteract : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
            player.SetActive(false);

        Debug.Log("Phone interacted!");
        SceneManager.LoadScene(sceneLoad);
    }

    public string sceneLoad = "Phone";

}
