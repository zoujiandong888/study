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
        // ͼƬ����
        // scaleMode: ScaleMode.ScaleAndCrop���ֿ�߱ȣ�ȡ������ŵ����ֵ���ᵼ��ĳЩ���򿴲��� ScaleMode.StretchToFill ����� StretchToFill.ScaleToFit ���ֿ�߱ȣ�ȡ������ŵ���Сֵ������ʼ����������
        // alphaBlend �Ƿ�ȡͼƬ��͸���ȣ����Ϊfalse��ԴͼƬ͸�����򽫻᲻͸����ʾ 
        // imageAspect ָ��ͼƬ�ĳ����
        GUI.DrawTexture(new Rect(0, 0, 100, 200), tex, scaleMode : ScaleMode.ScaleToFit, alphaBlend: true/**, imageAspect:0.5f*/);
        // ��
        GUI.Box(new Rect(0, 210, 100, 100), "");
    }
}
