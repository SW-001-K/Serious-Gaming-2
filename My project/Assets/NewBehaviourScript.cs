using UnityEngine;

public class FnafCameraLook : MonoBehaviour
{
    public float sensitivity = 2f;

    public float minX = -60f;  // up limit
    public float maxX = 60f;   // down limit

    public float minY = -70f;  // left limit
    public float maxY = 70f;   // right limit

    private float rotationX = 0f;
    private float rotationY = 0f;

    void Start()
    {
        Vector3 rot = transform.localRotation.eulerAngles;
        rotationX = rot.x;
        rotationY = rot.y;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, minX, maxX);
        rotationY = Mathf.Clamp(rotationY, minY, maxY);

        transform.localRotation = Quaternion.Euler(rotationX, rotationY, 0f);
    }
}
