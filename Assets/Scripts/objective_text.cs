using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objective_text : MonoBehaviour
{
    public GameObject objectiveTextGameObj;
    public TextMeshProUGUI objectiveObj;

    //Grab objective from player_values script
    string objectiveText;
    

    //display into "objective text" textbox
    // Start is called before the first frame update
    void Start()
    {
        //Grab objective from player_values script
        //objectiveText = player_values.getObjectiveText();


        objectiveTextGameObj = GameObject.Find("Objective Text");
        objectiveObj = objectiveTextGameObj.GetComponent<TextMeshProUGUI>();
        objectiveObj.text = "test script - change to val from player_values";

    }

    // Update is called once per frame
    void Update()
    {
        objectiveObj.text = "test script - change to val from player_values";
    }
}
