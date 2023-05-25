using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores all the variables and functions of the current player
public class Player_Values : MonoBehaviour
{
    //player_operators stores the operators that will appear in the player's hand at the start of a turn
    //[SerializeField] public string[] player_operators; 

    //operand_upper_bound stores the upper bound of the operand range and is changed by the selected difficulty
    private int operand_upper_bound;

    //num_operands_in_deck stores the number of operand card that will appear in the player's hand at the start of a turn
    public int num_operands_in_deck; 

    //current_turn stores the current turn of the scene
    public int current_turn = 0; 

    //is_holding_card stores whether or not the player is holding a card
    public bool is_holding_card = false; 

    //held_card stores the GameObject representing the LAST held card
    public GameObject held_card; 

    //held_card_type stores the type of the currently held card (should only be either "none", "operand", or "operator")
    public string held_card_type = "none";

    /*** Player hand variables ***/
    //...
    [SerializeField] private int[] hand_operands;

    //hand_operand_objs ...
    //These values must be set from the inspector!
    [SerializeField] private GameObject[] hand_operand_objs;

    //...
    private string[] hand_operators;

    //hand_operator_objs ...
    //These values must be set from the inspector!
    [SerializeField] private GameObject[] hand_operator_objs;

    //...
    private GameObject[] battle_objects;

    //...
    private string[] battle_equation;

    void Start()
    {
        Generate_Hand_For_3_Operands();
    }

    //Move to next turn
    public void Next_turn()
    {
        current_turn++;
    }

    //generate hand for level with 3 operands
    public void Generate_Hand_For_3_Operands()
    {
        //reset current turn
        current_turn = 0;

        //reset is_holding_card
        is_holding_card = false;

        //set number of operands to 3
        num_operands_in_deck = 3;

        //set hand_operands
        hand_operands = new int[3];
        for(int i = 0; i < 3; i++)
            hand_operands[i] = (int) Random.Range(1f, 9.999999f); 

        //set hand_operators
        hand_operators = new string[2];

        //reset battle objects
        battle_objects = new GameObject[5];

        //make equation "empty"
        battle_equation = new string[5] {"EMPTY","EMPTY", "EMPTY", "EMPTY", "EMPTY"};
    }

    //generate hand for level with 4 operands
    public void Generate_Hand_For_4_Operands()
    {
        num_operands_in_deck = 4;
    }

    // public string[] Get_Player_Operators()
    // {
    //     return player_operators;
    // }

    // public  void Set_Player_Operators(string[] new_ops)
    // {
    //     player_operators = new_ops;
    // }

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
