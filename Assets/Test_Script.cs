using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp = 100;
    private int power = 50;
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "のダメージを受けた");
    }
}

public class Test_Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log("Hellow World");
        // int age = 30;
        // Debug.Log(age);
        // int[] point = new int[5];
        // for (int i = 0;i<point.Length ; i++)
        // {
        //     point[i] = i;
        // }
        // for (int i = 0;i<point.Length ; i++)
        // {
        //     Debug.Log(point[i]);
        // }

        // Player a = new Player();
        // Player b = new Player();
        // a.Attack();
        // a.Damage(10);
        // b.Damage(30);
        // b.Attack();
        // b.Damage(40);

        Vector2 playerPos = new Vector2(3.0f,4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        Vector2 playerPos1 = new Vector2(3.0f,4.0f);
        Vector2 playerPos2 = new Vector2(8.0f,9.0f);
        Vector2 diff = playerPos2 - playerPos1;
        Debug.Log(diff);

        float len = diff.magnitude;
        Debug.Log(len);
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
