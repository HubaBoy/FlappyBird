using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class pipspawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private  double timer = 0;
    public float heightOffset = 10;
    public LogicScript logic;
 
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }
 
    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime+0.00034*logic.playerScore;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
 
    }
 
    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
 
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}