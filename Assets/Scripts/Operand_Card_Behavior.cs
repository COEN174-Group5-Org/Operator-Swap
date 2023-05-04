using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operand_Card_Behavior : MonoBehaviour
{
    //Numbers vars
    private Vector3 rest_position; 
    [SerializeField] private bool is_touched;
    [SerializeField] private bool is_held;
    [SerializeField] private float move_speed;
    [SerializeField] private float raise_dist;
    private Vector3 mouse_pos;
    private float step;

    //Gameobject vars
    [SerializeField] private GameObject canvas_obj;
    [SerializeField] private Player_Values player_vals;
    private GameObject main_camera;
    [SerializeField] private GameObject card_obj;
    private Transform card_trans;
    private Transform collider_trans;
    private BoxCollider2D bc;

    // Start is called before the first frame update
    void Start()
    {
        canvas_obj = GameObject.Find("Canvas");
        player_vals = canvas_obj.GetComponent<Player_Values>();
        is_touched = false;
        is_held = false;
        rest_position = GetComponent<Transform>().position;
        main_camera = GameObject.FindWithTag("MainCamera");
        card_obj = this.gameObject.transform.GetChild(0).gameObject;
        card_trans = card_obj.transform;
        collider_trans = gameObject.GetComponent<Transform>();
        bc = gameObject.GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //setup step
        step = move_speed * Time.deltaTime;

        if(is_touched == true)
        {
            Raise();
        }
        else 
        {
            Lower();
        }

        if(is_held == true) 
        {

        }
    }

    public bool Get_Is_Touched()
    {
        return is_touched;
    }

    public void Set_Is_Touched(bool temp)
    {
        is_touched = temp;
    }

    public void Set_Is_Held(bool temp)
    {
        is_held = temp;
    }

    public void Raise()
    {
        //raise card
        card_trans.position = Vector2.MoveTowards(card_trans.position, transform.position + new Vector3(0,raise_dist,0), step);;
    }

    public void Lower()
    {
        //move card to rest position
        card_trans.position = Vector2.MoveTowards(card_trans.position, rest_position, step);
    }

    public void Hold()
    {
        //follow mouse position
        collider_trans.position = new Vector3(mouse_pos.x, mouse_pos.y, 0);
    }

    public void Put_Back()
    {
        //reset position
        collider_trans.position = rest_position;
    }
}
