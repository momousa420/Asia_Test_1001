
using UnityEngine;

/// <summary>
/// ����G2D ��V���b ���Ⲿ��
/// </summary>

public class MovingController : MonoBehaviour
{
    #region ���G���}
    [Header("���ʳt��"), Range(0, 500 )]
    public float speed = 3.5f;

    [Header("���D����"), Range(0, 1500)]
    public float jump = 10f;
    #endregion

    /// <summary>
    /// ���餸��
    /// </summary>
    private Rigidbody2D rig;

    private void Start()
    {
       rig = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    #region ��k
    /// <summary>
    /// 1.���a�O�_�����ʫ���  ���k��V�� or A�BD
    /// 2.���󲾰ʦ欰(API)
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("���a���k����ȡG" + h);
    }

    #endregion
}
