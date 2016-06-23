using UnityEngine;
using System.Collections;

public class ChangeImage : MonoBehaviour {

	[SerializeField] private Renderer m_Renderer;
	private WWW req;
	private bool getNewImage = false;

	void Update (){
		if (getNewImage) {
			Debug.Log (getNewImage);
			if (req.error == null && req.isDone) {
				Debug.Log ("Set Mat");
				var tex = new Texture2D (400, 200);
				tex.LoadImage (req.bytes);
				m_Renderer.material.mainTexture = tex;
				getNewImage = false;
			}
		}
	}

	public void StareAtImage (){
		Debug.Log (getNewImage);
		req = new WWW ("https://unsplash.it/400/200?random");
		getNewImage = true;
	}
}
