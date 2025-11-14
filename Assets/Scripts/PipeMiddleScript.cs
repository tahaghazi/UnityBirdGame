using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    private LogicScript logic;

    void Start()
    {
        GameObject logicObject = GameObject.FindGameObjectWithTag("Logic");
        Debug.Log("Looking for Logic object...");

        if (logicObject != null)
        {
            logic = logicObject.GetComponent<LogicScript>();
            Debug.Log("Logic script found!");
        }
        else
        {
            Debug.LogError("Logic object not found! Please ensure your Logic GameObject is tagged as 'Logic'.");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"Trigger detected with: {collision.gameObject.name}");

        if (collision.CompareTag("Player") && logic != null)
        {
            logic.addScore(1);
            Debug.Log("Score added!");
        }
    }
}
