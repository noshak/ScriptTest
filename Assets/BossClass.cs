using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; //int型の変数mpを宣言し、53で初期化

    //magic用の関数
    public void magic()
    {
        this.mp -= 5;

        if(this.mp > 0)
        {
            //mpが0より大きい場合
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
        }

        else
        {
            //そうでない場合
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
    }
}

public class BossClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Bossクラスの変数を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        //magic関数を10回行う
        for (int i =53; i > 0; i -= 5)
        {
            
            //magic関数を呼び出す
            lastboss.magic();
        }

       
    }

    // Update is called once per frame
    void Update()
    {

    }
}