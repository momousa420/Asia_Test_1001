using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//�إ߱M�פ������(menuName = "�M�צW��") ��Ƨ�/�l���
[CreateAssetMenu(menuName = "FDay Learning/��ܸ��")]
///<summary>
///��ܸ��
///�O�s NPC �n�缾�a������ܤ��e
///</summary>
///ScriptableObject �}���ƪ���G�N�{������x�s�� Project ��������

public class DataDialogue : ScriptableObject
{
    [Header("��ܤ��e"), TextArea(3, 5)]
    public string[] dialogue;
}
