using UnityEngine;

public class nethit : MonoBehaviour
{
    public logic_script l;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        l = GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer==3){
            l.countpoints(1);
        }
        

    }
}
