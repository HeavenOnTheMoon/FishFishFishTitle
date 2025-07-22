using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MexicoGloss 
{
    /// <summary>
    /// ��ͨ����·��
    /// </summary>
    public const string InjuryChasteTide= "Prefab/Bubbles/NormalBubble";
    /// <summary>
    /// �Ƴ�����·��
    /// </summary>
    public const string AnswerChasteTide= "Prefab/Bubbles/RemoveBubble";
    /// <summary>
    /// ��������·��
    /// </summary>
    public const string BackupChasteTide= "Prefab/Bubbles/RewardBubble";
    /// <summary>
    /// �����Ƴ�����·��
    /// </summary>
    public const string BeAnswerChasteTide= "Prefab/Bubbles/UnRemoveBubble";
    /// <summary>
    /// ��������·��
    /// </summary>
    public const string SightChasteTide= "Prefab/Bubbles/SkillBubble";
    /// <summary>
    /// С��Ϸ����·��
    /// </summary>
    public const string SoftSeemChasteTide= "Prefab/Bubbles/MiniGameBubble";
    /// <summary>
    /// ������Ϣ·��
    /// </summary>
    public const string PistonBenignTide= "Assets/Editor/GameBubbleData";
    /// <summary>
    /// ����һ���ͼƬ
    /// </summary>
    public const string PitPistonVanish= "Art/Tex/UI/UI_Bubble/Ice2";

    /// <summary>
    /// ���
    /// </summary>
    public const string ChicVanishTide= "Art/Tex/UI/UI_BonusReward/Ui_Bonus_Gold";
    /// <summary>
    /// �ֽ�
    /// </summary>
    public const string TouchVanishTide= "Art/Tex/UI/UI_BonusReward/Ui_Bonus_Cash";
    /// <summary>
    /// ����ѷ
    /// </summary>
    public const string CarmanVanishTide= "Art/Tex/UI/UI_BonusReward/Ui_Bonus_Amazon";

    public const string CarmanZVanishTide= "SOHOShop/UI_Redeem/UI_ShopZ";

    /// <summary>
    /// ���  
    /// </summary>
    public const string OffsetVanishTide= "Art/Tex/UI/Suck/Reward_Rocket";
    /// <summary>
    /// ����
    /// </summary>
    public const string AlterVanishTide= "Art/Tex/UI/Suck/Reward_Laser";
    /// <summary>
    /// ����
    /// </summary>
    public const string DeformityVanishTide= "Art/Tex/UI/Suck/Reward_Universal";

    public const string PistonAlterVanishTide= "Art/Tex/UI/UI_Bubble/LaserBall";

    public const string ConsiderBattle= "Art/Tex/UI/Suck/DoublingOrange";

    public const string ConsiderQuick= "Art/Tex/UI/Suck/DoublingGreen";

    public const string ConsiderPalace= "Art/Tex/UI/Suck/DoublingPurple";
    #region ����
    /// <summary>
    /// ���ý���
    /// </summary>
    public const string RapportKrill= "RapportKrill";
    /// <summary>
    /// ��ʾ����
    /// </summary>
    public const string Spare= "Spare";
    /// <summary>
    /// ������Ϸ������
    /// </summary>
    public const string PistonSeemKrill= "BubbleGamePanel";
    /// <summary>
    /// ������
    /// </summary>
    public const string HikeKrill= "HomePanel";
    /// <summary>
    /// �ιο�����
    /// </summary>
    public const string AscribeJazzKrill= "ScratchCardPanel";
    /// <summary>
    /// ���ؽ��棨�������棩
    /// </summary>
    public const string ExactAnyplaceKrill= "ExactAnyplaceKrill";
    /// <summary>
    /// �������
    /// </summary>
    public const string CircuitKrill= "RevivalPanel";
    /// <summary>
    /// ʧ�ܽ���
    /// </summary>
    public const string SeemGrowKrill= "GameOverPanel";
    /// <summary>
    /// ��������
    /// </summary>
    public const string BackupKrill= "BackupKrill";

    public const string CoupleKrill= "NewbiePanel";

    public const string BarbKrill= "BarbKrill";

    public const string MustUsKrill= "MustUsKrill";

    public const string ProneVeinKrill= "PiggyBankPanel";

    public const string OliveSpikyKrill= "LuckyWheelPanel";

    public const string SlatKrill= "TaskPanel";
    #endregion

    #region ��Ϣ
    /// <summary>
    /// comb��Ϣ
    /// </summary>
    public const string StarHandful= "CombMessage";
    /// <summary>
    /// ������ɾ��
    /// </summary>
    public const string DarePistonBaboon= "FallBubbleDelete";
    /// <summary>
    /// ���ؽ���
    /// </summary>
    public const string ExactAnyplaceTwig= "LevelCompleteData";
    /// <summary>
    /// ���ؽ���
    /// </summary>
    public const string TowBackupTwig= "FlyRewardData";
    /// <summary>
    /// �ȼ�ˢ��
    /// </summary>
    public const string ExactRejoin= "LevelUpdate";
    /// <summary>
    /// ���߷�����
    /// </summary>
    public const string CutSweepCandlelight= "RayPointOrientation";
    /// <summary>
    /// �������Ӵ�Ǯ�޽���
    /// </summary>
    public const string CornDamColumn= "SendAddEnergy";
    /// <summary>
    /// ���ʹ�Ǯ�޽��ȶ���
    /// </summary>
    public const string CornDamColumnAstronaut= "SendAddEnergyAnimation";
    /// <summary>
    /// ���ͷ�������Ϣ
    /// </summary>
    public const string CornPistonHardly= "SendBubbleLaunch";
    /// <summary>
    /// ����ȡ������
    /// </summary>
    public const string CornSilicaNutSightHandful= "SendCancelUseSkillMessage";
    /// <summary>
    /// ������ͼƬ����
    /// </summary>
    public const string CornSackMouseBaboon= "SendHandImageDelete";
    /// <summary>
    /// ������ͼƬ��ʾ
    /// </summary>
    public const string CornSackMouseHeel= "SendHandImageShow";
    /// <summary>
    /// �����Ƿ���������
    /// </summary>
    public const string CornByWifeColumn= "SendIsOpenEnergy";
    /// <summary>
    /// ʣ��С����֪ͨ
    /// </summary>
    public const string CornMammalSupplyRejoin= "SendLanuchNumberUpdate";
    /// <summary>
    /// ��������С����Ϣ
    /// </summary>
    public const string CornCircuitDamPiston= "SendRevivalAddBubble";
    /// <summary>
    /// ����������������
    /// </summary>
    public const string CornCoupleTwig= "SendNewbieData";
    /// <summary>
    /// ����tips��Ϣ
    /// </summary>
    public const string CornBarbKrillTwig= "SendTipsPanelData";
    /// <summary>
    /// ���Ͳ��Ų������
    /// </summary>
    public const string CornBeerLaminaAD= "SendPlayInsertAD";
    /// <summary>
    /// ���ʹ���޽���ˢ��
    /// </summary>
    public const string CornShootRejoin= "SendScoreUpdate";
    /// <summary>
    /// ����ʹ�ü���index
    /// </summary>
    public const string CornSightBrace= "SendSkillIndex";
    /// <summary>
    /// ���ͼ��ܵ�λ��Ϣ
    /// </summary>
    public const string CornSightCut= "SendSkillRay";
    /// <summary>
    /// ���ͼ���indexˢ��
    /// </summary>
    public const string CornSightSupplyRejoin= "SendSkillNumberUpdate";
    /// <summary>
    /// �����Ƿ�ʹ�ü���
    /// </summary>
    public const string CornNutSightHandful= "SendUseSkillMessage";
    /// <summary>
    /// ������Ϸ�Ƿ���ͣ
    /// </summary>
    public const string CornSeemByAdult= "SendGameIsPause";
    /// <summary>
    /// ������������ˢ��
    /// </summary>
    public const string CornSlatTwigRejoin= "SendTaskDataUpdate";

    public const string CornStyleDownSlatPloyRejoin= "SendCountDownTaskTimeUpdate";
    #endregion
}
