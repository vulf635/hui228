using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisions : MonoBehaviour
{
    public bool player = false, block = false;
    public GameObject gm;
    void Start()
    {
        gm = GameObject.Find("gamemanager");
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (player)
        {
            if (collision.gameObject.tag == "block")
            {

                gm.GetComponent<main>().player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                switch (gm.GetComponent<main>().move_direction)
                {
                    case 1:
                        gm.GetComponent<main>().player.transform.position = new Vector2(gm.GetComponent<main>().player.transform.position.x, gm.GetComponent<main>().player.transform.position.y - 0.005f);
                        
                        break;
                    case 2:
                        gm.GetComponent<main>().player.transform.position = new Vector2(gm.GetComponent<main>().player.transform.position.x, gm.GetComponent<main>().player.transform.position.y - 0.005f);
                        
                        break;
                    case 3:
                        gm.GetComponent<main>().player.transform.position = new Vector2(gm.GetComponent<main>().player.transform.position.x - 0.005f, gm.GetComponent<main>().player.transform.position.y);
                        
                        break;
                    case 4:
                        gm.GetComponent<main>().player.transform.position = new Vector2(gm.GetComponent<main>().player.transform.position.x + 0.005f, gm.GetComponent<main>().player.transform.position.y);
                        
                        break;
                }
                    //gm.GetComponent<main>().player.transform.position = new Vector2(gm.GetComponent<main>().player.transform.position.x, gm.GetComponent<main>().player.transform.position.y);
                    //gm.GetComponent<main>().move_block = false;

            }
           
        }
        if (block)
        {
            if (collision.gameObject.tag == "block")
            {
                gm.GetComponent<main>().block.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                gm.GetComponent<main>().block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                switch (gm.GetComponent<main>().block_move_direction_pos)
                {
                    case 1:
                        gm.GetComponent<main>().block.transform.position = new Vector2(gm.GetComponent<main>().block.transform.position.x, 0);
                        gm.GetComponent<main>().time_bool = true;
                        break;
                    case 2:
                        gm.GetComponent<main>().block.transform.position = new Vector2(0, gm.GetComponent<main>().block.transform.position.y);
                        gm.GetComponent<main>().time_bool = true;
                        break;
                    case 3:
                        gm.GetComponent<main>().block.transform.position = new Vector2(gm.GetComponent<main>().block.transform.position.x, 0);
                        gm.GetComponent<main>().time_bool = true;
                        break;
                    case 4:
                        gm.GetComponent<main>().block.transform.position = new Vector2(0, gm.GetComponent<main>().block.transform.position.y);
                        gm.GetComponent<main>().time_bool = true;
                        break;
                }
            }

        }
    }
}


