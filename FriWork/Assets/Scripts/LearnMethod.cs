using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �D�R�A��k
/// </summary>
public class LearnMethod : MonoBehaviour
{
    //�D�R�A��k�ϥΤ覡
    //1.�w�q�@�����A�Ω��x�s������
    //2.��������������P�Q�s�����D�R�A�ݩ������ۦP
    //3.��쥲���s����骫�� (�N����즲����줺)

    public Transform traObject;
    public Rigidbody2D rig;

    private void Start()
    {
        //�D�R�A��k
        //�I�s��k
        //�y�k�G���W��.�D�R�A��k�W��(�������޼�);
        traObject.Rotate(0, 0, 10);

        
    }

    //��s�ƥ�G�@������ 60 ��     60FPS
    private void Update()
    {
        traObject.Rotate(0, 0, 10);
        rig.AddForce(new Vector2(0, 30));

    }

}
