
using UnityEngine;

/// <summary>
/// �{�ѧP�_�� (����)
/// </summary>
public class LearnCondition : MonoBehaviour
{
    public bool openDoor;
    public int score = 70;
    public string weapon = "�M�l";

    // Start is called before the first frame update
    
    //�}�l�ƥ�G����C���ɰ���@��
    private void Start()
    {
        #region �P�_�� if
        //�y�k�G
        //���L�Ȭ� true �A���� if �� {}
        //if (���L��) { �{�����e }
        if (true) 
        {
            print("�{�ѧP�_��if");

        }

        //���L�Ȭ� true �A���� if �� {}
        //���L�Ȭ� false �A���� else �� {}
        //if (���L��) { �{�����e }
        //else { �{�����e }
        if (openDoor)
        {
            print("�}��!");
        }
        else
        {
            print("����!");
        }

        #endregion
    }

    //��s�ƥ�G���@���Q�� (60 FPS)
    private void Update()
    {

        #region �P�_�� if
        print("�������~");

        //�_�h �p�G else if (���L��) { �{�����e } - if�U�� else�W�� - �L�ƶq����
        //�p�G >= 60 �ή�
        //�p�G <= 60 ���O >= 40 �ɦ�
        //�_�h ���ή�

        if(score >= 60)
        {
            print("�ή�");
        }
        else
        {
            print("���ή�");
        }
        #endregion

        #region �P�_�� switch
        //switch (��)
        //{
        //    case "�M�l":
        //         �����O�G10;
        //         break;
        //    case "�����j":
        //         �����O�G1000;
        //         break;
        //    default:
        //         �o���O�Z��;
        //         break;
        //}

        switch (weapon)
        {
            case "�M�l":
                print("�����O 10");
                break;
            case "�����j":
                print("�����O 1000");
                break;
            default:
                print("�o���O�Z���I");
                break;
        }

        #endregion
    }
}
