using UnityEngine;    //�ޥ�Unity�����R�W�Ŷ��G�i�ϥΦ��Ŷ���API

//������
//2021_10_22
//class ���O�G�����Ź�
//�y�k ���O ���O ���O�W�١a���O���e(����)�b
//�����O�n�b Unity ���ϥΥ����~�� MonoBehaviour
//�A��"�Ҷ�"����X�{�G()�B[]�B{}�B<>�B''�B""
public class Car : MonoBehaviour
{
    #region ���y�k�Υ|�j�`������
    //��� Field�G�O�s�U�����������
    //�y�k�G�׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    //���|�j�`�������G
    //��@�ơG�x�s�S���p���I�����t��� - int
    //�B�I�ơG�x�s�a���p���I�����t��� - float
    //�r�@��G�x�s��r��T�@�@�@�@�@�@ - string
    //���L�ȡG�O�P�_ true�Bfalse�@�@  - bool
    //���׹���
    //�p�H�G��L���O����s���B����� private
    //���}�G��L���O�i�H�s���B��@�� public
    //����ݩ� Attritube
    //�y�k�G[�ݩʦW��(��)]
    //1. ���D Header(�r��)
    //2. ���� Tooltup(�r��)
    //3. �d�� Range(�̤p�ȡA�̤j��) - �ȾA�Ω�ƭ�����

    public int cc = 1000;
    [Range(1, 10)]
    public float weight = 3.5f;
    [Tooltip("���l���~�P�W��")]
    public string brand = "���h";
    [Header("�O�_���ѵ�")]
    public bool hasSkyWindow = true;
    #endregion

    #region Unity ���������
    //�C��B�V�q�B(�y��)�B����B�C������B����
    //�C�� Color
    public Color color;
    public Color colorRed = Color.red;
    public Color colorCustum1 = new Color(1, 0, 1, 0.8f);

    //�V�q Vector
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2Right = Vector2.right;
    public Vector2 v2Custum = new Vector2(1, 5);
    public Vector3 v3Custum = new Vector3(1, 3, 5);
    public Vector4 v4Custum = new Vector4(1, 2, 3, 4);

    //���� Keycode
    public KeyCode Keycode;
    public KeyCode KeycodeMouseLeft = KeyCode.Mouse0;
    public KeyCode KeycodeJump = KeyCode.Space;

    //�C������ GameObject
    public GameObject goCamera;

    //���� Component
    public Transform traCamera;
    public Camera cam;
    #endregion

    #region �ƥ�G�{�����J�f
    //�}�l�ƥ�G�C������ɰ���@��
    private void Start()
    {
        //�I�s��k�G��k�W��();
        Test();
        Drive80();
        Drive(120);�@�@�@�@�@�@//�I�s�ɶ�J���٬��G�޼�

        float w99 = ConvertWeight(9.9f);
        print("9.9�ഫ�G" + w99);
        print("���q�ഫ�G" + ConvertWeight(weight));
    }
    #endregion

    #region ��k�y�k
    //��k�G�O�s�{�����e���϶��A���z���B�t��k
    //�y�k�G�׹��� �Ǧ^���� ��k�W��  (�Ѽ�1�A�Ѽ�2�A...�A�Ѽ�N) { �{�����e }
    //�L�Ǧ^ void�G�ϥΤ�k�ɤ��|�Ǧ^���
    //�ۭq��k�G���|����A�����I�s�~�|����
    private void Test()
    {
        //��X(�T��) - �N�T����X�� Unity �����O Console
        print("Hello,World :D ");
    }
    private void Drive80()
    {
        print("�}���ɳt�G" + 80);
    }
    private void Drive(int speed)
    {
        print("�}���ɳt�G" + speed);
        print("�}�����ġG��~");
    }

    private float ConvertWeight(float setWeight)
    {
        return setWeight * 50;
    }
    #endregion
}