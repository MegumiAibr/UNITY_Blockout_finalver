using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    //GUIで数字を変更できるようにするため,publicを使う
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        //floatの場合は数字にfを追加する
        speed = 10.0f;
        GetComponent<Rigidbody>().AddForce((transform.right - transform.up) * speed, ForceMode.VelocityChange);
        /*
         GetComponent<Rigidbody> ();  // rigidbodyを取得
         AddForce (力を設定,徐々に加速するようになる設定（だと思う） );  // 力を加える
         */
    }

    // Update is called once per frame
    void Update()
    {
        /*位置フレームごとに加速を加えて、原則を防ぐ*/
        GetComponent<Rigidbody>().velocity =　GetComponent<Rigidbody>().velocity.normalized * speed;

    }
}
