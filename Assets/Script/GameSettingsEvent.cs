using UnityEngine;
using System.Collections;

/*
 * Comment émettre un event:
		SoundManagerEvent.emit(SoundManagerType.ENEMY_HIT);
 * 
 * Comment traiter un event (dans un start ou un initialisation)
		EventManagerScript.onEvent += (EventManagerType emt, GameObject go) => {
			if (emt == EventManagerType.ENEMY_HIT)
			{
				//SpawnFXAt(go.transform.position);
			}
		};
 * ou:
		void maCallback(EventManagerType emt, GameObject go) => {
			if (emt == EventManagerType.ENEMY_HIT)
			{
				//SpawnFXAt(go.transform.position);
			}
		};
		EventManagerScript.onEvent += maCallback;
 * 
 * qui permet de:
		EventManagerScript.onEvent -= maCallback; //Retire l'appel
 */


public enum GameSettingsType
{
	MORE,
	LESS
}

public class GameSettingsEvent : MonoBehaviour
{

	public delegate void EventAction(GameSettingsType emt);
	public static event EventAction onEvent;

	#region Singleton
	static private GameSettingsEvent s_Instance;
	static public GameSettingsEvent instance
	{
		get
		{
			return s_Instance;
		}
	}
	#endregion


	void Awake()
	{
		if (s_Instance == null)
			s_Instance = this;
		//DontDestroyOnLoad(this);
	}

	void Start()
	{
		GameSettingsEvent.onEvent += (GameSettingsType emt) => { Debug.Log("&"); };
	}

	public static void emit(GameSettingsType emt)
	{

		if (onEvent != null)
		{
			onEvent(emt);
		}
	}



}

