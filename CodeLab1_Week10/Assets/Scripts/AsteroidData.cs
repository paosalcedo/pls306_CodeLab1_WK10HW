//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using SimpleJSON;
//public class AsteroidData {
//    public Vector3 position;
//    public Vector3 scale;
//    private const string POS_X = "xpos";
//    private const string POS_Y = "ypos";
//    private const string POS_Z = "zpos";
////    public AsteroidData(string fileName){
////
////        JSONNode jason = UtilScript.ReadJSONFromFile(Application.dataPath, fileName);
////        position = new Vector3(
////            jason[POS_X].AsFloat,
////            jason[POS_Y].AsFloat,
////            jason[POS_Z].AsFloat);
////     }
//
//	public AsteroidData (string fileName)
//	{
//		JSONNode jason = UtilScript.ReadJSONFromFile (Application.dataPath, fileName);
//		JSONArray a = jason.AsArray;
//		for (int i = 0; i < a.Count; i++) {
//			Debug.Log (a [i]);
//			a[i].ToString();
////			Debug.Log("xpos"[i]);
//		}
//		
//    }
//
//    public AsteroidData(Vector3 position, Vector3 scale){
//        this.position = position;
//        this.scale = scale;
//    }
//
//    public JSONNode ToJSON(){
//        JSONNode json = new JSONClass();
//        json[POS_X].AsFloat = position.x;
//        json[POS_Y].AsFloat = position.y;
//        json[POS_Z].AsFloat = position.z;
//        return json;
//    }
//
//    public void Save(string fileName, JSONNode json){
////      json = ToJSON();
//         UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
//    }
//}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;
public class AsteroidData {
    public Vector3 position;
    public Vector3 scale;

//Declare arrays for pos and scale which will take the JSONArray.
	public Vector3[] posArray;
	public Vector3[] scaleArray;

    private const string POS_X = "xpos";
    private const string POS_Y = "ypos";
    private const string POS_Z = "zpos";

	private const string SCALE_X = "xscale";
    private const string SCALE_Y = "yscale";
    private const string SCALE_Z = "zscale";

    public AsteroidData(string fileName){
       				
		JSONArray jason = UtilScript.ReadJSONFromFile(Application.dataPath, fileName) as JSONArray;
//        Debug.Log (jason);
		posArray = new Vector3[jason.Count];
		scaleArray = new Vector3[jason.Count];
        for (int i = 0; i < jason.Count; i++) {
 			
			posArray[i] = new Vector3 (	jason[i][POS_X].AsFloat, 
										jason[i][POS_Y].AsFloat, 
										jason[i][POS_Z].AsFloat);

			scaleArray[i] = new Vector3 (	jason[i][SCALE_X].AsFloat,
        									jason[i][SCALE_Y].AsFloat,
											jason[i][SCALE_Z].AsFloat);
		}	 

    }
    public AsteroidData(Vector3 position, Vector3 scale){
        this.position = position;
		this.scale = scale;
    }
    public JSONNode ToJSON(){
        JSONNode json = new JSONClass();
        json[POS_X].AsFloat = position.x;
        json[POS_Y].AsFloat = position.y;
        json[POS_Z].AsFloat = position.z;

        return json;
    }
    public void Save(string fileName, JSONNode json){
        Debug.Log (json);
        UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
    }
}