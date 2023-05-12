using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores all the variables and functions of the current player
public class Player_Values : MonoBehaviour
{
    [SerializeField] public string[] player_operators = {"+", "*"}; //stores the operators that will appear in the player's hand at the start of a turn
    [SerializeField] public int num_operands_in_deck = 3; //stores the number of operand card that will appear in the player's hand at the start of a turn
    [SerializeField] public int current_turn = 0; //stores the current turn of the scene
    [SerializeField] public bool is_holding_card = false; //stores whether or not the player is holding a card
    public GameObject held_card; //stores the GameObject representing the last held card
    [SerializeField] public string held_card_type = "none"; //stores the type of the currently held card (should only be either "none", "operand", or "operator")

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

    public GameObject Get_Held_Card()
    {
        return held_card;
    }

    public void Set_Held_Card(GameObject new_obj)
    {
        held_card = new_obj;
    }

    public string Get_Held_Card_Type()
    {
        return held_card_type;
    }

    public void Set_Held_Card_Type(string new_string)
    {
        held_card_type = new_string;
    }
}
