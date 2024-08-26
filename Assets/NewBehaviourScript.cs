using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        (int, float, string) b = (1, 1.5f, "hello");
        Debug.Log(b.Item1);
        Debug.Log(b.Item2);
        Debug.Log(b.Item3);

        (int i, float f, string str) a = (1, 1.5f, "hello");
        Debug.Log(a.i);
        Debug.Log(a.f);
        Debug.Log(a.str);

        List<(int a, int b, float c)> list = new List<(int a, int b, float c)>();
        list.Add((1, 2, 1 / 5f));
        foreach((int v1, int v2, var v3) in list)
        {
            Debug.Log($"{v1}, {v2}, {v3}");
        }

        object o = 1;
        if(o is 1)
        {

        }

        switch(o)
        {
            case int i:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
