using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    float accel = 700.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().AddForce(transform.right *Input.GetAxisRaw("Horizontal") * accel,ForceMode.Acceleration);
        /*　
         *説明
            Horizontal:水平方向の移動量  Vertical:垂直方向の移動量
            AddForce (力を設定,ForceMode.Acceleration:その質量を無視して、リジッドボディへ継続的な加速を追加);  // 力を加える
         */

    }
}
