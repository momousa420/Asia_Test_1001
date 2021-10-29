
using UnityEngine;

/// <summary>
/// 學習運算子
/// 1.指定 =
/// 2.數學 + - * / %
/// 3.比較
/// 4.邏輯
/// </summary>
public class LearnOperator : MonoBehaviour
{
    //指定運算子特性：
    //※指定運算子會先運行右邊再指定給左邊
    public int number = 10;     //指定：將數字10指定給欄位number

    public float numberA = 20;
    public float numberB = 3;

    private void Start()
    {
        print("加法" + (numberA + numberB));
        print("減法" + (numberA - numberB));
        print("乘法" + (numberA * numberB));
        print("除法" + (numberA / numberB));
        print("餘數" + (numberA % numberB));

    }
}
