
using UnityEngine;

/// <summary>
/// ����G2D ��V���b ���Ⲿ��
/// </summary>

public class MovingController : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 500)]
    public float speed = 3.5f;

    [Header("���D����"), Range(0, 1500)]
    public float jump = 300f;

    [Header("�ˬd�a�O�ؤo�P�첾")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("���D����P�i���D�ϼh")]
    public KeyCode keyJump = KeyCode.Space;
    public LayerMask canJumpLayer;
    [Header("�ʵe�ѼơG�����P���D")]
    public string parameterWalk ="�}������";
    public string parameterJump = "�}�����D";
    #endregion


    #region ���G�p�H
    private Animator ani;

    /// <summary>
    /// ���餸��
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    /// �O�_�b�a�O�W
    /// </summary>
    [SerializeField]
    private bool isGrounded;
    #endregion


    #region �ƥ�
    /// <summary>
    /// ø�s�ϥ�
    /// �bUnityø�s���U�Ϊ��ϥ�
    /// �u���B�g�u�B��ΡB��ΡB����
    /// </summary>
    private void OnDrawGizmos()
    {
        //1.�M�w�ϥ��C��
        Gizmos.color = new Color(2, 0, 0.2f, 0.3f);
        //2.�M�wø�s�ϧ�
        Gizmos.DrawSphere(transform.position + 
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }

    private void Start()
    {
       rig = GetComponent<Rigidbody2D>();
       ani = GetComponent<Animator>();
    }

    /// <summary>
    /// Update�� 60 FPS �T�w��s�ƥ�G50 FPS �B�z���z�欰
    /// </summary>
    private void FixedUpdate()
    {
        //������� = ���o����<2D ����>
        Move();
    }

    private void Update()
    {
        Flip();
        CheckGround();
        Jump();
    }
    #endregion


    #region ��k
    /// <summary>
    /// 1.���a�O�_�����ʫ���  ���k��V�� or A�BD
    /// 2.���󲾰ʦ欰(API)
    /// </summary>
    private void Move()
    {
        //h �� ���w�� ��J.���o�b�V(�����b) - �����b�N���k��P AD
        float h = Input.GetAxis("Horizontal");
        //print("���a���k����ȡG" + h);

        //���餸��.�[�t�� = �s�G���V�q(h �� * ���ʳt��, ����.�[�t��.����)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);

        ani.SetBool(parameterWalk, h != 0);
    }

    /// <summary>
    /// ½���G
    /// ���G���� Y 180
    /// �k�G���� Y 0
    /// </summary>
    private void Flip()
    {
        float h = Input.GetAxis("Horizontal");

        if (h > 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        else if (h < 0)
        {
            transform.eulerAngles = Vector3.zero;
        }
    }

    /// <summary>
    /// �ˬd�O�b�a�O
    /// </summary>
    private void CheckGround()
    {
        //�I����T = 2D ���z.�л\���(�����I, �b�|, �ϼh)
        Collider2D hit = Physics2D.OverlapCircle(transform.position +
        transform.TransformDirection(checkGroundOffset), checkGroundRadius, canJumpLayer);

        //print("�I�쪺����W�١G" + hit.name);
        isGrounded = hit;

        ani.SetBool(parameterJump, !isGrounded);
    }

    /// <summary>
    /// ���D
    /// </summary>
    private void Jump()
    {
        //�p�G �b�a�O�W �åB ���U���w����
        if (isGrounded && Input.GetKeyDown(keyJump))
        {
            //����.�K�[���O(�G���V�q)
            rig.AddForce(new Vector2(0, jump));
        }
    }
    #endregion


}
