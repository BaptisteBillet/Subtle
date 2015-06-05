using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

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

		//All variables
		[Header("Variables")]
		public int m_NumberOfPlayers;
		public int m_MinNumberOfPlayers;
		public int m_MaxNumberOfPlayers;
		public int m_NumberOfActualPlayer;
		[Header(" ")]
		public int m_NumberOfRound;
		public int m_ActualRoundNumber;
		[Header(" ")]
		public int m_SpyPlayer;
		public bool m_IsOkForChange;	


		[Header(" ")]

		#region PanelSettings
		public GameObject m_PanelSettings;

		public Text m_TextNumberOfPlayers;

		public Button m_ButtonMaximus;
		public Button m_ButtonMinus;
		#endregion
		[Header(" ")]
		#region PanelAttribution
		public GameObject m_PanelAttribution;
		public Text m_TextPlayerAttribution;
		public Text m_TextClue;
		#endregion
		[Header(" ")]
		#region PanelWaitFor
		public GameObject m_PanelWaitFor;
		public Text m_TextPlayerWaitFor;
		#endregion





		[Header(" ")]

		#region GameSettings
		public GameObject m_PanelGame;
		
		

		#endregion




	#endregion

	#region Themes
	List<Theme> themes;
	#endregion

		// Use this for initialization
	void Start () {
		m_NumberOfPlayers=m_MinNumberOfPlayers;
		m_TextNumberOfPlayers.text = m_NumberOfPlayers.ToString();
		m_PanelSettings.SetActive(true);
		m_PanelGame.SetActive(false);
		m_PanelWaitFor.SetActive(false);
		m_PanelAttribution.SetActive(false);

		themes = new List<Theme>();
		#region Themes
		themes.Add(new Theme());
		themes[themes.Count - 1].SetName("Poulet");
		themes[themes.Count - 1].AddTag(Hashtag.ANIMAL);

		themes.Add(new Theme());
		themes[themes.Count - 1].SetName("Chat");
		themes[themes.Count - 1].AddTag(Hashtag.ANIMAL);

		themes.Add(new Theme());
		themes[themes.Count - 1].SetName("Canard");
		themes[themes.Count - 1].AddTag(Hashtag.ANIMAL);

		themes.Add(new Theme());
		themes[themes.Count - 1].SetName("Pelle");
		themes[themes.Count - 1].AddTag(Hashtag.OBJET);
		#endregion
	}

	public void ChangeNumbersOfPlayer(bool IsAddingPlayer)
	{
		if (IsAddingPlayer && m_NumberOfPlayers < m_MaxNumberOfPlayers)
		{
			m_NumberOfPlayers++;
		}
		if (!IsAddingPlayer && m_NumberOfPlayers > m_MinNumberOfPlayers)
		{
			m_NumberOfPlayers--;
		}
	
		m_TextNumberOfPlayers.text = m_NumberOfPlayers.ToString();
		//Interectable
		if (m_NumberOfPlayers >= m_MaxNumberOfPlayers)
		{
			m_ButtonMaximus.enabled = false;
		}
		else
		{
			m_ButtonMaximus.enabled = true;
		}
		if (m_NumberOfPlayers <= m_MinNumberOfPlayers)
		{
			m_ButtonMinus.enabled = false;
		}
		else
		{
			m_ButtonMinus.enabled = true;
		}
		//
	}

	public void StartTheAttribution()
	{
		m_PanelSettings.SetActive(false);

		//On décide du joueur espion aléatoirement
		m_SpyPlayer = Random.Range(1, m_NumberOfPlayers + 1); //+1 car exclusive
		m_IsOkForChange = false;
		PushNextButton();
	}

	public void PushNextButton()
	{
		if(m_IsOkForChange==true)
		{
				m_PanelWaitFor.SetActive(false);
				m_PanelAttribution.SetActive(true);
				m_TextPlayerAttribution.text = "Player " + m_NumberOfActualPlayer.ToString();
				m_NumberOfActualPlayer++;
				if (m_NumberOfActualPlayer == m_SpyPlayer)
				{
					m_TextClue.text = themes[Random.Range(0, themes.Count)].GetName();
					//m_TextClue.text = "SPY";

				}
				else
				{
					m_TextClue.text = themes[Random.Range(0, themes.Count)].GetName();
					//m_TextClue.text = "COUNTERSPY";
				}
				
		}
		else
		{
			if (m_NumberOfActualPlayer < m_NumberOfPlayers+1)
			{
				m_PanelAttribution.SetActive(false);
				m_PanelWaitFor.SetActive(true);
				m_TextPlayerWaitFor.text = "Player " + m_NumberOfActualPlayer.ToString();
				//Si c'est l'espion
				
			}
			else
			{
				m_PanelWaitFor.SetActive(false);
				m_PanelAttribution.SetActive(false);
			}
		}
		m_IsOkForChange = !m_IsOkForChange;
	}

	
}
