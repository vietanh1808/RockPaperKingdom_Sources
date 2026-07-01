using UnityEngine;

public class Hovl_Laser2 : MonoBehaviour
{
	private static readonly int Dissolve;

	private static readonly int Distance;

	private static readonly int EndPoint;

	private static readonly int StartPoint;

	private static readonly int Scale;

	public float laserScale;

	public Color laserColor;

	public GameObject HitEffect;

	public GameObject FlashEffect;

	public float HitOffset;

	public Vector3 HitPoint;

	private bool UpdateSaver;

	private ParticleSystem laserPS;

	private ParticleSystem[] Flash;

	private ParticleSystem[] Hit;

	private Material laserMat;

	private int particleCount;

	private ParticleSystem.Particle[] particles;

	private Vector3[] particlesPositions;

	private float dissovleTimer;

	private bool startDissovle;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void AddParticles()
	{
	}

	public void DisablePrepare()
	{
	}
}
