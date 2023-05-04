using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores all the variables and functions of the current player
public class Player_Values : MonoBehaviour
{
    [SerializeField] public string[] player_operators = {"+", "*"};
    [SerializeField] public int num_operands_in_deck = 3;
    [SerializeField] public int current_turn = 0;
    [SerializeField] public bool is_holding_card = false;
    private Vector3 mouse_pos;

    public void Update()
    {
        //setup mouse_pos
        mouse_pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //cast ray from camera to mouse position
        RaycastHit2D hit = Physics2D.Raycast(mouse_pos, Vector2.zero);

        //if above ray hit a card collider then,
        if(hit.collider != null && hit.collider.gameObject.gameObject.layer == 6 && is_holding_card == false)
        {
            //Debug.Log("Touch!");
            //set is_touched to true
            hit.collider.gameObject.GetComponent<Operand_Card_Behavior>().Set_Is_Touched(true);

            //if left mouse button was pressed, 
            if(Input.GetMouseButtonDown(0))
            {
                //set is_following to true
                hit.collider.gameObject.GetComponent<Operand_Card_Behavior>().Set_Is_Touched(false);
                hit.collider.gameObject.GetComponent<Operand_Card_Behavior>().Set_Is_Held(true);
                is_holding_card = true;
            }
        }

        if(Input.GetMouseButtonDown(1))
    }

    //Move to next turn
    public void Next_turn()
    {
        current_turn++;
    }

    //return the current player operators
    public string[] Get_Player_Operators()
    {
        return player_operators;
    }

   public  void Set_Player_Operators(string[] new_ops)
    {
        player_operators = new_ops;
    }

    public int Get_Num_Operands()
    {
        return num_operands_in_deck;
    }

    public void Set_Num_Operands(int new_num)
    {
        num_operands_in_deck = new_num;
    }

    public bool Get_Is_Holding()
    {
        return is_holding_card;
    }

    public void Set_Is_Holding(bool new_bool)
    {
        is_holding_card = new_bool;
    }
}
