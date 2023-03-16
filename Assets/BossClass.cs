using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53; //int型の変数mpを宣言し、53で初期化

    //magic用の関数
    public void Magic(int c)
    {
        if(this.mp >= c)
        {
            //mpが5以上の場合

            this.mp -= c;

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

        //magic関数を11回行う
        for (int i = 0; i < 11; i ++)
        {
            
            //magic関数を呼び出す
            lastboss.Magic(10);
        }

       
    }

    // Update is called once per frame
    void Update()
    {

    }
}