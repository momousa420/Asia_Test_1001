
using UnityEngine;

/// <summary>
/// 控制器：2D 橫向卷軸 角色移動
/// </summary>

public class MovingController : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 500)]
    public float speed = 3.5f;

    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 10f;

    [Header("檢查地板尺寸與位移")]
    [Range(0, 1)]
    public float checkGroundRadius = 0.1f;
    public Vector3 checkGroundOffset;
    [Header("跳躍按鍵與可跳躍圖層")]
    public KeyCode keyJump = KeyCode.UpArrow;
    public LayerMask canJumpLayer;
    #endregion

    /// <summary>
    /// 剛體元件
    /// </summary>
    private Rigidbody2D rig;

    /// <summary>
    /// 繪製圖示
    /// 在Unity繪製輔助用的圖示
    /// 線條、射線、圓形、方形、扇形
    /// </summary>
    private void OnDrawGizmos()
    {
        //1.決定圖示顏色
        Gizmos.color = new Color(2, 0, 0.2f, 0.3f);
        //2.決定繪製圖形
        Gizmos.DrawSphere(transform.position + 
            transform.TransformDirection(checkGroundOffset), checkGroundRadius);
    }

    private void Start()
    {
       rig = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Update約 60 FPS 固定更新事件：50 FPS 處理物理行為
    /// </summary>
    private void FixedUpdate()
    {
        //剛體欄位 = 取得元件<2D 剛體>
        Move();
    }

    private void Update()
    {
        Flip();
    }
    #region 方法
    /// <summary>
    /// 1.玩家是否有移動按鍵  左右方向鍵 or A、D
    /// 2.物件移動行為(API)
    /// </summary>
    private void Move()
    {
        //h 值 指定為 輸入.取得軸向(水平軸) - 水平軸代表左右鍵與 AD
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值：" + h);

        //剛體元件.加速度 = 新二維向量(h 值 * 移動速度, 剛體.加速度.垂直)
        rig.velocity = new Vector2(h * speed, rig.velocity.y);
    }

    /// <summary>
    /// 翻面：
    /// 左：角度 Y 180
    /// 右：角度 Y 0
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
    #endregion
}
