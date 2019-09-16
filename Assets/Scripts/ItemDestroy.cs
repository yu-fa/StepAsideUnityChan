using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroy : MonoBehaviour {

    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //UnityちゃんとItemの距離
    private float itemDistance;

    // Use this for initialization
    void Start () {

        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

    }
	
	// Update is called once per frame
	void Update () {

        // Itemとunitychanの距離を計算
        this.itemDistance = unitychan.transform.position.z - this.transform.position.z;

        if (this.itemDistance > 10 && tag == "CarTag")
        {
            Destroy(this.gameObject);
        }

        else if (this.itemDistance > 10 && tag == "CoinTag")
        {
            Destroy(this.gameObject);
        }

        else if (this.itemDistance > 10 && tag == "TrafficConeTag")
        {
            Destroy(this.gameObject);
        }
    }
}
