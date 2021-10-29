
using UnityEngine;

/// <summary>
/// 學習運算子
/// 1.指定 =
/// 2.數學 + - * /  餘數:%  遞增:++  遞減:--
/// 3.比較
/// 4.邏輯
/// </summary>
public class LearnOperator : MonoBehaviour
{
    #region 指定運算子
    //指定運算子特性：
    //※指定運算子會先運行右邊再指定給左邊
    public int number = 10;     //指定：將數字10指定給欄位number

    public float numberA = 20;
    public float numberB = 3;
    public int numberC = 30;
    #endregion

    #region  數學運算子
    private void Start()
    {
        print("加法" + (numberA + numberB));
        print("減法" + (numberA - numberB));
        print("乘法" + (numberA * numberB));
        print("除法" + (numberA / numberB));
        print("餘數" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC減1：" + numberC);
        numberC--;                           //遞減
        print("numberC減1：" + numberC);

    }
    #endregion
}
