using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSelect : MonoBehaviour {

	// Use this for initialization
	//void Start () {
		
//	}
	
	// Update is called once per frame

	void Update () {
		
	}
    public int assetNum = 0;
    //public string assetName;
       IEnumerator Start()
    {
        string url = "http://ec2-18-232-184-23.compute-1.amazonaws.com/assetbundles/asset_bundle_1";
        WWW www = new WWW(url);
        while (!www.isDone)
        {
            
            if(www.assetBundle!=null)
            {
                AssetBundle bundle = www.assetBundle;
                string[] assetList = bundle.GetAllAssetNames();
                GameObject asset = bundle.LoadAsset(assetList[assetNum]) as GameObject;
                Instantiate(asset);
            }        }
        yield return www;
    }
   /* public void load1()
    {
        string url = "http://ec2-18-232-184-23.compute-1.amazonaws.com/assetbundles/asset_bundle_1";
        WWW www = new WWW(url);
        while (www.isDone)
        {

            if (www.assetBundle != null)
            {
                AssetBundle bundle = www.assetBundle;
                string[] assetList = bundle.GetAllAssetNames();
                GameObject asset = bundle.LoadAsset(assetList[1]) as GameObject;
                Instantiate(asset);
            }
        }
        yield return www;*/
     
}
