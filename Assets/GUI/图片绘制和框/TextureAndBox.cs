using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureAndBox : MonoBehaviour
{
    public Texture tex;
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
        // 图片绘制
        // scaleMode: ScaleMode.ScaleAndCrop保持宽高比，取宽高缩放的最大值，会导致某些区域看不见 ScaleMode.StretchToFill 填充满 StretchToFill.ScaleToFit 保持宽高比，取宽高缩放的最小值，但是始终填满区域
        // alphaBlend 是否取图片的透明度，如果为false，源图片透明区域将会不透明显示 
        // imageAspect 指定图片的长宽比
        GUI.DrawTexture(new Rect(0, 0, 100, 200), tex, scaleMode : ScaleMode.ScaleToFit, alphaBlend: true/**, imageAspect:0.5f*/);
        // 框
        GUI.Box(new Rect(0, 210, 100, 100), "");
    }
}
