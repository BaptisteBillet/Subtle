using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public partial class GameSystem : MonoBehaviour {

    #region ThemeDistribution

    public GameObject m_PlayerGOPrefab;
    GameObject m_PlayerGOInstance;
    Player m_Player;

    public List<Player> m_ListOfPlayers = new List<Player>();

    public 

    //Create a Player file for each player.
    public void ThemeDistributionInstantiatePlayers()
    {
        m_ListOfPlayers.Clear();

        for(int i=0;i<m_NumberOfPlayers;i++)
        {
            m_PlayerGOInstance = Instantiate(m_PlayerGOPrefab);
            m_PlayerGOInstance.GetComponent<Player>().id = "Player " + (i+1);
            m_PlayerGOInstance.GetComponent<Player>().theme = "";
            m_PlayerGOInstance.GetComponent<Player>().spy = false;
            m_ListOfPlayers.Add(m_PlayerGOInstance.GetComponent<Player>());
        }

        //Start the choice of the spy player
        ThemeDistributionSpyChoice();

    }

    private void ThemeDistributionSpyChoice()
    {
        m_ListOfPlayers[Random.Range(0,m_NumberOfPlayers)].GetComponent<Player>().spy = true;
        
        //Start to wait for the player one.
        ThemeDistributionWaitForAPlayer();
    }

    private void ThemeDistributionThemesChoice()
    {
        m_ListOfPlayers[Random.Range(0, m_NumberOfPlayers)].GetComponent<Player>().spy = true;

        //Start to wait for the player one.
        ThemeDistributionWaitForAPlayer();
    }

    //Wait a particular player in order to tell him his theme
    public void ThemeDistributionWaitForAPlayer()
    {
        m_UIManager.ChangePanel(e_UIPanel.PANELWAITFORPLAYERDISTRIBUTION);

    }

    //Tell the theme to the player and check if he is the last player.
    //If yes, stop this step, launch the next one.
    //If not, start to wait for the next player
    public void ThemeDistributionDeliverTheme()
    {

    }

    #endregion


}
