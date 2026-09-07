using UnityEngine;

public class Mover : MonoBehaviour
{

    public Transform[] destinations;
    public int index = 1;
    public float moveSpeed = 3f;

    void Start()
    {
        if(destinations.Length > 0)
            transform.position = destinations[0].position;
    }

    
    void Update()
    {
        //목적지로 이동.
        transform.position = Vector3.MoveTowards(transform.position, destinations[index].position, moveSpeed * Time.deltaTime);
        if(transform.position == destinations[index].position)
        {
            index++;
            if(index >= destinations.Length)
            {
                index = 0;
            }
        }
    }
}
