using UnityEngine;

public class NPC : MonoBehaviour
{
    [Header("��ܸ��")]
    public DataDialogue dataDialogue;
    [Header("��ܨt��")]
    public DialogueSystem dialogueSystem;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("�K!");
    }

}
