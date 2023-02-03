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
        PlayerSpawn = 0x007F,
        NpcSpawn = 0x039E,
        NpcSpawn2 = 0x02E5,
        ActorFreeSpawn = 0x028A,
        ObjectSpawn = 0x031B,
        ObjectDespawn = 0x01B3,
        CreateTreasure = 0x03BE,
        OpenTreasure = 0x00A1,
        TreasureFadeOut = 0x02B2,
        ActorMove = 0x01DB,
        _record_unk10_ = 0x03D3,
        Transfer = 0x02F8,
        Effect = 0x01C9,
        AoeEffect8 = 0x024A,
        AoeEffect16 = 0x038A,
        AoeEffect24 = 0x00C8,
        AoeEffect32 = 0x032B,
        ActorCast = 0x029C,
        ActorControl = 0x0179,
        ActorControlTarget = 0x0220,
        ActorControlSelf = 0x026F,
        DirectorVars = 0x027B,
        ContentDirectorSync = 0x0208,
        _record_unk23_ = 0x03C1,
        EnvironmentControl = 0x02CE,
        _record_unk29_ = 0x0185,
        LandSetMap = 0x00BC,
        _record_unk31_ = 0x00D3,
        EventStart = 0x01A1,
        EventFinish = 0x0194,
        EventPlay = 0x02DE,
        EventPlay4 = 0x0317,
        EventPlay8 = 0x01CD,
        EventPlay16 = 0x01FE,
        EventPlay32 = 0x02FC,
        EventPlay64 = 0x007C,
        EventPlay128 = 0x0337,
        EventPlay255 = 0x01D2,
        SystemLogMessage = 0x009A,
        SystemLogMessage32 = 0x016F,
        SystemLogMessage48 = 0x018B,
        SystemLogMessage80 = 0x00ED,
        SystemLogMessage144 = 0x0279,
        NpcYell = 0x035A,
        ActorSetPos = 0x018C,
        PrepareZoning = 0x0195,
        _record_unk58_ = 0x0301,
        StatusEffectList3 = 0x024C,
        WeatherChange = 0x00C7,
        UpdateParty = 0x01F6,
        UpdateAlliance = 0x012C,
        UpdateSpAlliance = 0x033E,
        UpdateHpMpTp = 0x0383,
        StatusEffectList = 0x02BC,
        EurekaStatusEffectList = 0x0353,
        StatusEffectList2 = 0x0164,
        BossStatusEffectList = 0x01EE,
        EffectResult = 0x022C,
        EffectResult4 = 0x01B6,
        EffectResult8 = 0x016E,
        EffectResult16 = 0x0250,
        EffectResultBasic = 0x0384,
        EffectResultBasic4 = 0x0121,
        EffectResultBasic8 = 0x01D7,
        EffectResultBasic16 = 0x03D9,
        EffectResultBasic32 = 0x0332,
        EffectResultBasic64 = 0x0275,
        PartyPos = 0x02CB,
        AlliancePos = 0x037C,
        SpAlliancePos = 0x010C,
        PlaceMarker = 0x034E,
        PlaceFieldMarkerPreset = 0x0204,
        PlaceFieldMarker = 0x038E,
        ActorGauge = 0x0171,
        CharaVisualEffect = 0x01E9,
        Fall = 0x0336,
        UpdateHate = 0x0134,
        UpdateHater = 0x02F9,
        FirstAttack = 0x01D3,
        ModelEquip = 0x0286,
        EquipDisplayFlags = 0x0303,
        UnMount = 0x03A7,
        Mount = 0x0322,
        PlayMotionSync = 0x025B,
        CountdownInitiate = 0x03B1,
        CountdownCancel = 0x00B6,
        InitZone = 0x0222,
        Examine = 0x01BC,
        ExamineSearchInfo = 0x030E,
        InventoryActionAck = 0x01EB,
        MarketBoardItemListing = 0x02F1,
        MarketBoardItemListingCount = 0x00AA,
        MarketBoardItemListingHistory = 0x00A8,
        MarketBoardSearchResult = 0x021E,
        MarketBoardPurchase = 0x032F,
        PlayerSetup = 0x02B3,
        PlayerStats = 0x01B8,
        Playtime = 0x0326,
        UpdateClassInfo = 0x02EC,
        UpdateInventorySlot = 0x010E,
        UpdateSearchInfo = 0x034A,
        WardLandInfo = 0x00E4,
        CEDirector = 0x00B8,
        Logout = 0x01D0,
        FreeCompanyInfo = 0x01DD,
        FreeCompanyDialog = 0x00E6,
        AirshipStatusList = 0x0070,
        AirshipStatus = 0x0142,
        AirshipExplorationResult = 0x034F,
        SubmarineStatusList = 0x0232,
        SubmarineProgressionStatus = 0x0148,
        SubmarineExplorationResult = 0x01A8,
        CFPreferredRole = 0x00DE,
        CompanyAirshipStatus = 0x026B,
        CompanySubmersibleStatus = 0x0103,
        ContentFinderNotifyPop = 0x038B,
        FateInfo = 0x0187,
        UpdateRecastTimes = 0x01B9,
        SocialList = 0x01F1,
        IslandWorkshopSupplyDemand = 0x039B,
        RSV = 0x0374,
        RSF = 0x0338,
    };
    
    public enum ClientLobbyIpcType : ushort
    {
        ActionRequest = 0x0249,
        ActionRequestGroundTargeted = 0x03DC,
        ClientTrigger  = 0x0174,
        InventoryModifyHandler = 0x008F,
        MarketBoardPurchaseHandler = 0x0095,
        SetSearchInfoHandler = 0x0227,
        UpdatePositionHandler = 0x010F,
        UpdatePositionInstance = 0x00DB,
    };
    
    public enum ServerChatIpcType : ushort
    {
    
    };
    
    public enum ClientChatIpcType : ushort
    {
    
    };
    
}
