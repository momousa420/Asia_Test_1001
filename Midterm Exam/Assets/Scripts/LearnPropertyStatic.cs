
using UnityEngine;

/// <summary>
/// �ǲ��R�A�ݩ� Static Property
/// </summary>

public class LearnPropertyStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //�R�A�ݩ�
        //���o Get
        //�y�k�G���O�W��.�R�A�ݩʦW��
        print("�H���ȡG" + Random.value);
        print("�Ҧ���v���ƶq�G" + Camera.allCamerasCount);

        //�]�w Set - ����� Read Only �ݩʫ��w
        //�y�k�G���O�W��.�R�A�ݩʦW�� ���w ��;
        Time.timeScale = 0.5f;
        Cursor.visible = false;

        //Random.value = 0.5f         // Read Only ����]�w
    }
}
