
using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1.���w =
/// 2.�ƾ� + - * / %
/// 3.���
/// 4.�޿�
/// </summary>
public class LearnOperator : MonoBehaviour
{
    //���w�B��l�S�ʡG
    //�����w�B��l�|���B��k��A���w������
    public int number = 10;     //���w�G�N�Ʀr10���w�����number

    public float numberA = 20;
    public float numberB = 3;

    private void Start()
    {
        print("�[�k" + (numberA + numberB));
        print("��k" + (numberA - numberB));
        print("���k" + (numberA * numberB));
        print("���k" + (numberA / numberB));
        print("�l��" + (numberA % numberB));

    }
}
