// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.KR
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x0201,
        NpcSpawn = 0x008F,
        NpcSpawn2 = 0x0097,
        ActorFreeSpawn = 0x0065,
        ObjectSpawn = 0x0237,
        ObjectDespawn = 0x0136,
        CreateTreasure = 0x0381,
        OpenTreasure = 0x0296,
        TreasureFadeOut = 0x0217,
        ActorMove = 0x0289,
        _record_unk10_ = 0x00B7,
        Transfer = 0x0341,
        Effect = 0x01CB,
        AoeEffect8 = 0x025A,
        AoeEffect16 = 0x03B5,
        AoeEffect24 = 0x008E,
        AoeEffect32 = 0x03C4,
        ActorCast = 0x019F,
        ActorControl = 0x00E0,
        ActorControlTarget = 0x0216,
        ActorControlSelf = 0x0067,
        DirectorVars = 0x00ED,
        ContentDirectorSync = 0x037C,
        _record_unk23_ = 0x0068,
        EnvironmentControl = 0x03D2,
        _record_unk29_ = 0x02BB,
        LandSetMap = 0x0288,
        _record_unk31_ = 0x01F2,
        EventStart = 0x00E6,
        EventFinish = 0x0119,
        EventPlay = 0x03CC,
        EventPlay4 = 0x0258,
        EventPlay8 = 0x015C,
        EventPlay16 = 0x01CF,
        EventPlay32 = 0x02F1,
        EventPlay64 = 0x0195,
        EventPlay128 = 0x02B1,
        EventPlay255 = 0x00A5,
        BattleTalk2 = 0x00F5,
        BattleTalk4 = 0x01C6,
        BattleTalk8 = 0x02B9,
        BalloonTalk2 = 0x017D,
        BalloonTalk4 = 0x00FD,
        BalloonTalk8 = 0x00DA,
        SystemLogMessage = 0x01F6,
        SystemLogMessage32 = 0x0380,
        SystemLogMessage48 = 0x033F,
        SystemLogMessage80 = 0x008A,
        SystemLogMessage144 = 0x0374,
        NpcYell = 0x0271,
        ActorSetPos = 0x00BC,
        PrepareZoning = 0x0155,
        _record_unk58_ = 0x02DD,
        WeatherChange = 0x01BD,
        UpdateParty = 0x037B,
        UpdateAlliance = 0x02C3,
        UpdateSpAlliance = 0x029C,
        UpdateHpMpTp = 0x02A8,
        StatusEffectList = 0x0086,
        StatusEffectList2 = 0x0273,
        StatusEffectList3 = 0x026B,
        EurekaStatusEffectList = 0x036C,
        BossStatusEffectList = 0x0088,
        EffectResult = 0x00A0,
        EffectResult4 = 0x03C0,
        EffectResult8 = 0x0264,
        EffectResult16 = 0x024E,
        EffectResultBasic = 0x0229,
        EffectResultBasic4 = 0x014B,
        EffectResultBasic8 = 0x0275,
        EffectResultBasic16 = 0x0249,
        EffectResultBasic32 = 0x02A9,
        EffectResultBasic64 = 0x0200,
        PartyPos = 0x01A0,
        AlliancePos = 0x02D4,
        SpAlliancePos = 0x03C5,
        PlaceMarker = 0x0291,
        PlaceFieldMarkerPreset = 0x01D4,
        PlaceFieldMarker = 0x026A,
        ActorGauge = 0x03BE,
        CharaVisualEffect = 0x0340,
        Fall = 0x02A4,
        UpdateHate = 0x021F,
        UpdateHater = 0x02DF,
        FirstAttack = 0x01B1,
        ModelEquip = 0x009D,
        EquipDisplayFlags = 0x00A3,
        UnMount = 0x008C,
        Mount = 0x0203,
        PlayMotionSync = 0x0313,
        CountdownInitiate = 0x017A,
        CountdownCancel = 0x0360,
        InitZone = 0x01B9,
        Examine = 0x02E0,
        ExamineSearchInfo = 0x01DB,
        InventoryActionAck = 0x0152,
        MarketBoardItemListing = 0x024C,
        MarketBoardItemListingCount = 0x00D4,
        MarketBoardItemListingHistory = 0x00A1,
        MarketBoardSearchResult = 0x0397,
        MarketBoardPurchase = 0x03AC,
        PlayerSetup = 0x00FC,
        PlayerStats = 0x024D,
        Playtime = 0x0092,
        UpdateClassInfo = 0x00DE,
        UpdateInventorySlot = 0x011D,
        UpdateSearchInfo = 0x02EC,
        WardLandInfo = 0x03D9,
        CEDirector = 0x021C,
        Logout = 0x02B3,
        FreeCompanyInfo = 0x007B,
        FreeCompanyDialog = 0x035F,
        AirshipStatusList = 0x0071,
        AirshipStatus = 0x01F3,
        AirshipExplorationResult = 0x035A,
        SubmarineStatusList = 0x03D6,
        SubmarineProgressionStatus = 0x0124,
        SubmarineExplorationResult = 0x0212,
        CFPreferredRole = 0x03E2,
        CompanyAirshipStatus = 0x009F,
        CompanySubmersibleStatus = 0x02F4,
        ContentFinderNotifyPop = 0x01E3,
        FateInfo = 0x02C8,
        UpdateRecastTimes = 0x03C8,
        SocialList = 0x01B2,
        IslandWorkshopSupplyDemand = 0x00A6,
        RSV = 0x00A8,
        RSF = 0x0078,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x03BD,
        ActionRequestGroundTargeted = 0x010D,
        ChatHandler = 0x020A,
        ClientTrigger = 0x031C,
        InventoryModifyHandler = 0x03BA,
        MarketBoardPurchaseHandler = 0x00EF,
        SetSearchInfoHandler = 0x0177,
        UpdatePositionHandler = 0x0245,
        UpdatePositionInstance = 0x029D,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
