using UnityEngine;
using System.Collections;

public class WaterControl : MonoBehaviour
{

		public Light light;
		private bool watCon = true;
		public GlobalFog fog;
		public DepthOfFieldScatter dfs;
		void Start ()
		{
		}

		void OnTriggerEnter (Collider oth)
		{
				if (oth.tag == "Water") {
						if (watCon) {
								fog.enabled = false;	
								watCon = false;
								light.enabled = false;
				dfs.enabled=false;
						} else
		if (!watCon) {
								fog.enabled = true;
								watCon = true;
								light.enabled = true;
				dfs.enabled=true;
						}
				}
		}

		void OnTriggerExit (Collider oth)
		{
				if (oth.tag == "Water")
				if (oth.transform.position.y >= this.transform.position.y) {
						watCon = true;
						fog.enabled = true;
				} else {
						watCon = false;
						fog.enabled = false;
				}
					
		}
}
