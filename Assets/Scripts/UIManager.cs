using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum e_UIPanel
{
    PANELNUMBEROFPLAYER,
    PANELWAITFORPLAYERDISTRIBUTION,
    PANELTHEMEDISTRIBUTION,
    PANELWAITFORPLAYERDECLARATION,
    PANELWAITFORPLAYERVOTE,
    PANELVOTE,
    PANELWINNER
}




public class UIManager : MonoBehaviour {

    [HideInInspector]
    public GameSystem m_GameSystem;


    [Header("Panels")]
    #region Panels
    public GameObject m_PanelNumberOfPlayer;
    public GameObject m_PanelWaitForPlayerDistribution;
    public GameObject m_PanelThemeDistribution;
    public GameObject m_PanelWaitForPlayerDeclaration;
    public GameObject m_PanelWaitForPlayerVote;
    public GameObject m_PanelVote;
    public GameObject m_PanelWinner;
    #endregion
    [Header("PanelNumberOfPlayer")]
    #region PanelNumberOfPlayer
    public Text m_TextNumberOfPlayer;
    public GameObject m_ButtonSub;
    public GameObject m_ButtonAdd;
    #endregion
    [Header("PanelWaitForPlayerDistribution")]
    #region PanelWaitForPlayerDistribution
    public Text m_TextPlayerDistributionID;
    #endregion
    [Header("PanelThemeDistribution")]
    #region PanelThemeDistribution
    public Text m_TextPlayerThemeID;
    public Text m_TextTheme;
    #endregion
    [Header("PanelWaitForPlayerDeclaration")]
    #region PanelWaitForPlayerDeclaration
    public Text m_TextPlayerDeclarationID;
    #endregion
    [Header("PanelWaitForPlayerVote")]
    #region PanelWaitForPlayerVote
    public Text m_TextPlayerWaitVoteID;
    #endregion

    [Header("PanelVote")]
    #region PanelVote
    public Text m_TextPlayerVoteID;
    #endregion

    #region PanelWinner

    #endregion


    // Use this for initialization
    void Start () {

        //Desactive all others
        m_PanelWaitForPlayerDistribution.SetActive(false);
        m_PanelThemeDistribution.SetActive(false);
        m_PanelWaitForPlayerDeclaration.SetActive(false);
        m_PanelWaitForPlayerVote.SetActive(false);
        m_PanelVote.SetActive(false);
        m_PanelWinner.SetActive(false);

        //Active the Number of player panel
        m_PanelNumberOfPlayer.SetActive(true);


    }

    public void ChangePanel(e_UIPanel panel)
    {
        m_PanelWaitForPlayerDistribution.SetActive(false);
        m_PanelThemeDistribution.SetActive(false);
        m_PanelWaitForPlayerDeclaration.SetActive(false);
        m_PanelWaitForPlayerVote.SetActive(false);
        m_PanelVote.SetActive(false);
        m_PanelWinner.SetActive(false);
        m_PanelNumberOfPlayer.SetActive(false);
    
        switch(panel)
        {
            case e_UIPanel.PANELNUMBEROFPLAYER:
                m_PanelWaitForPlayerDistribution.SetActive(true);
                break;

            case e_UIPanel.PANELWAITFORPLAYERDISTRIBUTION:
                m_PanelWaitForPlayerDistribution.SetActive(true);
                break;

            case e_UIPanel.PANELTHEMEDISTRIBUTION:
                m_PanelThemeDistribution.SetActive(true);
                break;

            case e_UIPanel.PANELWAITFORPLAYERDECLARATION:
                m_PanelWaitForPlayerVote.SetActive(true);
                break;

            case e_UIPanel.PANELWAITFORPLAYERVOTE:
                m_PanelWinner.SetActive(true);
                break;

            case e_UIPanel.PANELVOTE:
                m_PanelWaitForPlayerDeclaration.SetActive(true);
                break;

            case e_UIPanel.PANELWINNER:
                m_PanelNumberOfPlayer.SetActive(true);
                break;
        }

    }



    #region NumberOfPlayer
    public void UINumberOfPlayerChangeNumberOfPlayer(int number)
    {
        m_TextNumberOfPlayer.text = number.ToString();
    }

    public void UINumberOfPlayerAppearDisapear(bool addbutton,bool appear)
    {
        if(addbutton)
        {
            m_ButtonAdd.SetActive(appear);
        }
        else
        {
            m_ButtonSub.SetActive(appear);
        }
    }
    #endregion



}
