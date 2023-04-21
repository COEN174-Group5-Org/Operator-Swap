using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Stores all the variables and functions of the current player
public class Player_Values : MonoBehaviour
{
    [SerializeField] public string[] player_operators = {"+", "*"};
    [SerializeField] public int num_operands_in_deck = 3;
    [SerializeField] public int current_turn = 0;

    //Move to next turn
    void Next_turn()
    {
        current_turn++;
    }

    //return the current player operators
    string[] Get_Player_Operators()
    {
        return player_operators;
    }

    void Set_Player_Operators(string[] new_ops)
    {
        player_operators = new_ops;
    }

    int Get_Num_Operands()
    {
        return num_operands_in_deck;
    }

    void Set_Num_Operands(int new_num)
    {
        num_operands_in_deck = new_num;
    }
}
