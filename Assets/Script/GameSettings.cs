using UnityEngine;
using System.Collections;

public class GameSettings : MonoBehaviour {

	#region Singleton
	static private GameSettings s_Instance;
	static public GameSettings instance
	{
		get
		{
			return s_Instance;
		}
	}



	void Awake()
	{
		if (s_Instance == null)
			s_Instance = this;
		//DontDestroyOnLoad(this);
	}
	#endregion

	#region members
	public int m_NumberOfPlayers;
	public int m_MaxNumberOfPlayers;
	public int m_MinNumberOfPlayers;


	#endregion


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
