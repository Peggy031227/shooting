using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
 //宣告子彈物件

         public GameObject Bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
  if (Input.GetKey(KeyCode.RightArrow))

        {

            //帶有這個程式碼的物件(飛船)會向右改變座標

            this.transform.position += new Vector3(0.1f, 0, 0);

        }

        //如果玩家按下左鍵

        if (Input.GetKey(KeyCode.LeftArrow))

        {

            //帶有這個程式碼的物件(飛船)會向左改變座標

            this.transform.position += new Vector3(-0.1f, 0, 0);

        }
       //如果玩家按下空白鍵

         if (Input.GetKeyDown(KeyCode.Space))

         {

            //在(0,3,0)的位置生成Bullet物件，而Bullet物件指向子彈物件

            Instantiate(Bullet, this.transform.position, Quaternion.identity);

         }  
    }
}
