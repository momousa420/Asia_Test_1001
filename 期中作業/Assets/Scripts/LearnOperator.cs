
using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1.���w =
/// 2.�ƾ� + - * /  �l��:%  ���W:++  ����:--
/// 3.��� > < >= <= == !=
/// 4.�޿� &&(�åB)  ||(�Ϊ�)  �A�� !
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
    public int numberD = 5;

    public int numberE = 9;
    public int numberF = 1;

    #endregion

    #region  
    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k" + (numberA + numberB));
        print("��k" + (numberA - numberB));
        print("���k" + (numberA * numberB));
        print("���k" + (numberA / numberB));
        print("�l��" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC��1�G" + numberC);
        numberC--;                           //����
        print("numberC��1�G" + numberC);

        numberD = numberD + 10;
        print("numberD �[ 10�G" + numberD);
        numberD += 10;                       //���W���w + - * / %
        print("numberD �[ 10�G" + numberD);
        #endregion

        #region ����B��l
        //�@�ΡG�����ӭȡA�è��o���L�ȵ��G
        print("E > F�G" + (numberE > numberF));
        print("E < F�G" + (numberE < numberF));
        print("E >= F�G" + (numberE >= numberF));
        print("E <= F�G" + (numberE <= numberF));
        print("E == F�G" + (numberE == numberF));
        print("E != F�G" + (numberE != numberF));

        #endregion

        #region �޿�B��l
        //�@�ΡG�����ӥ��L�ȡA�è��o���L�ȵ��G
        //�åB�G�u�n���@��false�A���G��false
        print("T && T�G" + (true && true));
        print("T && F�G" + (true && false));
        print("F && T�G" + (false && true));
        print("F && F�G" + (false && false));

        //�εۡG�u�n���@��true�A���G��true
        print("T || T�G" + (true || true));
        print("T || F�G" + (true || false));
        print("F || T�G" + (false || true));
        print("F || F�G" + (false || false));

        //�A�ˡG�N���L�ȵ����ۤ�
        print("!true�G" + (!true));
        print("!false�G" + (!false));
        #endregion
    }
    #endregion
}
