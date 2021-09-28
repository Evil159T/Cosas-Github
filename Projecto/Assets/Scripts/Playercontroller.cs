using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour {

    bool canjump;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left")) 
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }


        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moving", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;

        }

        if (Input.GetKey("down"))
        {
            gameObject.GetComponent<Animator>().SetBool("agach", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f * Time.deltaTime, 0));
           
        }

        if (Input.GetKey("down") && Input.GetButton("left"))
        {
            
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("moveagach", true);
        }




        if (Input.GetKey("down") && Input.GetKey("left")){
            gameObject.GetComponent<Animator>().SetBool("moving", false);

        }



        if (!Input.GetKey("down"))
        {
            gameObject.GetComponent<Animator>().SetBool("agach", false);

        }

     
        while (Input.GetKey("left") && Input.GetKey("right")){

            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }


        if(!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("moving", false);
        }


        if (Input.GetKeyDown("up") && canjump) 
        {
            canjump = false;
            gameObject.GetComponent<Animator>().SetBool("jumping", true);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 225f));
            
        }

      
       

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "ground")
        {
            gameObject.GetComponent<Animator>().SetBool("jumping", false);
            canjump = true; 
        }
    }
}
