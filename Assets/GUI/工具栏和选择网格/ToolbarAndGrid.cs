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
        // Ĭ�ϰ�ť������ selected: ѡ���˵ڼ�����0��ʼ
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 150, 30), selected: toolbarIndex, new string[] { "ѡ��1", "ѡ��2", "ѡ��3" });
        // ѡ������ xCount:ˮƽ���������ʾ�İ�ť����
        gridIndex = GUI.SelectionGrid(new Rect(0, 40, 150, 60), selected: gridIndex, new string[] { "ѡ��1", "ѡ��2", "ѡ��3" }, xCount: 2);
    }
}
