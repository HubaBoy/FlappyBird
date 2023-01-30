using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipmove : MonoBehaviour
{
    public float moveSpeed =5; 
    public int DeathZone = -45; 
    public LogicScript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic=logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= transform.position + (Vector3.left * moveSpeed) * Time.deltaTime +Vector3.left * ( logic.playerScore + 1 )  * Time.deltaTime/5;
        if(transform.position.x < DeathZone)
        {
            Destroy(gameObject);
        }
    }

}
