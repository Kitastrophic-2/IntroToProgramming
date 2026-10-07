using UnityEngine;

public class HazardTeleport : MonoBehaviour
{
    public float speed = 0.3f;
    public float xLim = 5f;
    public float yLim = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (pos.x > xLim || pos.x < -xLim)
        {
            pos.x = -pos.x;
            transform.position = pos;
        }
        if (pos.y > yLim || pos.y < -yLim)
        {
            pos.y = -pos.y;
            transform.position = pos;
        }
    }
}
