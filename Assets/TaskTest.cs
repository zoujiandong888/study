using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TaskTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TaskFunc();
        print("主线程逻辑");
    }

    private void TaskFunc()
    {
        Task t = new Task(() => {
            print("进入Task逻辑");
            int i = 0;
            while(i <= 5)
            {
                Thread.Sleep(1000);
                i++;
                print($"i={i}");
            }
        });
        t.Wait();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
