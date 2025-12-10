using UnityEngine;

public class Pointer : MonoBehaviour
{
    public float interactDistance = 100f;
    public LayerMask interactLayer;

    private ObjectOutline lastoutline;

    void Update()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out RaycastHit hit, interactDistance, interactLayer))
        {
            // 🔹 Highlight object
            ObjectOutline ho = hit.collider.GetComponentInParent<ObjectOutline>();

            if (ho != null)
            {
                // If new object, swap highlight
                if (lastoutline != ho)
                {
                    if (lastoutline != null)
                        lastoutline.Highlight(false);

                    ho.Highlight(true);
                    lastoutline = ho;
                }
            }
            else
            {
                // Remove highlight if not looking at interactable
                if (lastoutline != null)
                    lastoutline.Highlight(false);

                lastoutline = null;
            }

            // 🔸 Handle interaction (your original code)
            if (Input.GetKeyDown(KeyCode.E))
            {
                hit.collider.GetComponent<IInteractable>()?.OnInteract();
            }
        }
        else
        {
            // Clear highlight when looking at nothing
            if (lastoutline != null)
            {
                lastoutline.Highlight(false);
                lastoutline = null;
            }
        }
    }
}
