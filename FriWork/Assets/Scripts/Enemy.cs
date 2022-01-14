using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("檢查追蹤區域大小與位移")]
    public Vector3 v3TrackSize = Vector3.one;
    public Vector3 v3TrackOffset;
    [Header("移動速度")]
    public float speed = 1.5f;
    [Header("目標圖層")]
    public LayerMask layerTarget;
    [Header("動畫參數")]
    public string parameterWalk = "開關走路";
    public string parameterAttack = "觸發攻擊";
    [Header("面向目標物件")]
    public Transform target;
    [Header("攻擊距離"), Range(0, 5)]
    public float attackDistance = 1.5f;
    [Header("攻擊冷卻時間"),Range(0,10)]
    public float attackCD = 3.5f;
    [Header("檢查攻擊區域大小與位移")]
    public Vector3 v3AttackSize = Vector3.one;
    public Vector3 v3AttackOffset;

    private float angle = 0;
    private Rigidbody2D rig;
    private Animator ani;
    private float timerAttack;
    #endregion

    #region 事件
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

    #region 方法
    private void CheckTargetInArea()
    {
        Collider2D hit = Physics2D.OverlapBox(transform.position + transform.
            TransformDirection(v3TrackOffset), v3TrackSize, 0, layerTarget);

        if (hit) Move();

    }

    private void Move()
    {
        //如果 目標的 X 小於 敵人的 X 就代表在左邊 角度0
        //如果 目標的 X 大於 敵人的 X 就代表在右邊 角度180
        if (target.position.x>transform.position.x)
        {
            //右邊angle = 180
        }
        else if (target.position.x<transform.position.x)
        {
            //左邊angle = 0
        }
        //三元運算子語法：布林值？當布林值為 true :當布林值 為
        angle = target.position.x > transform.position.x ? 180 : 0;

        transform.eulerAngles = Vector3.up * angle;

        rig.velocity = transform.TransformDirection(new Vector2(-speed, rig.velocity.y));
        ani.SetBool(parameterWalk, true);

        float distance = Vector3.Distance(target.position, transform.position);
        //print("與目標的距離：" + distance);

        if (distance <= attackDistance)
        {
            rig.velocity = Vector3.zero;
            Attack();
        }
    }

    [Header("攻擊力"), Range(0, 100)]
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
            print("攻擊到物件：" + hit.name);
            hit.GetComponent<HurtSystem>().Hurt(attack);
        }
    }
    #endregion
}
