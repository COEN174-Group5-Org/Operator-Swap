using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Generate_Objective : MonoBehaviour
{
    int fnum = 0;
    enum objType { GREATER = 0, LESSER }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (++fnum % 64 == 0)
        {
            Debug.Log(generateObjective());
        }
    }

    public string generateObjective()
    {
        var nums = new List<int>();
        for (int i = 0; i < 5; ++i) nums.Add(Random.Range(1, 11));
        nums.Sort();
        var ops = new List<char>();
        ops.Add('+');
        ops.Add('+');
        ops.Add('+');
        ops.Add('+');
        ops.Add('*');
        var samples = new List<int>();
        for (int i = 0; i < 100; ++i) samples.Add(Sample(3, nums, ops));
        samples = samples.Distinct().ToList();
        samples.Sort();
        var type = (objType)Random.Range(0, 2);
        int target;
        string objStr;
        if (type == objType.GREATER)
        {
            target = samples[samples.Count * Random.Range(90, 100) / 100];
            target = target * Random.Range(90, 101) / 100 - 1;
            objStr = "a number greater than " + target.ToString();
        }
        else
        {
            target = samples[samples.Count * Random.Range(0, 10) / 100];
            target = target * Random.Range(100, 111) / 100 + 1;
            objStr = "a number less than " + target.ToString();
        }
        //Debug.Log(string.Join(", ", nums));
        //Debug.Log(string.Join(", ", samples));
        //Debug.Log(objStr);
        return objStr;
    }

    int Sample(int nnums, List<int> nums, List<char> ops)
    {
        var nums_index = new List<int>();
        var ops_index = new List<int>();
        while (nums_index.Count < nnums)
        {
            int r = Random.Range(0, nums.Count);
            bool match = false;
            foreach (var n in nums_index) if (n == r) match = true;
            if (!match) nums_index.Add(r);
        }
        while (ops_index.Count < nnums - 1)
        {
            int r = Random.Range(0, ops.Count);
            bool match = false;
            foreach (var n in ops_index) if (n == r) match = true;
            if (!match) ops_index.Add(r);
        }
        var expression = System.Convert.ToString(nums[nums_index[0]]);
        nums_index.RemoveAt(0);
        while (nums_index.Count > 0)
        {
            expression += " " + ops[ops_index[0]] + " " + nums[nums_index[0]];
            ops_index.RemoveAt(0);
            nums_index.RemoveAt(0);
        }
        var rval = Eval(expression);
        return rval;
    }

    int Eval(string expression)
    {
        var table = new System.Data.DataTable();
        return System.Convert.ToInt32(table.Compute(expression, string.Empty));
    }
}