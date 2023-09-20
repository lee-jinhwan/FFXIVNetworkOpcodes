// Generated by https://github.com/gamous/FFXIVNetworkOpcodes
namespace FFXIVOpcodes.Global
{
    public enum ServerLobbyIpcType : ushort
    {
    
    };
    
    public enum ClientLobbyIpcType : ushort
    {
    
    };
    
    public enum ServerZoneIpcType : ushort
    {
        PlayerSpawn = 0x010E,
        NpcSpawn = 0x0091,
        NpcSpawn2 = 0x02B6,
        ActorFreeSpawn = 0x0112,
        ObjectSpawn = 0x0190,
        ObjectDespawn = 0x00D2,
        CreateTreasure = 0x0225,
        OpenTreasure = 0x0393,
        TreasureFadeOut = 0x0169,
        ActorMove = 0x01AA,
        _record_unk10_ = 0x01ED,
        Transfer = 0x0276,
        Effect = 0x0354,
        AoeEffect8 = 0x018F,
        AoeEffect16 = 0x038F,
        AoeEffect24 = 0x00D1,
        AoeEffect32 = 0x0340,
        ActorCast = 0x00C8,
        ActorControl = 0x00D4,
        ActorControlTarget = 0x00EF,
        ActorControlSelf = 0x03C1,
        DirectorVars = 0x0114,
        ContentDirectorSync = 0x01FA,
        _record_unk23_ = 0x03AA,
        EnvironmentControl = 0x0137,
        _record_unk29_ = 0x016A,
        LandSetMap = 0x0366,
        _record_unk31_ = 0x0178,
        EventStart = 0x02BE,
        EventFinish = 0x0289,
        EventPlay = 0x02DB,
        EventPlay4 = 0x00E8,
        EventPlay8 = 0x00FE,
        EventPlay16 = 0x008F,
        EventPlay32 = 0x0374,
        EventPlay64 = 0x027F,
        EventPlay128 = 0x0365,
        EventPlay255 = 0x00DB,
        BattleTalk2 = 0x0151,
        BattleTalk4 = 0x0372,
        BattleTalk8 = 0x00E3,
        BalloonTalk2 = 0x02D6,
        BalloonTalk4 = 0x037E,
        BalloonTalk8 = 0x030B,
        SystemLogMessage = 0x03C8,
        SystemLogMessage32 = 0x0319,
        SystemLogMessage48 = 0x022F,
        SystemLogMessage80 = 0x00BA,
        SystemLogMessage144 = 0x01E5,
        NpcYell = 0x0163,
        ActorSetPos = 0x032C,
        PrepareZoning = 0x0188,
        _record_unk58_ = 0x02B7,
        WeatherChange = 0x021C,
        UpdateParty = 0x016F,
        UpdateAlliance = 0x02C9,
        UpdateSpAlliance = 0x01F5,
        UpdateHpMpTp = 0x01FB,
        StatusEffectList = 0x01DD,
        StatusEffectList2 = 0x0166,
        StatusEffectList3 = 0x031F,
        EurekaStatusEffectList = 0x0192,
        BossStatusEffectList = 0x02CB,
        EffectResult = 0x02A3,
        EffectResult4 = 0x015D,
        EffectResult8 = 0x00C2,
        EffectResult16 = 0x00B3,
        EffectResultBasic = 0x00FA,
        EffectResultBasic4 = 0x0263,
        EffectResultBasic8 = 0x01B9,
        EffectResultBasic16 = 0x0370,
        EffectResultBasic32 = 0x028C,
        EffectResultBasic64 = 0x03DA,
        PartyPos = 0x01C2,
        AlliancePos = 0x0093,
        SpAlliancePos = 0x01B5,
        PlaceMarker = 0x0202,
        PlaceFieldMarkerPreset = 0x0221,
        PlaceFieldMarker = 0x0194,
        ActorGauge = 0x02A4,
        CharaVisualEffect = 0x02FC,
        Fall = 0x023B,
        UpdateHate = 0x033F,
        UpdateHater = 0x0356,
        FirstAttack = 0x0161,
        ModelEquip = 0x0082,
        EquipDisplayFlags = 0x024E,
        UnMount = 0x02B2,
        Mount = 0x0242,
        PlayMotionSync = 0x0274,
        CountdownInitiate = 0x0399,
        CountdownCancel = 0x0342,
        InitZone = 0x0071,
        Examine = 0x0200,
        ExamineSearchInfo = 0x0357,
        InventoryActionAck = 0x0134,
        MarketBoardItemListing = 0x01DB,
        MarketBoardItemListingCount = 0x0306,
        MarketBoardItemListingHistory = 0x02F4,
        MarketBoardSearchResult = 0x03D6,
        MarketBoardPurchase = 0x01F0,
        PlayerSetup = 0x020E,
        PlayerStats = 0x02F3,
        Playtime = 0x0313,
        UpdateClassInfo = 0x03E3,
        UpdateInventorySlot = 0x00A4,
        UpdateSearchInfo = 0x0115,
        WardLandInfo = 0x0395,
        CEDirector = 0x0147,
        Logout = 0x0116,
        FreeCompanyInfo = 0x030F,
        FreeCompanyDialog = 0x01B4,
        AirshipStatusList = 0x02E4,
        AirshipStatus = 0x016B,
        AirshipExplorationResult = 0x0359,
        SubmarineStatusList = 0x00C4,
        SubmarineProgressionStatus = 0x0152,
        SubmarineExplorationResult = 0x0376,
        CFPreferredRole = 0x0160,
        CompanyAirshipStatus = 0x034F,
        CompanySubmersibleStatus = 0x03AF,
        ContentFinderNotifyPop = 0x0069,
        FateInfo = 0x025B,
        UpdateRecastTimes = 0x037C,
        SocialList = 0x00B1,
        IslandWorkshopSupplyDemand = 0x00F9,
        RSV = 0x0212,
        RSF = 0x019B,
    };
    
    public enum ClientZoneIpcType : ushort
    {
        ActionRequest = 0x00A7,
        ActionRequestGroundTargeted = 0x0065,
        ChatHandler = 0x01DF,
        ClientTrigger  = 0x0186,
        InventoryModifyHandler = 0x02DA,
        MarketBoardPurchaseHandler = 0x015B,
        SetSearchInfoHandler = 0x0230,
        UpdatePositionHandler = 0x03B5,
        UpdatePositionInstance = 0x00A5,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
