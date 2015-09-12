using UnityEngine;
using System.Collections;
using System; // for TimeSpan

/*
 * v0.1 2015/09/12
 *   - get days from sunday
 */

public class MyScript : MonoBehaviour {

	System.DateTime getSundayH00M00S00(System.DateTime dt) {
		System.DateTime res = dt;
		dt -= new TimeSpan ((int)dt.DayOfWeek, dt.Hour, dt.Minute, dt.Second);
		return dt;
	}

	void Test_weekly() {
		System.DateTime now = System.DateTime.Now;
		System.DateTime sunday = getSundayH00M00S00 (now);

		int daysdiff = now.Subtract (sunday).Days;

		Debug.Log ("now: " + now.ToString ());
		Debug.Log ("sunday: " + sunday.ToString ());
		Debug.Log ("days: " + daysdiff);
	}

	void Start () {
		Test_weekly ();
	}
	
}
