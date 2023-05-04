using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class objective_text : MonoBehaviour
{
    public GameObject objectiveTextGameObj;
    public TextMeshProUGUI objectiveObj;

    public GameObject generateObjectiveOBJ;

    //Grab objective from GenerateObjective
    string objectiveText;
    

    //display into "objective text" textbox
    // Start is called before the first frame update
    void Start()
    {
        generateObjectiveOBJ = GameObject.Find("Canvas");

        Generate_Objective oj = generateObjectiveOBJ.GetComponent<Generate_Objective>();

        objectiveTextGameObj = GameObject.Find("Objective Text");
        objectiveObj = objectiveTextGameObj.GetComponent<TextMeshProUGUI>();
        objectiveObj.text = oj.generateObjective();

    }

    // Update is called once per frame
    void Update()
    {
        //objectiveObj.text;
    }
}
