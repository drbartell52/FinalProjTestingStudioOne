using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MartianMovement : MonoBehaviour
{
    // Speed at which the object moves
    public float moveSpeed = 0.1f;

    void Start()
    {
        // Start the movement coroutine
        StartCoroutine(MoveRandomDirection());
    }

    IEnumerator MoveRandomDirection()
    {
        while (true)
        {
            // Generate a random direction
            Vector2 randomDirection = Random.insideUnitCircle.normalized;

            // Move in the random direction by one unit
            Vector3 targetPosition = transform.position + new Vector3(randomDirection.x/5, 0, randomDirection.y/5);
            yield return MoveToPosition(targetPosition);

            // Wait for a moment before picking a new random direction
            yield return new WaitForSeconds(5f);
        }
    }

    IEnumerator MoveToPosition(Vector3 targetPosition)
    {
        // Move towards the target position
        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }
}
