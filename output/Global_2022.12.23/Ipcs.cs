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
        ActorCast = 0x00B0,
        ActorControl = 0x0131,
        ActorControlSelf = 0x01A8,
        ActorControlTarget = 0x008F,
        ActorGauge = 0x00F9,
        ActorMove = 0x0183,
        ActorSetPos = 0x0181,
        Effect = 0x01E6,
        AoeEffect8 = 0x031B,
        AoeEffect16 = 0x03BE,
        AoeEffect24 = 0x02C4,
        AoeEffect32 = 0x0214,
        BossStatusEffectList = 0x03DE,
        CFPreferredRole = 0x0194,
        CompanyAirshipStatus = 0x01C0,
        CompanySubmersibleStatus = 0x025F,
        ContentFinderNotifyPop = 0x00CB,
        EffectResult = 0x01C8,
        EffectResult4 = 0x008D,
        EffectResult8 = 0x00D2,
        EffectResult16 = 0x00AE,
        EffectResultBasic = 0x013A,
        EffectResultBasic4 = 0x03A4,
        EffectResultBasic8 = 0x02A6,
        EffectResultBasic16 = 0x01BA,
        EffectResultBasic32 = 0x0125,
        EffectResultBasic64 = 0x0357,
        EventFinish = 0x017E,
        EventPlay = 0x036B,
        EventPlay4 = 0x03D6,
        EventPlay8 = 0x0161,
        EventPlay16 = 0x0158,
        EventPlay32 = 0x03CB,
        EventPlay64 = 0x0223,
        EventPlay128 = 0x026E,
        EventPlay255 = 0x0135,
        EventStart = 0x0389,
        Examine = 0x00E5,
        ExamineSearchInfo = 0x01EE,
        InitZone = 0x028A,
        InventoryActionAck = 0x006D,
        MarketBoardItemListing = 0x029D,
        MarketBoardItemListingCount = 0x0250,
        MarketBoardItemListingHistory = 0x03E3,
        MarketBoardSearchResult = 0x0334,
        NpcSpawn = 0x0166,
        NpcSpawn2 = 0x00C8,
        ObjectSpawn = 0x00FF,
        PlaceFieldMarker = 0x0235,
        PlaceFieldMarkerPreset = 0x030A,
        PlayerSetup = 0x0227,
        PlayerSpawn = 0x0321,
        PlayerStats = 0x00E6,
        Playtime = 0x0075,
        PrepareZoning = 0x019D,
        SystemLogMessage = 0x0252,
        StatusEffectList = 0x0192,
        StatusEffectList2 = 0x00DB,
        StatusEffectList3 = 0x02E7,
        UpdateClassInfo = 0x0239,
        UpdateHpMpTp = 0x015B,
        UpdateInventorySlot = 0x0188,
        UpdateSearchInfo = 0x0302,
        WardLandInfo = 0x023E,
        CEDirector = 0x0269,
        Logout = 0x0373,
        MarketBoardPurchase = 0x0205,
        AirshipStatusList = 0x019E,
        AirshipStatus = 0x0229,
        SubmarineProgressionStatus = 0x01E5,
        SubmarineStatusList = 0x00DA,
        FreeCompanyInfo = 0x0175,
        AirshipExplorationResult = 0x00CF,
        SubmarineExplorationResult = 0x01B9,
        FreeCompanyDialog = 0x02CB,
        FateInfo = 0x034E,
        EnvironmentControl = 0x0224,
        UpdateRecastTimes = 0x010B,
        UpdateHate = 0x00B8,
        UpdateHater = 0x00C0,
        SocialList = 0x0329,
        IslandWorkshopSupplyDemand = 0x03E7,
    };
    
    public enum ClientLobbyIpcType : ushort
    {
        ActionRequest = 0x00E1,
        ActionRequestGroundTargeted = 0x0143,
        ChatHandler = 0x0140,
        ClientTrigger  = 0x00FC,
        InventoryModifyHandler = 0x0340,
        MarketBoardPurchaseHandler = 0x0384,
        SetSearchInfoHandler = 0x00BE,
        UpdatePositionHandler = 0x019C,
        UpdatePositionInstance = 0x01F6,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
