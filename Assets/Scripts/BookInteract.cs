using UnityEngine;
using UnityEngine.SceneManagement;

public class BookInteract : MonoBehaviour, IInteractable
{
    public void OnInteract()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
            player.SetActive(false);

        Debug.Log("Book interacted");
        SceneManager.LoadScene(sceneLoad);
    }

    public string sceneLoad = "Book";

}
