using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float moveSpeed = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * Vector2.right);
    }
}
