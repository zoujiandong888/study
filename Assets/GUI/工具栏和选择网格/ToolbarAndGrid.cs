using UnityEngine;

public class ToolbarAndGrid : MonoBehaviour
{
    private int toolbarIndex;
    private int gridIndex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnGUI()
    {
        // 默认按钮工具栏 selected: 选择了第几个从0开始
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 150, 30), selected: toolbarIndex, new string[] { "选项1", "选项2", "选项3" });
        // 选择网格 xCount:水平方向最多显示的按钮数量
        gridIndex = GUI.SelectionGrid(new Rect(0, 40, 150, 60), selected: gridIndex, new string[] { "选项1", "选项2", "选项3" }, xCount: 2);
    }
}
