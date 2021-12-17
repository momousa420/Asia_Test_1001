using UnityEngine;
using UnityEngine.UI;
using System.Collections;

/// <summary>
/// ��ܨt��
/// �N�ݭn��X����r�Q�Υ��r�ĪG�e�{
/// </summary>
public class DialogueSystem : MonoBehaviour
{
    #region  �Ѽ�
    [Header("��ܶ��j"), Range(0, 1)]
    public float interval = 0.3f;
    [Header("�e����ܨt��")]
    public GameObject goDialogue;
    [Header("��ܤ��e")]
    public Text textContent;
    [Header("��ܧ����ϥ�")]
    public GameObject goTip;
    [Header("��ܫ���")]
    public KeyCode keyDialogue = KeyCode.Z;
    #endregion

    #region �ƥ�
    private void Start()
    {
        //StartCoroutine(TypeEffect());
    }
    #endregion

    #region ��k

    /// <summary>
    /// ���r�ĪG
    /// </summary>
    /// <param name="contents">�Q�n�X�{�b��ܨt�Ϊ���ܤ��e�A�ݨϥΦr��}�C</param>
    private IEnumerator TypeEffect(string[] contents)
    {
        //�󴫦W�٧ֱ��� Ctrl + R R

        //���ե�
        //string test1 = "�����O�ڰաA";
        //string test2 = "���T�}��";
        //string[] contents = {test1, test2};

        goDialogue.SetActive(true);                           //��ܹ�ܪ���

        for (int j = 0; j < contents.Length; j++)                 //�M�M�Ҧ����
        {
            textContent.text = "";                            //�M���W����ܤ��e
            goTip.SetActive(false);                           //���ô��ܹϮ� (�T����)

            for (int i = 0; i < contents[j].Length; i++)          //�M�M��ܪ��C�@�Ӧr
            {
                textContent.text += contents[j][i];               //�|�[��ܤ��e��r����
                yield return new WaitForSeconds(interval);
            }

            goTip.SetActive(true);
            while (!Input.GetKeyDown(keyDialogue))
            {
                yield return null;
            }

        }
        goDialogue.SetActive(false);                          //���ù�ܪ���
        
    }

    /// <summary>
    /// �}�l���
    /// </summary>
    /// <param name="contents">�n��ܥ��r�ĪG����ܤ��e</param>
    public void StartDialogue(string[] contents)
    {
        StartCoroutine(TypeEffect(contents));
    }


    /// <summary>
    /// ������
    /// </summary>
    public void StopDialogue()
    {
        StopAllCoroutines();                      //�����{
        goDialogue.SetActive(false);              //���ù�ܤ���
    }


    #endregion

}
