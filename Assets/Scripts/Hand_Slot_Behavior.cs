using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand_Slot_Behavior : MonoBehaviour
{
    //Number vars
    [SerializeField] private string slot_type;
    private Vector3 mouse_pos;

    //GameObject vars
    [SerializeField] private GameObject card_prefab;
    [SerializeField] private GameObject canvas_obj;
    [SerializeField] private Player_Values player_vals;

    void Awake()
    {
        //setup
        canvas_obj = GameObject.Find("Canvas");
        player_vals = canvas_obj.GetComponent<Player_Values>();

        //create a card
        Instantiate(card_prefab, transform.position, Quaternion.identity);

        //make sure this slot is not both an operand slot and an operator slot
        if(slot_type != "operand" && slot_type != "operator")
            Debug.Log("ERROR! Invalid slot type given!");
    }

    // Update is called once per frame
    void Update()
    {
        //setup mouse_pos
        mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //cast ray from camera to mouse position through all colliders
        RaycastHit2D[] hits = Physics2D.RaycastAll(mouse_pos, Vector2.zero);

        //if above ray hit at least one thing then...
        if(hits.Length != 0)
        {
            //iterate through hits...
            for(int i = 0; i < hits.Length; i++)
            {
                //if the collider of this object was found in hits and the player is holding the correct card type and the player clicks left mouse button then...
                if(hits[i].collider.gameObject == this.gameObject && player_vals.Get_Is_Holding() && player_vals.Get_Held_Card_Type() == slot_type)
                {
                    //Debug.Log("This slot touched!");
                    //if left mouse button is pressed then...
                    if(Input.GetMouseButtonDown(0))
                    {
                        //Debug.Log("Slotted!");
                        //put held_card into slot
                        (player_vals.Get_Held_Card()).transform.position = gameObject.transform.position;
                    }
                }
            }
        }
    }
}
