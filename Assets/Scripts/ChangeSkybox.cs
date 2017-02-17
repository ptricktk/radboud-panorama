using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeSkybox : MonoBehaviour {

	public Material[] volgendeBox;
	public int TimeForScene;

	private int i = 0;
	private float timeToSwitch = 1;

	public Toggle cbxForAutoAdvance;

	// Use this for initialization
	void Start () {

		timeToSwitch = TimeForScene;
		StartSwitcher ();
	}

	void StartSwitcher() {
		Invoke ("ChangeTheBox", timeToSwitch);
	}

	void ChangeTheBox () {

		if (cbxForAutoAdvance.isOn) {
			AdvanceLocation ();
		}

	}

	public void NextLocation() {

		AdvanceLocation ();

	}

	public void ChangeVRmode() {

		GvrViewer.Instance.VRModeEnabled = !GvrViewer.Instance.VRModeEnabled;

	}


	private void AdvanceLocation() {
		RenderSettings.skybox = volgendeBox [i];
		i++;

		if (i < volgendeBox.Length) {
			StartSwitcher ();
		} else {
			i = 0;
			StartSwitcher ();
		}
	}
}
