using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �ǲ��R�A��k
/// </summary>
public class LearnMethodStatic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //�R�A��k
        //�I�s��k
        //�y�k�G���O�W��.�R�A��k�W��(�������޼�);
        int rInt = Random.Range(1, 3);
        print("�H����� 1 �P 3 �G" + rInt);
        print("-99������ȡG" + Mathf.Abs(-99));
    }
}

