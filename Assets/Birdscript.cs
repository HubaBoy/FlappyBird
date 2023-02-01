using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float FlapStrength;
    public LogicScript logic;
    public bool birdlife = true;
    public Animator anime;   
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //anime.SetBool("Space", true);
        if(Input.GetKeyDown(KeyCode.Space) == true && birdlife == true)
        {
            anime.SetTrigger("flapping");
            myRigidbody.velocity = Vector2.up * FlapStrength;
            if(transform.position.y>=8.5 || transform.position.y<-9)
            {
                logic.GameOver();
                birdlife=false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdlife=false;

    }
}
