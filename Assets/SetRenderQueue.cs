using UnityEngine;

[AddComponentMenu("Rendering/SetRenderQueue")]

public class SetRenderQueue : MonoBehaviour
{

	[SerializeField]
	protected int[] m_queues = new int[] { 3000 };

	protected void Start()
	{
		var renderers = GetComponentsInChildren<MeshRenderer>();
		foreach( var r in renderers)
		{
			Material[] materials = r.materials;
			for (int i = 0; i < materials.Length && i < m_queues.Length; ++i)
			{
				materials[i].renderQueue = m_queues[i];
			}

		}
	}
}
