
using UnityEngine;

/// <summary>
/// �ǲ߰j��
/// 1.while *
/// 2.do while
/// 3.for *
/// 4.foreach
/// </summary>

public class LearnLoop : MonoBehaviour
{
    private void Start()
    {
        //�j��@�ΡG
        //���ư���ۦP�{���åB�i�H���w����

        #region while �j��
        //�y�k�G
        //while (���L��) { �{�����e }
        //�S�ʡG���L�Ȭ� true �|������� {} ���쥬�L�Ȭ� false
        int i = 1;
        while (i < 11)
        {
            print("while �j��G" + i);
            i++;
        }
        #endregion

        #region for �j��
        //�y�k�G
        //for (��l��;���L��;�j�鵲����n���檺�{��;) { �{�����e }
        for (int j = 1; j < 11; j++)
        {
            print("for�j��G" + j);
        }
        #endregion
    }
}