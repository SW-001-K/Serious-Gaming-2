using UnityEngine;

public class PositionRandomizer : MonoBehaviour
{
    [SerializeField] private Vector2 startPos;
    [SerializeField] private Vector2 endPos;

    private void Start() 
    { 
        Randomize();
    }

    //  private void Update()
    // {
    //     Randomize();

    // }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Randomize()
    {   
        float newX = Random.Range(startPos.x, endPos.x);
        float newY = Random.Range(startPos.y, endPos.y);

        transform.position = new Vector3(newX,newY,transform.position.z);
    }
}
