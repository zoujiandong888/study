using UnityEngine;

public class InputAndSlider : MonoBehaviour
{
    private string inputStr;
    private string passwordStr = "";

    private float horizontalValue;
    private float verticalValue;

    private void Start()
    {
    }

    private void OnGUI()
    {
        // 普通输入框
        inputStr = GUI.TextField(new Rect(0, 0, 200, 20), inputStr);
        // 密码输入框
        passwordStr = GUI.PasswordField(new Rect(0, 30, 200, 20), passwordStr, '*');
        // 水平拖动条
        horizontalValue = GUI.HorizontalSlider(new Rect(0, 60, 100, 10), horizontalValue, 0, 1);
        // 垂直拖动条
        verticalValue = GUI.VerticalSlider(new Rect(0, 80, 10, 100), verticalValue, 0, 1);

    }
}
