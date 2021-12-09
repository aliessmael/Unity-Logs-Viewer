using UnityEngine;
using System.Collections;

namespace Unity_Logs_Viewer.Reporter
{
	public class ReporterGUI : MonoBehaviour
	{
		Reporter reporter;
		void Awake()
		{
			reporter = gameObject.GetComponent<Reporter>();
		}

		void OnGUI()
		{
			reporter.OnGUIDraw();
		}
	}
}
