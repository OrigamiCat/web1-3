using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
        //Helo,Worldをコンソールウィンドウに表示する
        Debug.Log("Hello,world");
        
        //変数を使ってみる
        int age;
        age = 30;
        Debug.Log(age);

        //変数に変数を代入
        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        //文字列の取り扱い
        string name;
        name = "kitamura";
        Debug.Log(name);

        //計算
        int answer;
        answer = 1 + 2;
        Debug.Log(answer);

        //その他の四則演算
        answer = 3 - 4;
        Debug.Log(answer);

        answer = 5 * 6;
        Debug.Log(answer);

        answer = 8 / 4;
        Debug.Log(answer);

        //変数同士の演算子
        int n1 = 8,
            n2 = 9;
        answer = n1 + n2;
        Debug.Log(answer);

        //ちょっと便利な書き方⑴
        answer = 10;
        answer += 5;
        Debug.Log(answer);

        //ちょっと便利な書き方⑵
        answer ++;
        Debug.Log(answer);

        //文字列同士の連結
        string str1 = "happy";
        string str2 = "birthday";
        string message;

        message = str1 + str2;
        Debug.Log(message);

        //文字列と数値の連結
        string str = "happy";
        int num = 123;
        message = str + num;
        Debug.Log(message);

        //if-else文での条件分岐
        int hp = 200;
        if (hp >= 100){
            Debug.Log("攻撃！");
        }
        else
        {
            Debug.Log("防御！");
        }

        //if文を追加する
        if (hp >= 100)
        {
            Debug.Log("逃走！");
        }
        else if(hp>=200)
        {
            Debug.Log("攻撃！");
        }
        else
        {
            Debug.Log("防御！");
        }

        //変数のスコープ
        int x = 1;
        if (x == 1)
        {
            int y = 2;
            Debug.Log(x);
            Debug.Log(y);
        }
       //Debug.Log(y);

        //for文で繰り返し
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(i);
        }

        //偶数（2の倍数）だけを表示してみる
        for(int i = 0; i < 10; i += 2)
        {
            Debug.Log(i);
        }

        //特定の範囲だけを表示
        for(int i = 3; i < 5; i++)
        {
            Debug.Log(i);
        }

        //カウントダウンしてみる
        for (int i = 3;i>=0; i--)
        {
            Debug.Log(i);
        }

        //数の合計を求める
        int sum = 0;
        for (int i = 1; i <= 10; i++)
        {
            sum += i;
        }
            Debug.Log(sum);





    }
	
	// Update is called once per frame
	void Update () {

	}
}
