using UnityEditor;
using UnityEngine;

public class ScrollViewAndGroup : MonoBehaviour
{
    private Vector2 scrollPos;
    private int toolbarIndex;

    private void OnGUI()
    {
        #region 分组
        /**
         * 使用GUI.BeginGroup()和GUI.EndGroup()来实现
         * 用于控制一组控件的分割，作为写在BeginGroup和EndGroup中间的控件的父容器
         */
        GUI.BeginGroup(new Rect(0, 20, 200, 200));
        // 这个文本的相对的位置是从(0, 20)开始
        GUI.Label(new Rect(0, 0, 100, 30), "文本1");// 这个文本的左上角相对屏幕的位置为(0 + 0, 20 + 0)
        GUI.EndGroup();
        #endregion
        // 滚动列表 如果viewRect的宽比position的宽大，会出现水平滚动条，如果viewRect的高比position的高大，会出现垂直滚动条
        scrollPos = GUI.BeginScrollView(position: new Rect(0, 230, 200, 200), scrollPos, viewRect: new Rect(0, 0, 400, 400));
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 400, 50), toolbarIndex, new string[] { "选项1", "选项2", "选项3", "选项4", "选项5"});
        GUI.EndScrollView();

        EditorUserBuildSettings.buildAppBundle = true;
    }
}
