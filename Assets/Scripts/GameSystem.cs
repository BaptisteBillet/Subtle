using UnityEngine;
using System.Collections;

public enum e_GameStep
{
    NUMBEROFPLAYER,
    THEMEDISTRIBUTION,
    PLAYERDECLARATION,
    PLAYERVOTE,
    RESULT
}

public partial class GameSystem : MonoBehaviour {

    #region
    const int m_NUMBEROFPLAYERSMINIMUM=3;
    const int m_NUMBEROFPLAYERSMAXIMUM=6;
    #endregion

    [Header("Access to the UI Manager")]
    public UIManager m_UIManager;


    #region NumberOfPlayers
    public int m_NumberOfPlayers;
    #endregion

    private bool m_NextStep;

    [HideInInspector]
    public e_GameStep m_GameStep;

    // Use this for initialization
    void Awake ()
    {
        m_UIManager.m_GameSystem = this;

        m_GameStep = e_GameStep.NUMBEROFPLAYER;

        m_NumberOfPlayers = m_NUMBEROFPLAYERSMINIMUM;
        NumberOfPlayerVerification();
        m_UIManager.UINumberOfPlayerChangeNumberOfPlayer(m_NumberOfPlayers);
    }


    //Launch everytime the nextbutton is pushed
    public void NextStepButtonPressed()
    {
        switch (m_GameStep)
        {
            case e_GameStep.NUMBEROFPLAYER:
                ChangeStep();
                ThemeDistributionInstantiatePlayers();
                break;

            case e_GameStep.THEMEDISTRIBUTION:
                if(m_NextStep==true)
                {

                }
                else
                {

                }
                break;

          
        }
        m_NextStep = false;
    }

    //Launch when the game need to change step
    private void ChangeStep()
    {
        switch(m_GameStep)
        {
            case e_GameStep.NUMBEROFPLAYER:
                m_GameStep = e_GameStep.THEMEDISTRIBUTION;
                break;

            case e_GameStep.THEMEDISTRIBUTION:
                m_GameStep = e_GameStep.PLAYERDECLARATION;
                break;
                
            case e_GameStep.PLAYERDECLARATION:
                m_GameStep = e_GameStep.PLAYERVOTE;
                m_UIManager.ChangePanel(e_UIPanel.PANELWAITFORPLAYERDECLARATION);
                break;

            case e_GameStep.PLAYERVOTE:
                m_GameStep = e_GameStep.RESULT;
                m_UIManager.ChangePanel(e_UIPanel.PANELWINNER);
                break;
                
            case e_GameStep.RESULT:

                break;
        }
    }


}
