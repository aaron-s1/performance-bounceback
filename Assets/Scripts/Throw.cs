// using UnityEngine;

// public class Throw : MonoBehaviour {			
//     	private SteamVR_TrackedObject trackedObj;
//     	private SteamVR_Controller.Device device;

//    	void Start() {
//         	trackedObj = GetComponent<SteamVR_TrackedObject>();
// 	}

    
//     	void Update() {
// 	        device = SteamVR_Controller.Input((int)trackedObj.index);
//     	}


// 	void OnTriggerStay(Collider col) {

// 		if (col.gameObject.CompareTag("Throwable")) {
// 			if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger)) {
                
//         	        	col.transform.SetParent(null);
//                 		Rigidbody rigidBody = col.GetComponent<Rigidbody>();
//                			rigidBody.isKinematic = false;
			
// 				rigidBody.velocity = device.velocity * -1f;			
//             			rigidBody.angularVelocity = device.angularVelocity;
// 	            	}

// 			else if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))  {

//                 		col.GetComponent<Rigidbody>().isKinematic = true;
//                 		col.transform.SetParent(gameObject.transform);
//                 		device.TriggerHapticPulse(2000);
//             		}
//         	}
//     	}

// }
