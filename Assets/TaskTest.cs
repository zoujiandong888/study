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
        print("���߳��߼�");
    }

    private void TaskFunc()
    {
        Task t = new Task(() => {
            print("����Task�߼�");
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
