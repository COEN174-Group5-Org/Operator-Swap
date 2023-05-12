using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battle_Slot_Behavior : MonoBehaviour
{
    //Number vars
    [SerializeField] private string slot_type;
    private Vector3 mouse_pos;

    //GameObject vars
    [SerializeField] private GameObject canvas_obj;
    [SerializeField] private Player_Values player_vals;

    void Awake()
    {
        //setup
        canvas_obj = GameObject.Find("Canvas");
        player_vals = canvas_obj.GetComponent<Player_Values>();

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
                //if the collider of this object was found in hits and the player is holding the correct card type...
                if(hits[i].collider.gameObject == this.gameObject && player_vals.Get_Is_Holding() && player_vals.Get_Held_Card_Type() == slot_type)
                {
                    //Debug.Log(player_vals.Get_Is_Holding().ToString());
                    //Debug.Log("This slot touched!");
                    //if left mouse button is pressed then...
                    if(Input.GetMouseButtonDown(0) && player_vals.Get_Is_Leftmouse() == false)
                    {
                        //get held card
                        GameObject card = player_vals.Get_Held_Card();

                        //get held card's "Operand_Card_Behavior" Component
                        Operand_Card_Behavior operand_card_component = card.GetComponent<Operand_Card_Behavior>();

                        //Set card's rest position to this slot's position
                        operand_card_component.Set_Rest_Position(gameObject.transform.position);

                        //Reset Card
                        operand_card_component.Reset_Card();

                        //put held_card into slot
                        //card.transform.position = gameObject.transform.position;

                        Debug.Log("Battle Slotted!");
                    }
                }
            }
        }
    }
}