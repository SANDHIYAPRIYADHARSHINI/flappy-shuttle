using UnityEngine;

public class net_spawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 1f; // Time in seconds between spawns
    private float timer = 0f;
    public float heightOffset = 4f; // Maximum height offset for the pipes
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawn(); // Spawn the first pipe immediately when the game starts
    }

    // Update is called once per frame
    void Update()
    {   
        if(timer<spawnRate){
            timer+=Time.deltaTime; //Time.deltaTime is the time between frames
        }
        else{
            spawn(); 
            timer = 0f;
        }
        
    }
    void spawn(){
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0), transform.rotation); //Quaternion.identity means no rotation
    }
}
