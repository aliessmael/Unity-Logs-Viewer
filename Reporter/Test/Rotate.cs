using UnityEngine;
using System.Collections;

namespace Unity_Logs_Viewer.Reporter.Test
{
	public class Rotate : MonoBehaviour
	{
		Vector3 angle;

		void Start()
		{
			angle = transform.eulerAngles;
		}

		void Update()
		{
			angle.y += Time.deltaTime * 100;
			transform.eulerAngles = angle;
		}

	}
}
