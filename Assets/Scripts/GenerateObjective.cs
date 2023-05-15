using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GenerateObjective : MonoBehaviour
{
    int fnum = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        if (false)//(++fnum % 60==0)
        {
            var nums = new List<int>();
            var ops = new List<char>();
            for (int i = 0; i < 5; ++i) nums.Add(Random.Range(1, 11));
            nums.Sort();
            ops.Add('+');
            ops.Add('+');
            ops.Add('+');
            ops.Add('+');
            ops.Add('*');
            var samples = new List<int>();
            for (int i = 0; i < 100; ++i) samples.Add(Sample(3, nums, ops));
            samples = samples.Distinct().ToList();
            samples.Sort();
            Debug.Log(string.Join(", ", nums));
            Debug.Log(string.Join(", ", samples));
        }
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
        while (ops_index.Count < nnums-1)
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