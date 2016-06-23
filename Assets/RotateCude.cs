using UnityEngine;
using System.Collections;

public class RotateCude : MonoBehaviour {

	[SerializeField] private Rigidbody m_Rigidbody;
	public float m_Tourqe;

	public void RotateCube (){
		m_Rigidbody.AddTorque (Vector3.right * m_Tourqe);
		m_Rigidbody.AddTorque (Vector3.up * m_Tourqe);
	}
}