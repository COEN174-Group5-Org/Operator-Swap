using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores all the variables and functions of the current player
public class Player_Values : MonoBehaviour
{
    //operand_upper_bound stores the upper bound of the operand range and is changed by the selected difficulty
    [SerializeField] private int operand_upper_bound;

    //num_operands_in_deck stores the number of operand card that will appear in the player's hand at the start of a turn
    private int num_operands_in_deck; 

    //current_turn stores the current turn of the scene
    private int current_turn = 0; 

    //is_holding_card stores whether or not the player is holding a card
    private bool is_holding_card = false; 

    //held_card stores the GameObject representing the LAST held card
    private GameObject held_card; 

    //held_card_type stores the type of the currently held card (should only be either "none", "operand", or "operator")
    private string held_card_type = "none";


    /*** Player hand variables ***/
    //hand_operands stores a List of all the integer operands currently in the player's hand
    [SerializeField] private List<int> hand_operands;

    //hand_operand_objs stores a List of the operand card objects currently in the player's hand
    //These values must be set from the inspector!
    [SerializeField] private List<GameObject> hand_operand_objs;

    //hand_operators stores a List of all the character operators currently in the player's hand
    private List<char> hand_operators;

    //hand_operator_objs stores a List of the operator card objects currently in the player's hand
    //These values must be set from the inspector!
    [SerializeField] private List<GameObject> hand_operator_objs;


    /*** Battle Slot variables ***/
    //battle_objects stores a List of the operator and operand cards currently in the battle slots
    private List<GameObject> battle_objects;

    //battle_nums stores 
    //if the Count of battle_objects is equal to the Count of hand_operand_objs plus the Count of hand_operator_objs then, the battle equation can be evaluated
    private List<int> battle_nums;

    //battle_ops stores 
    //if the Count of battle_objects is equal to the Count of hand_operand_objs plus the Count of hand_operator_objs then, the battle equation can be evaluated
    private List<char> battle_ops;

    void Awake()
    {
        Generate_Hand_For_n_Operands(3);
    }

    //Move to next turn
    public void Next_Turn()
    {
        current_turn++;
        Generate_Hand_For_n_Operands(3);
    }

    //generate hand for level with n operands
    public void Generate_Hand_For_n_Operands(int n)
    {
        //reset current turn
        current_turn = 0;

        //reset is_holding_card
        is_holding_card = false;

        //set number of operands to n
        num_operands_in_deck = n;

        //set hand_operands and hand_operand_objs
        hand_operands = new List<int>(new int[n]);
        if(n > hand_operands.Count){
            Debug.Log("ERROR!: nunber of OPERAND cards not correct!");
            Debug.Log("Number of OPERAND cards is: " + hand_operands.Count + ". While the input number is: " + n);
        }
        for(int i = 0; i < n; i++)
        {
            hand_operands[i] = (int) Random.Range(1f, ((float) operand_upper_bound) + 0.99999f);
            hand_operand_objs[i].GetComponent<Hand_Slot_Behavior>().Set_Slot_Symbol(hand_operands[i]);
        }

        //set hand_operators
        hand_operators = new List<char>(new char[n - 1]);
        if((n - 1) > hand_operators.Count){
            Debug.Log("ERROR!: nunber of OPERATOR cards not correct!");
            Debug.Log("Number of cards is: " + hand_operands.Count + ". While the input number is: " + n);
        }
        for(int i = 0; i < (n - 1); i++)
        {
            if(i == 0)
                hand_operators[i] = '+';
            else if(i == 1)
                hand_operators[i] = '*';
            else if(i == 2)
                hand_operators[i] = '-';
            else if(i == 3)
                hand_operators[i] = '/';
            else
                Debug.Log("ERROR! number of OPERATOR cards exceeds 4!");
            hand_operator_objs[i].GetComponent<Hand_Slot_Behavior>().Set_Slot_Symbol(hand_operators[i]);
        }

        //reset battle objects
        battle_objects = new List<GameObject>(new GameObject[n + (n - 1)]);

        //reset battle_nums
        battle_nums = new List<int>(new int[n]);

        //reset battle_ops
        battle_ops = new List<char>(new char[n - 1]);
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
    
    public void Set_Upper_Bound(int new_bound)
    {
        operand_upper_bound = new_bound;
    }
}
