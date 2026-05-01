using UnityEngine;

public class birdiescript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flappStrength;
    public logic_script l;
    public bool gameon = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        l=GameObject.FindGameObjectWithTag("logic").GetComponent<logic_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)== true && gameon==true)
        {
            rb.linearVelocity = Vector2.up * flappStrength; //up sets (0,1) 

        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        l.gameOver();
        gameon = false;
    }
}
