using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operand_Card_Behavior : MonoBehaviour
{
    //Numbers vars
    private Vector3 rest_position; 
    [SerializeField] private bool is_touched;
    [SerializeField] private float move_speed;
    [SerializeField] private float raise_dist;

    //Gameobject vars
    private GameObject main_camera;
    private GameObject card_obj;
    private Transform card_trans;
    //private Transform tran;

    // Start is called before the first frame update
    void Start()
    {
        rest_position = GetComponent<Transform>().position;
        main_camera = GameObject.FindWithTag("MainCamera");
        card_obj = this.gameObject.transform.GetChild(0).gameObject;
        card_trans = card_obj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        //setup step
        float step = move_speed * Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if(hit.collider != null)
        {
            //Debug.Log("Touch!");
            is_touched = true;
            //Move car upwards

            if(Input.GetMouseButtonDown(0))
            {
                //Debug.Log("Press!");
            }
        }
        else
        {
            is_touched = false;
        }

        if(is_touched)
        {
            //raise card
            card_trans.position = Vector2.MoveTowards(card_trans.position, transform.position + new Vector3(0,raise_dist,0), step);;
        }
        else
        {
            //move card to rest position
            card_trans.position = Vector2.MoveTowards(card_trans.position, rest_position, step);
        }
    }
}
