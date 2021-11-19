
using UnityEngine;

/// <summary>
/// 控制器：2D 橫向卷軸 角色移動
/// </summary>

public class MovingController : MonoBehaviour
{
    #region 欄位：公開
    [Header("移動速度"), Range(0, 500 )]
    public float speed = 3.5f;

    [Header("跳躍高度"), Range(0, 1500)]
    public float jump = 10f;
    #endregion

    /// <summary>
    /// 剛體元件
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

    #region 方法
    /// <summary>
    /// 1.玩家是否有移動按鍵  左右方向鍵 or A、D
    /// 2.物件移動行為(API)
    /// </summary>
    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        print("玩家左右按鍵值：" + h);
    }

    #endregion
}
