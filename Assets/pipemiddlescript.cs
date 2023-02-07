using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipemiddlescript : MonoBehaviour
{
    public LogicScript logic;
    public Birdscript bird;
    // Start is called before the first frame update
     void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        bird = GameObject.FindGameObjectWithTag("bird").GetComponent<Birdscript>();
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
      private void OnTriggerEnter2D(Collider2D collider)
     {
        if(bird.birdlife == true)
        {
         logic.addScore(1);
        }
  
    }
}
