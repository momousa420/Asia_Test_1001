using System.Collections;    //�ޥ� �t��.���X  �]�t��P�{��
using System.Collections.Generic;
using UnityEngine;

public class LearnCoroutine : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(Test());
        StartCoroutine(TestWithLoop());
    }


    private IEnumerator Test()
    {
        print("�o�O�Ĥ@�q��r");       
        yield return new WaitForSeconds(1);
        print("�o�O�ĤG�q��r");
        yield return new WaitForSeconds(3);
        print("�����O�ڰ�");
    }

    private IEnumerator TestWithLoop()
    {
        for (int i = 0; i < 15; i++)
        {
            print("�Ʀr�G" + i);
            yield return new WaitForSeconds(0.1f);
        }
    }
}
