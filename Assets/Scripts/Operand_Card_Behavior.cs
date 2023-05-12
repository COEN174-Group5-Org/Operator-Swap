using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operand_Card_Behavior : MonoBehaviour
{
    //Numbers vars
    private Vector3 rest_position; 
    [SerializeField] private bool is_touched;
    [SerializeField] private bool is_following;
    [SerializeField] private float move_speed;
    [SerializeField] private float raise_dist;
    private Vector3 mouse_pos;

    //Gameobject vars
    [SerializeField] private GameObject canvas_obj;
    [SerializeField] private Player_Values player_vals;
    [SerializeField] private GameObject card_obj;
    private Transform card_trans;
    private Transform collider_trans;
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        //Setup
        canvas_obj = GameObject.Find("Canvas");
        player_vals = canvas_obj.GetComponent<Player_Values>();
        is_touched = false;
        is_following = false;
        rest_position = GetComponent<Transform>().position;
        card_obj = this.gameObject.transform.GetChild(0).gameObject;
        card_trans = card_obj.transform;
        collider_trans = gameObject.GetComponent<Transform>();
        bc = gameObject.GetComponent<BoxCollider2D>();

        //Set number on card here:
        //...
    }

    // Update is called once per frame
    void Update()
    {
        //setup step
        float step = move_speed * Time.deltaTime;

        //setup mouse_pos
        mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //cast ray from camera to mouse position
        RaycastHit2D hit = Physics2D.Raycast(mouse_pos, Vector2.zero);

        //if above ray hit this collider then,
        if(hit.collider != null && hit.collider.gameObject == this.gameObject && player_vals.Get_Is_Holding() == false)
        {
            //Debug.Log("Touch!");
            //set is_touched to true
            is_touched = true;

            //if left mouse button was pressed, 
            if(Input.GetMouseButtonDown(0))
            {
                //set is_following to true
                is_following = true;
            }
        }
        else
        {
            //set is_touched to false
            is_touched = false;
        }

        if(is_touched == true && is_following == false && player_vals.Get_Is_Holding() == false)
        {
            //raise card
            card_trans.position = Vector2.MoveTowards(card_trans.position, transform.position + new Vector3(0,raise_dist,0), step);;
        }
        else if(is_touched == false && is_following == false)
        {
            //move card to rest position
            card_trans.position = Vector2.MoveTowards(card_trans.position, rest_position, step);
        }
        else
        {
            //follow mouse position
            collider_trans.position = new Vector3(mouse_pos.x, mouse_pos.y, 0);

            //set is_holding in Player_Values script to true;
            player_vals.Set_Is_Holding(true);

            //set held card to this card
            player_vals.Set_Held_Card(gameObject);

            //set held_card_type to "operand"
            player_vals.Set_Held_Card_Type("operand");

            //if right mouse button was pressed,
            if(Input.GetMouseButtonDown(1))
            {
                Reset_Card();
            }
        }
    }

    public void Reset_Card()
    {
        //set is_following to false
        is_following = false; 

        //reset position
        collider_trans.position = rest_position;

        //set is_holding in Player_Values script to false;
        player_vals.Set_Is_Holding(false);

        //set held_card_type to "none"
        player_vals.Set_Held_Card_Type("none");

        Debug.Log("Reset Card");
    }

    public void Set_Rest_Position(Vector3 temp_pos)
    {
        rest_position = temp_pos;
    }
}
