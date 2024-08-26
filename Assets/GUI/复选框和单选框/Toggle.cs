using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toggle : MonoBehaviour
{
    private bool toggleValue1;
    private bool toggleValue2;

    private int toggleIndex = 1;

    private void OnGUI()
    {
        toggleValue1 = GUI.Toggle(new Rect(0, 0, 100, 30), toggleValue1, "��ѡ��1");
        toggleValue2 = GUI.Toggle(new Rect(0, 40, 100, 30), toggleValue2, "��ѡ��2");

        if(GUI.Toggle(new Rect(0, 80, 100, 30), toggleIndex == 1, "��ѡ��1"))
        {
            toggleIndex = 1;
        }
        if(GUI.Toggle(new Rect(0, 120, 100, 30), toggleIndex == 2, "��ѡ��2"))
        {
            toggleIndex = 2;
        }
        if (GUI.Toggle(new Rect(0, 160, 100, 30), toggleIndex == 3, "��ѡ��3"))
        {
            toggleIndex = 3;
        }
    }
}
