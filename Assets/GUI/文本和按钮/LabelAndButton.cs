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
        // ������ͼ���ı���ɫ
        btnStyle.normal.background = btnNormalTex;
        btnStyle.normal.textColor = Color.white;
        // �������ȥ��ͼ���ı���ɫ
        btnStyle.hover.background = btnOverTex;
        btnStyle.hover.textColor = Color.black;
        // �������ͼ���ı���ɫ
        btnStyle.active.background = btnClickTex;
        btnStyle.active.textColor = Color.white;

        btnStyle.alignment = TextAnchor.MiddleCenter;
    }

    private void OnGUI()
    {
        #region �ı�
        // �����ı�
        GUI.Label(new Rect(0, 0, 100, 30), "�ı�1");
        // ͼƬ�ı�
        GUI.Label(new Rect(0, 40, 276, 97), tex);
        // ��ͼ+���ı�
        GUI.Label(new Rect(0, 147, 100, 30), new GUIContent("�ı�2", tex1, "tooltips"));
        // ����ƶ����������ı����Ὣ�������ı���tooltips��ӡ����
        if(!GUI.tooltip.Equals(string.Empty))
        {
            Debug.Log(GUI.tooltip);
        }
        // ͨ��style�����ı�����
        GUI.Label(new Rect(0, 187, 100, 30), "�ı�3", style);
        #endregion

        #region
        // ��ͨ��ť
        if(GUI.Button(new Rect(0, 227, 100, 30), "��ť1"))
        {
            Debug.Log("����˰�ť1");
        }
        // �Զ��尴ť
        if(GUI.Button(new Rect(0, 267, 145, 62), "��ť2", btnStyle))
        {
            Debug.Log("����˰�ť2");
        }
        // �Զ���ͼ��+�ı���ť
        if (GUI.Button(new Rect(0, 349, 145, 62), new GUIContent("��ť3", tex1), btnStyle))
        {
            Debug.Log("����˰�ť2");
        }
        #endregion
    }
}
