using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnProperty : MonoBehaviour
{
    //�D�R�A�ݩʨϥΤ覡
    //1.�w�q�@�����A�Ω��x�s������
    //2.��������������P�Q�s�����D�R�A�ݩ������ۦP
    //3.��쥲���s����骫�� (�N����즲����줺)
    public Transform traA;
    public Camera camA;
    private void Start()
    {
        //���o Get
        //�y�k�G���W��.�D�R�A�ݩʦW��
        print("A���󪺮y�СG" + traA.position);
        print("A��v�����`�סG" + camA.depth);
        //�]�w Set
        //�y�k�G���W��.�D�R�A�ݩʦW�� ���w ��;
        camA.depth = 9.9f;
        traA.position = new Vector3(-7, 3);
    }
}

   
