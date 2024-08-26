using UnityEngine;

public class LabelAndButton : MonoBehaviour
{
    public Texture tex;
    public Texture tex1;

    public Texture2D btnNormalTex;
    public Texture2D btnOverTex;
    public Texture2D btnClickTex;

    private GUIStyle style;
    public GUIStyle btnStyle;

    public void Start()
    {
        style = new GUIStyle();
        style.fontSize = 15;
        style.normal.textColor = Color.red;

        btnStyle = new GUIStyle();
        btnStyle.fontSize = 20;
        // 正常的图和文本颜色
        btnStyle.normal.background = btnNormalTex;
        btnStyle.normal.textColor = Color.white;
        // 鼠标移上去的图和文本颜色
        btnStyle.hover.background = btnOverTex;
        btnStyle.hover.textColor = Color.black;
        // 鼠标点击的图和文本颜色
        btnStyle.active.background = btnClickTex;
        btnStyle.active.textColor = Color.white;

        btnStyle.alignment = TextAnchor.MiddleCenter;
    }

    private void OnGUI()
    {
        #region 文本
        // 单个文本
        GUI.Label(new Rect(0, 0, 100, 30), "文本1");
        // 图片文本
        GUI.Label(new Rect(0, 40, 276, 97), tex);
        // 左图+右文本
        GUI.Label(new Rect(0, 147, 100, 30), new GUIContent("文本2", tex1, "tooltips"));
        // 鼠标移动到第三个文本，会将第三个文本的tooltips打印出来
        if(!GUI.tooltip.Equals(string.Empty))
        {
            Debug.Log(GUI.tooltip);
        }
        // 通过style设置文本属性
        GUI.Label(new Rect(0, 187, 100, 30), "文本3", style);
        #endregion

        #region
        // 普通按钮
        if(GUI.Button(new Rect(0, 227, 100, 30), "按钮1"))
        {
            Debug.Log("点击了按钮1");
        }
        // 自定义按钮
        if(GUI.Button(new Rect(0, 267, 145, 62), "按钮2", btnStyle))
        {
            Debug.Log("点击了按钮2");
        }
        // 自定义图标+文本按钮
        if (GUI.Button(new Rect(0, 349, 145, 62), new GUIContent("按钮3", tex1), btnStyle))
        {
            Debug.Log("点击了按钮2");
        }
        #endregion
    }
}
