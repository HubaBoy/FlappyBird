using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipmove : MonoBehaviour
{
    public float moveSpeed =5; 
    public int DeathZone = -45; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position= transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if(transform.position.x < DeathZone)
        {
            Destroy(gameObject);
        }
    }
}
