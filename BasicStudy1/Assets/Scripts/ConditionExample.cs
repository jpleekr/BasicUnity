using UnityEngine;

public class ConditionExample : MonoBehaviour
{
    public int health = 100;

    void Update()
    {
        health -= 1;
        Debug.Log("Health : " + health);

        if(health <= 0)
        {
            Debug.Log("Gmae Over");
        }
    }
}
