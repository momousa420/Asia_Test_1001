
using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1.���w =
/// 2.�ƾ� + - * /  �l��:%  ���W:++  ����:--
/// 3.���
/// 4.�޿�
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region ���w�B��l
    //���w�B��l�S�ʡG
    //�����w�B��l�|���B��k��A���w������
    public int number = 10;     //���w�G�N�Ʀr10���w�����number

    public float numberA = 20;
    public float numberB = 3;
    public int numberC = 30;
    #endregion

    #region  �ƾǹB��l
    private void Start()
    {
        print("�[�k" + (numberA + numberB));
        print("��k" + (numberA - numberB));
        print("���k" + (numberA * numberB));
        print("���k" + (numberA / numberB));
        print("�l��" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC��1�G" + numberC);
        numberC--;                           //����
        print("numberC��1�G" + numberC);

    }
    #endregion
}
