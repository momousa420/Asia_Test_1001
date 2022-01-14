using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region ���
    [Header("�ˬd�l�ܰϰ�j�p�P�첾")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("���ʳt��")]
    public float speed = 1.5f;
    [Header("�ؼйϼh")]
    public LayerMask layerTarget;
    [Header("�ʵe�Ѽ�")]
    public string parameterWalk = "�}������";
    public string parameterAttack = "Ĳ�o����";
    [Header("���V�ؼЪ���")]
    public Transform target;
    [Header("�����Z��"), Range(0, 5)]
    public float attackDistance = 1.5f;
    [Header("�����N�o�ɶ�"),Range(0,10)]
    public float attackCD = 3.5f;
    [Header("�ˬd�����ϰ�j�p�P�첾")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;
    #endregion

    #region �ƥ�
    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = new Color(1, 0, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3TrackOffset), v3TrackSize);
        Gizmos.color = new Color(0, 1, 0, 0.3f);
        Gizmos.DrawCube(transform.position + transform.TransformDirection(v3AttackOffset), v3AttackSize);
    }

    private void Update()
    {
        CheckTargetInArea();
    }
    #endregion

    #region ��k
    private void CheckTargetInArea()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.
            TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) Move();

    }

    private void Move()
    {
        //�p�G �ؼЪ� X �p�� �ĤH�� X �N�N��b���� ����0
        //�p�G �ؼЪ� X �j�� �ĤH�� X �N�N��b�k�� ����180
        if (target.position.x>transform.position.x)
        {
            //�k��angle = 180
        }
        else if (target.position.x<transform.position.x)
        {
            //����angle = 0
        }
        //�T���B��l�y�k�G���L�ȡH���L�Ȭ� true :���L�� ��
        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        float distance = Vector3.Distance(target.position, transform.position);
        //print("�P�ؼЪ��Z���G" + distance);

        if (distance <= attackDistance)
        {
            rig.velocity = Vector3.zero;
            Attack();
        }
    }

    [Header("�����O"), Range(0, 100)]
    public float attack = 35;

    private void Attack()
    {
        if (timerAttack < attackCD)
        {
            timerAttack += Time.deltaTime;
        }
        else
        {
            ani.SetTrigger(parameterAttack);
            timerAttack = 0;
            Collider2D hit = Physics2D.OverlapBox(transform.position + transform.
                TransformDirection(v3AttackOffset), v3AttackSize, 0, layerTarget);
            print("�����쪫��G" + hit.name);
            hit.GetComponent<HurtSystem>().Hurt(attack);
        }
    }
    #endregion
}
