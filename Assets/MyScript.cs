using UnityEngine;
using System.Collections;
using System; // for TimeSpan

/*
 * v0.2 2015/09/12
 *   - add getDayHourMinFractionOfWeek()
 * v0.1 2015/09/12
 *   - get days from sunday
 */

public class MyScript : MonoBehaviour {

	System.DateTime getSundayH00M00S00(System.DateTime dt) {
		System.DateTime res = dt;
		dt -= new TimeSpan ((int)dt.DayOfWeek, dt.Hour, dt.Minute, dt.Second);
		return dt;
	}

	float getDayHourMinFractionOfWeek(System.DateTime dt) {
		System.DateTime sunday = getSundayH00M00S00 (dt);
		
		int daysdiff = dt.Subtract (sunday).Days;
		
		int hourMin_min = dt.Hour * 60 + dt.Minute;
		float hourMinFraction = (float)hourMin_min / (24f * 60f); // 24 hours x 60 minutes
		float ddhhmmFraction = (float)daysdiff + hourMinFraction;

		Debug.Log ("target: " + dt.ToString ());
		Debug.Log ("sunday: " + sunday.ToString ());
		Debug.Log ("days: " + daysdiff);
		Debug.Log ("ddhhmmFraction: " + ddhhmmFraction);

		return ddhhmmFraction / 7.0f; // 7 days a week
	}


	void Test_weekly() {
		float daysFraction;
		daysFraction= getDayHourMinFractionOfWeek (System.DateTime.Now);
		Debug.Log (daysFraction.ToString ("0.000"));
	}

	void Start () {
		Test_weekly ();
	}
	
}
