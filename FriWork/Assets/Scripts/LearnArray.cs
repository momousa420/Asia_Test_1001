using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ǲ߰}�C Array
/// </summary>

public class LearnArray : MonoBehaviour
{
    #region �}�C
    //�T�ӹD�㪺����G100 200 300
    public int priceA = 100;
    public int priceB = 200;
    public int priceC = 300;

    //�}�C�S�ʡG�x�s�ۦP�������
    //�y�k�G
    //�׹��� �������[] �}�C�W�� ���w ��;
    public int[] pricese;

    //�}�C��l��
    //�Ĥ@�ءG���w�}�C�ƶq
    public int[] scores = new int[5];
    //�ĤG�ءG���w�}�C��
    public string[] props = { "����" , "����" , "�Ť�" };

    public int[] levels = new int[10];
    private void Start()
    {
        //���o�}�C��� Get
        //�y�k�G�}�C�W��[�s��] - �s���q�s�}�l
        print("�ĤT���D��G" + props[2]);
        //�]�w�}�C��� Set
        //�y�k�G�}�C�W��[�s��] ���w ��;
        props[1] = "�_��";
        print("�ĤG���D��G" + props[1]);

        //�}�C���ƶq
        print("���Ű}�C���ƶq�G" + levels.Length);

        for (int i = 0; i < 10; i++)
        {
            levels[i] = (i + 1);
        }
    }
    #endregion
}

