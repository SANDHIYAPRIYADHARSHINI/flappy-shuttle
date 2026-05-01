using UnityEngine;

public class netmove : MonoBehaviour
{   public float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float deadzone = -45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position+= Vector3.left * speed * Time.deltaTime; //left sets (-1,0)
        if (transform.position.x < deadzone)
        {
            Debug.Log("net kannum");
            Destroy(gameObject);
        }
    }
}
