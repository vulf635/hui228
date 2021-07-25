using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public int block_num, move_direction, timeint, block_move_direction_pos;
    public float time;
    public bool move_block = false, block_move_direction = false, time_bool = false;
    public GameObject player, block, block2, block3;

    
    void Start()
    {
        player = GameObject.Find("player");
        //block1 = GameObject.Find("block");
        //block2 = GameObject.Find("block_1");
        //block3 = GameObject.Find("block_2");
        time_bool = true;
    }

    
    void Update()
    {
        
        

        if (time_bool)
        {
            time += Time.deltaTime;
            if (time >= 1)
            {
                timeint += 1;
                time = 0;
            }
        }

        if (timeint >= 2.2f)
        {
            block_move_direction = true;
            timeint = 0;
            time = 0;
            time_bool = false;

        }

        if (time >= 0.2f)
        {
            block_num = Random.Range(0, 4);
            timeint += 2;
            
            Debug.Log("u suka");
            

            switch (block_num)
            {
                case 1:
                    block = GameObject.Find("block");
                    block2 = GameObject.Find("block_1");
                    block3 = GameObject.Find("block_2");
                    break;
                case 2:
                    block = GameObject.Find("block_1");
                    block2 = GameObject.Find("block");
                    block3 = GameObject.Find("block_2");
                    break;
                case 3:
                    block = GameObject.Find("block_2");
                    block2 = GameObject.Find("block_1");
                    block3 = GameObject.Find("block");
                    break;
            }

        }
        //block_move--------------------------------------------------------------------
        //if (block1.transform.position.y + 1 != 2) 
            //if (block1.transform.position.x + 1 != 2) 
                //if (block1.transform.position.x - 1 != -2)
                    //if (block1.transform.position.y - 1 != -2)

        if(block_move_direction)
        {
            if ((block.transform.position.y + 1 == block2.transform.position.y & block.transform.position.x == block2.transform.position.x) | (block.transform.position.y + 1 == block3.transform.position.y & block.transform.position.x == block3.transform.position.x) | (block.transform.position.y + 1 == 2))
            {
                if ((block.transform.position.y == block2.transform.position.y & block.transform.position.x + 1 == block2.transform.position.x) | (block.transform.position.y == block3.transform.position.y & block.transform.position.x + 1 == block3.transform.position.x) | (block.transform.position.x + 1 == 2))
                {
                    if ((block.transform.position.y - 1 == block2.transform.position.y & block.transform.position.x == block2.transform.position.x) | (block.transform.position.y - 1 == block3.transform.position.y & block.transform.position.x == block3.transform.position.x) | (block.transform.position.y - 1 == -2))
                    {
                        if ((block.transform.position.y == block2.transform.position.y & block.transform.position.x - 1 == block2.transform.position.x) | (block.transform.position.y == block3.transform.position.y & block.transform.position.x - 1 == block3.transform.position.x) | (block.transform.position.x - 1 == -2))
                        {
                            Debug.Log("ebati");
                        }
                        else
                        {
                            block_move_direction_pos = 4;
                            block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                            block.GetComponent<Rigidbody2D>().AddForce(new Vector2(-20, 0));
                            block_move_direction = false;
                        }
                    }
                    else
                    {
                        block_move_direction_pos = 3;
                        block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                        block.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -20));
                        block_move_direction = false;   
                    }
                }
                else
                {
                    block_move_direction_pos = 2;
                    block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                    block.GetComponent<Rigidbody2D>().AddForce(new Vector2(20, 0));
                    block_move_direction = false;
                }
            }
            else
            {
                block_move_direction_pos = 1;
                block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                block.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 20));
                block_move_direction = false;
            }
        }


         if (block.transform.position.y > 1)
         {
             block.transform.position = new Vector2(block.transform.position.x, 1);
             block.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            time = 0;
            time_bool = true;

         }
         if (block.transform.position.y < -1)
         {
             block.transform.position = new Vector2(block.transform.position.x, -1);
             block.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            time = 0;
            time_bool = true;
        }
         if (block.transform.position.x > 1)
         {
             block.transform.position = new Vector2(1, block.transform.position.y);
             block.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            time = 0;
            time_bool = true;
        }
         if (block.transform.position.x < -1)
         {
             block.transform.position = new Vector2(-1, block.transform.position.y);
             block.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            block.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            time = 0;
            time_bool = true;
        }
        

        if (player.GetComponent<Rigidbody2D>().velocity == new Vector2(0, 0))
                    {
                        if (Input.GetKeyDown(KeyCode.UpArrow))
                        {
                            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                            move_direction = 1;
                            move_block = true;
                            Debug.Log("verh");
                        }
                        if (Input.GetKeyDown(KeyCode.DownArrow))
                        {
                            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                            move_direction = 2;
                            move_block = true;
                            Debug.Log("verh");
                        }
                        if (Input.GetKeyDown(KeyCode.RightArrow))
                        {
                            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                            move_direction = 3;
                            move_block = true;
                            Debug.Log("verh");
                        }
                        if (Input.GetKeyDown(KeyCode.LeftArrow))
                        {
                            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
                            move_direction = 4;
                            move_block = true;
                            Debug.Log("verh");
                        }
                    }

        if (move_block)
        {
            switch (move_direction)
            {
                case 1:
                    player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 10));
                    //player.transform.Translate(new Vector2(0, 10) * Time.deltaTime);
                    
                    break;
                case 2:
                    player.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -10));
                    //player.transform.Translate(new Vector2(0, -10) * Time.deltaTime);
                    
                    
                    break;
                case 3:
                    player.GetComponent<Rigidbody2D>().AddForce(new Vector2(10, 0));
                    //player.transform.Translate(new Vector2(10, 0) * Time.deltaTime);
                    
                    break;
                case 4:
                    player.GetComponent<Rigidbody2D>().AddForce(new Vector2(-10, 0));
                    //player.transform.Translate(new Vector2(-10, 0) * Time.deltaTime);
                    
                    
                    break;




            }
            

        }
        if (player.transform.position.y > 1.4f)
        {
            player.transform.position = new Vector2(player.transform.position.x, 1.35f);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            move_block = false;
        }
        if (player.transform.position.y < -1.4f)
        {
            player.transform.position = new Vector2(player.transform.position.x, -1.35f);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            move_block = false;
        }
        if (player.transform.position.x > 1.4f)
        {
            player.transform.position = new Vector2(1.35f, player.transform.position.y);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            move_block = false;
        }
        if (player.transform.position.x < -1.4f)
        {
            player.transform.position = new Vector2(-1.35f, player.transform.position.y);
            player.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            move_block = false;
        }
        
        //if ()
    }
}
