using UnityEngine;
using System.Collections;

namespace LogsViewer
{
	public class ReporterGUI : MonoBehaviour
	{

		Reporter reporter;

		void Awake ()
		{
			reporter = gameObject.GetComponent<Reporter> ();
		}

		void OnGUI ()
		{
			reporter.OnGUIDraw ();
		}
	}
}