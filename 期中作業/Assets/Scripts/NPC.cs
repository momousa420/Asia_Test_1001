using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("對話資料")]
    public DataDialogue dataDialogue;
    [Header("對話系統")]
    public DialogueSystem dialogueSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("嘿!");
    }

}
