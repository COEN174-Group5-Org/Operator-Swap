using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Operand_Card_Behavior : MonoBehaviour
{
    //Numbers variables
    [SerializeField] private Vector3 rest_position; 

    // Start is called before the first frame update
    void Start()
    {
        rest_position = GetComponent<Transform>().position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Debug.Log("Press!");
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, 100f))
            {
                if(hit.transform != null)
                {
                    Debug.Log("Hit!");
                }
            }
        }
    }
}
