using UnityEngine;
using System.Collections;
using System; // for TimeSpan

public class MyScript : MonoBehaviour {

	System.DateTime getSundayH00M00S00(System.DateTime dt) {
		System.DateTime res = dt;
		dt -= new TimeSpan ((int)dt.DayOfWeek, dt.Hour, dt.Minute, dt.Second);
		return dt;
	}

	void Test_weekly() {
		Debug.Log ("test weekly");

		System.DateTime now = System.DateTime.Now;
		System.DateTime sunday = getSundayH00M00S00 (now);

		Debug.Log (now.ToString ());
		Debug.Log (sunday.ToString ());
	}

	void Start () {
		Test_weekly ();
	}
	
}
