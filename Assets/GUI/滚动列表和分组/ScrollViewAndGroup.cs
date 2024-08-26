using UnityEditor;
using UnityEngine;

public class ScrollViewAndGroup : MonoBehaviour
{
    private Vector2 scrollPos;
    private int toolbarIndex;

    private void OnGUI()
    {
        #region ����
        /**
         * ʹ��GUI.BeginGroup()��GUI.EndGroup()��ʵ��
         * ���ڿ���һ��ؼ��ķָ��Ϊд��BeginGroup��EndGroup�м�Ŀؼ��ĸ�����
         */
        GUI.BeginGroup(new Rect(0, 20, 200, 200));
        // ����ı�����Ե�λ���Ǵ�(0, 20)��ʼ
        GUI.Label(new Rect(0, 0, 100, 30), "�ı�1");// ����ı������Ͻ������Ļ��λ��Ϊ(0 + 0, 20 + 0)
        GUI.EndGroup();
        #endregion
        // �����б� ���viewRect�Ŀ��position�Ŀ�󣬻����ˮƽ�����������viewRect�ĸ߱�position�ĸߴ󣬻���ִ�ֱ������
        scrollPos = GUI.BeginScrollView(position: new Rect(0, 230, 200, 200), scrollPos, viewRect: new Rect(0, 0, 400, 400));
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 400, 50), toolbarIndex, new string[] { "ѡ��1", "ѡ��2", "ѡ��3", "ѡ��4", "ѡ��5"});
        GUI.EndScrollView();

        EditorUserBuildSettings.buildAppBundle = true;
    }
}
