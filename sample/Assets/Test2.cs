using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour {

    void SayHello()
    {
        Debug.Log("Hello");
    }
    void CallName(string name)
    {
        Debug.Log("Hello" + name);
    }
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    public class player
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


    // Use this for initialization
    void Start () {

        //配列の使い方
        int[] array = new int[5];

        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i=0;i<5;i++)
        {
            Debug.Log(array[i]);
        }

        //簡単な初期化の方法
        int[] points =
        {
            83,
            99,
            52,
            93,
            15
        };

        for (int i=0;i<points.Length;i++)
        {
            if (points[i]>=90)
            {
                Debug.Log(points[i]);
            }
        }

        //引数も返り値もないメソッド

        SayHello();

        //引数のあるメソッド

        CallName("Tom");

        //引数と返り値のあるメソッド
        int answer;
        answer = Add(2, 3);
        Debug.Log(answer);

        //クラスの作成
        player myplayer = new player();
        myplayer.Attack();
        myplayer.Damage(30);

        //Vectorクラスの使い方
        Vector2 playerPos = new Vector2(3.0f,4.0f);
        playerPos.x += 8.0f;
        playerPos.y += 5.0f;
        Debug.Log(playerPos);

        //ベクトルの減算
        Vector2 startPos = new Vector2(2.0f, 1.0f);
        Vector2 endpos = new Vector2(8.0f,5.0f);
        Vector2 dir = endpos - startPos;

        float len = dir.magnitude;
        Debug.Log(len);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
