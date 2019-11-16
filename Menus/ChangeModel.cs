﻿using CitizenFX.Core;
using CitizenFX.Core.Native;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client.Menus
{
    internal class ChangeModel : Drawing
    {
        public static async Task SetModel(string name)
        {
            int model = GenHash(name);
            int player = Function.Call<int>(Hash.PLAYER_ID);

            await Main.PerformRequest(model);

            Function.Call(Hash.SET_PLAYER_MODEL, player, model, false);
            Function.Call((Hash)0x283978A15512B2FE, Function.Call<int>(Hash.PLAYER_PED_ID), true);
            Function.Call(Hash.SET_MODEL_AS_NO_LONGER_NEEDED, model);
            
            Toast.AddToast($"Switching to {name}!", 3000, 0.25f + (0.3f / 2), GetCurrentActiveY());
        }

        public static async Task Draw()
        {
            SetMenuTitle("Change Model", "mmmmmmmmodel");

            foreach (string p in peds)
            {
                int i = AddMenuEntry(p);

                if (IsEntryPressed(i))
                {
                    await SetModel(p);
                }
            }

            await Task.FromResult(0);
        }

        // auto-generated
        static string[] peds = new[]
        {
            "CS_BILLWILLIAMSON",
        "CS_MICAHBELL",
        "CS_UNCLE",
        "CS_SEAN",
        "CS_KIERAN",
        "A_M_M_WapWarriors_01",
        "A_M_O_WapTownfolk_01",
        "A_F_O_WapTownfolk_01",
        "U_M_M_WAPOFFICIAL_01",
        "A_M_M_WAPWARRIORS_01",
        "A_M_O_WAPTOWNFOLK_01",
        "S_M_M_UNITRAINENGINEER_01",
        "S_M_M_UNITRAINGUARDS_01",
        "A_M_M_MiddleTrainPassengers_01",
        "A_F_M_MiddleTrainPassengers_01",
        "A_M_M_LowerTrainPassengers_01",
        "A_F_M_LowerTrainPassengers_01",
        "A_M_M_UpperTrainPassengers_01",
        "A_F_M_UpperTrainPassengers_01",
        "A_M_M_NBXUPPERCLASS_01",
        "A_F_M_NBXUPPERCLASS_01",
        "G_M_M_UNIDUSTER_02",
        "G_M_M_UNIDUSTER_03",
        "CS_EDMUNDLOWRY",
        "G_M_M_UniBanditos_01",
        "CS_POISONWELLSHAMAN",
        "S_M_M_RACRAILGUARDS_01",
        "U_M_M_valbarber_01",
        "U_M_M_ValBartender_01",
        "U_M_M_ValDoctor_01",
        "U_M_M_ValGunsmith_01",
        "CS_VALSHERIFF",
        "G_M_M_UNIDUSTER_01",
        "S_M_M_SDTICKETSELLER_01",
        "S_M_M_MagicLantern_01",
        "CS_GrizzledJon",
        "A_M_M_VALCRIMINALS_01",
        "A_M_M_ASBMINER_02",
        "A_M_Y_ASBMINER_02",
        "A_M_M_ASBMINER_04",
        "A_M_Y_ASBMINER_04",
        "A_M_M_ASBMINER_03",
        "A_M_Y_ASBMINER_03",
        "A_M_M_JamesonGuard_01",
        "U_M_O_ASBSHERIFF_01",
        "A_M_M_RkrFancyDRIVERS_01",
        "A_M_M_RkrFancyTravellers_01",
        "A_F_M_RkrFancyTravellers_01",
        "S_M_M_CornwallGuard_01",
        "G_M_M_UniCornwallGoons_01",
        "U_M_M_CRDHOMESTEADTENANT_01",
        "U_M_M_CRDHOMESTEADTENANT_02",
        "U_M_O_PSHRANCHER_01",
        "U_M_O_CAJHOMESTEAD_01",
        "U_M_Y_CAJHOMESTEAD_01",
        "U_M_M_CAJHOMESTEAD_01",
        "CS_DOROETHEAWICKLOW",
        "S_M_M_AmbientSDPolice_01",
        "A_M_M_SDObeseMen_01",
        "A_F_M_SDObeseWomen_01",
        "U_M_M_NBXShadyDealer_01",
        "A_F_M_WapTownfolk_01",
        "A_M_M_SDLABORERS_02",
        "A_M_Y_NBXSTREETKIDS_01",
        "A_M_M_LowerSDTownfolk_02",
        "A_M_M_LowerSDTownfolk_01",
        "A_M_Y_NbxStreetKids_Slums_01",
        "A_M_Y_SDStreetKids_Slums_02",
        "A_M_M_SDDockWorkers_02",
        "A_M_M_SDDockForeman_01",
        "A_F_M_NbxSlums_01",
        "A_F_M_SDSlums_02",
        "A_M_M_NbxSlums_01",
        "A_M_M_SDSlums_02",
        "A_M_O_SDUpperClass_01",
        "A_F_M_NbxUpperClass_01",
        "A_F_O_SDUpperClass_01",
        "A_M_M_MiddleSDTownfolk_01",
        "A_M_M_MiddleSDTownfolk_02",
        "A_M_M_MiddleSDTownfolk_03",
        "A_F_M_MiddleSDTownfolk_01",
        "A_F_M_MiddleSDTownfolk_02",
        "A_F_M_LowerSDTownfolk_01",
        "A_F_M_LowerSDTownfolk_02",
        "A_F_M_LowerSDTownfolk_03",
        "A_F_M_SDChinatown_01",
        "A_F_O_SDChinatown_01",
        "A_F_M_SDFancyWhore_01",
        "G_M_M_UNIBRONTEGOONS_01",
        "A_M_M_SDChinatown_01",
        "A_M_O_SDChinatown_01",
        "U_M_M_VALGUNSMITH_01",
        "U_M_M_VALGENSTOREOWNER_01",
        "U_M_M_ValButcher_01",
        "A_M_M_VALTOWNFOLK_01",
        "U_M_M_VALDOCTOR_01",
        "S_M_M_BANKCLERK_01",
        "U_M_M_ValHotelOwner_01",
        "U_M_M_VALBARTENDER_01",
        "U_M_M_VALBARBER_01",
        "U_M_O_ValBartender_01",
        "U_M_M_NBXBARTENDER_02",
        "A_M_M_BLWUPPERCLASS_01",
        "U_M_M_NBXBARTENDER_01",
        "A_M_M_MIDDLESDTOWNFOLK_01",
        "U_M_M_NBXGENERALSTOREOWNER_01",
        "U_M_M_NBXSHADYDEALER_01",
        "S_M_M_TAILOR_01",
        "U_M_M_NBXGUNSMITH_01",
        "CS_SDDOCTOR_01",
        "S_M_M_LIVERYWORKER_01",
        "S_M_M_MarketVendor_01",
        "U_M_M_SDPhotographer_01",
        "U_M_M_STRGENSTOREOWNER_01",
        "U_M_M_STRFREIGHTSTATIONOWNER_01",
        "U_M_M_ASBGUNSMITH_01",
        "U_M_M_SDTRAPPER_01",
        "S_M_M_TRAINSTATIONWORKER_01",
        "A_F_M_LAGTOWNFOLK_01",
        "S_M_M_SKPGUARD_01",
        "A_M_M_SKPPRISONER_01",
        "U_F_M_LagMother_01",
        "A_F_O_LagTownfolk_01",
        "A_M_O_LagTownfolk_01",
        "A_M_M_RHDFOREMAN_01",
        "U_M_M_ORPGUARD_01",
        "CS_ABE",
        "CS_DavidGeddes",
        "CS_ANGUSGEDDES",
        "CS_DUNCANGEDDES",
        "CS_MRSGEDDES",
        "G_M_M_UNIMOUNTAINMEN_01",
        "A_F_M_LagTownfolk_01",
        "CS_ThomasDown",
        "CS_ArchieDown",
        "CS_EDITHDOWN",
        "S_F_M_MaPWorker_01",
        "A_M_M_StrTownfolk_01",
        "A_M_M_STRLABORER_01",
        "A_M_M_BynRoughTravellers_01",
        "A_C_DOGPOODLE_01",
        "S_M_M_RHDCOWPOKE_01",
        "S_M_M_UniButchers_01",
        "S_M_Y_NewspaperBoy_01",
        "A_F_M_RhdUpperClass_01",
        "A_F_M_RhdTownfolk_02",
        "a_m_m_rhdtownfolk_01_laborer",
        "A_F_M_RHDTOWNFOLK_01",
        "U_M_M_RHDBARTENDER_01",
        "U_M_M_RHDGUNSMITH_01",
        "U_M_M_RHDGENSTOREOWNER_01",
        "U_M_M_RHDGENSTOREOWNER_02",
        "U_M_M_RHDSHERIFF_01",
        "U_M_M_RHDTRAINSTATIONWORKER_01",
        "A_F_M_RHDPROSTITUTE_01",
        "A_M_M_RHDObeseMen_01",
        "A_M_M_RhdUpperClass_01",
        "A_M_M_RkrRoughTravellers_01",
        "A_C_DOGCATAHOULACUR_01",
        "A_F_M_VHTTOWNFOLK_01",
        "A_M_M_VHTTHUG_01",
        "U_M_M_VHTSTATIONCLERK_01",
        "U_M_O_VHTEXOTICSHOPKEEPER_01",
        "U_F_M_VhTBartender_01",
        "A_M_M_HtlFancyDRIVERS_01",
        "A_M_M_HtlFancyTravellers_01",
        "A_F_M_HtlFancyTravellers_01",
        "S_M_M_BARBER_01",
        "S_M_M_UNIBUTCHERS_01",
        "S_M_M_BLWCOWPOKE_01",
        "A_M_M_BLWObeseMen_01",
        "A_M_O_BlWUpperClass_01",
        "A_F_M_BlWUpperClass_01",
        "A_F_O_BlWUpperClass_01",
        "A_M_M_BlWLaborer_02",
        "A_M_M_BlWLaborer_01",
        "A_M_M_BlWForeman_01",
        "A_F_M_BlWTownfolk_02",
        "A_F_M_BlWTownfolk_01",
        "S_M_M_AmbientBlWPolice_01",
        "S_M_M_FussarHenchman_01",
        "A_F_M_GuaTownfolk_01",
        "A_F_O_GuaTownfolk_01",
        "A_M_M_GuaTownfolk_01",
        "A_M_O_GuaTownfolk_01",
        "CS_NicholasTimmins",
        "A_M_M_STRFANCYTOURIST_01",
        "A_F_M_BiVFancyTravellers_01",
        "A_F_M_STRTOWNFOLK_01",
        "A_M_M_UNIGUNSLINGER_01",
        "U_M_M_StrGenStoreOwner_01",
        "U_M_M_STRWELCOMECENTER_01",
        "U_M_M_STRSHERRIFF_01",
        "U_M_M_StrFreightStationOwner_01",
        "G_M_M_UNICRIMINALS_01",
        "G_M_M_UNICRIMINALS_02",
        "A_M_M_BTCObeseMen_01",
        "A_F_M_BTCObeseWomen_01",
        "A_M_M_AsbTownfolk_01",
        "A_F_M_AsbTownfolk_01",
        "A_F_M_BTCHILLBILLY_01",
        "A_F_O_BTCHILLBILLY_01",
        "A_M_M_BTCHILLBILLY_01",
        "G_M_M_UniBraithwaites_01",
        "U_M_O_CmrCivilwarcommando_01",
        "S_M_M_Army_01",
        "U_M_M_BWMSTABLEHAND_01",
        "S_M_M_CGHWORKER_01",
        "G_M_M_UniGrays_01",
        "G_M_O_UniExConfeds_01",
        "G_M_Y_UniExConfeds_01",
        "G_M_M_UNIINBRED_01",
        "CS_AberdeenSister",
        "A_M_M_GriRoughTravellers_01",
        "A_F_M_ValTownfolk_01",
        "U_F_O_WTCTOWNFOLK_01",
        "U_M_M_BLWTRAINSTATIONWORKER_01",
        "CS_BLWPHOTOGRAPHER",
        "A_M_M_BlWTownfolk_01",
        "U_M_O_BLWPOLICECHIEF_01",
        "S_M_M_Tailor_01",
        "S_M_M_BankClerk_01",
        "U_M_O_BLWBARTENDER_01",
        "U_M_O_BLWGENERALSTOREOWNER_01",
        "S_M_M_TumDeputies_01",
        "CS_SHERIFFFREEMAN",
        "A_M_M_NEAROUGHTRAVELLERS_01",
        "A_M_M_TumTownfolk_01",
        "A_F_M_TumTownfolk_01",
        "A_M_M_TumTownfolk_02",
        "A_F_M_TumTownfolk_02",
        "U_M_M_TUMBARTENDER_01",
        "U_M_M_TUMBUTCHER_01",
        "U_M_M_TUMGUNSMITH_01",
        "U_F_M_TUMGENERALSTOREOWNER_01",
        "A_M_M_ARMTOWNFOLK_01",
        "A_M_M_RANCHERTRAVELERS_WARM_01",
        "S_M_M_AmbientLawRural_01",
        "A_M_M_ArmCholeraCorpse_01",
        "A_F_M_ArmCholeraCorpse_01",
        "U_M_M_ARMGENERALSTOREOWNER_01",
        "U_M_O_ARMBARTENDER_01",
        "U_M_M_ARMTRAINSTATIONWORKER_01",
        "U_M_M_ARMUNDERTAKER_01",
        "RE_DEADBODIES_MALE",
        "RE_DEADBODIES_MALES_01",
        "A_F_M_ArmTownfolk_01",
        "A_F_M_ArmTownfolk_02",
        "A_M_M_ArmTownfolk_01",
        "A_M_M_ArmTownfolk_02",
        "A_F_M_FAMILYTRAVELERS_WARM_01",
        "CS_WROBEL",
        "U_M_M_CZPHOMESTEADFATHER_01",
        "U_F_Y_CZPHOMESTEADDAUGHTER_01",
        "U_M_Y_CZPHOMESTEADSON_01",
        "U_M_Y_CZPHOMESTEADSON_02",
        "U_M_Y_CZPHOMESTEADSON_03",
        "U_M_M_LRSHOMESTEADTENANT_01",
        "U_F_M_RKSHOMESTEADTENANT_01",
        "U_M_M_UNIEXCONFEDSBOUNTY_01",
        "U_M_M_WALGENERALSTOREOWNER_01",
        "S_M_M_TrainStationWorker_01",
        "p_m_zero",
        "P_M_THREE",
        "A_C_HORSE_GANG_KIERAN",
        "CS_Dutch",
        "CS_JackMarston",
        "CS_JACKMARSTON_TEEN",
        "CS_EagleFlies",
        "CS_Cleet",
        "CS_Joe",
        "CS_CREOLECAPTAIN",
        "CS_JosiahTrelawny",
        "CS_RevSwanson",
        "CS_LeoStrauss",
        "CS_MrPearson",
        "CS_Lenny",
        "CS_Sean",
        "CS_HoseaMatthews",
        "CS_JavierEscuella",
        "CS_CharlesSmith",
        "CS_Uncle",
        "CS_BillWilliamson",
        "CS_MicahBell",
        "CS_JohnMarston",
        "CS_AbigailRoberts",
        "CS_MaryBeth",
        "CS_MollyOshea",
        "CS_SusanGrimshaw",
        "CS_Karen",
        "CS_Tilly",
        "CS_MrsAdler",
        "A_M_M_HtlRoughTravellers_01",
        "A_M_M_SclRoughTravellers_01",
        "U_M_M_LnSWorker_01",
        "U_M_M_LnSWorker_02",
        "U_M_M_LnSWorker_03",
        "U_M_M_LnSWorker_04",
        "U_M_M_RKFRANCHER_01",
        "A_M_M_Rancher_01",
        "U_M_M_MFRRANCHER_01",
        "EA_LCMP_DOGS",
        "EA_LCMP_FOREMAN",
        "U_M_M_BiVForeman_01",
        "EA_HMSTD_FOREMAN",
        "U_M_M_HtlForeman_01",
        "EA_HMSTD_WORKER_1",
        "EA_HMSTD_WORKER_2",
        "EA_HMSTD_MALE",
        "U_M_M_HTLHusband_01",
        "EA_HMSTD_FEMALE",
        "U_F_M_HTLWife_01",
        "EA_RCAMP_FOREMAN",
        "U_M_M_RaCForeman_01",
        "A_M_M_NbxUpperClass_01",
        "A_M_M_BlWUpperClass_01",
        "CS_Kieran",
        "A_M_M_RHDTOWNFOLK_02",
        "S_M_M_CKTWORKER_01",
        "S_M_M_STRLUMBERJACK_01",
        "S_M_M_RaCRailWorker_01",
        "S_M_Y_RACRAILWORKER_01",
        "A_M_M_BIVWORKER_01",
        "A_M_M_BLWTOWNFOLK_01",
        "S_M_M_MAPWORKER_01",
        "U_M_Y_HTLWORKER_01",
        "U_M_Y_HTLWORKER_02",
        "A_M_M_ASBMINER_01",
        "A_M_Y_ASBMINER_01",
        "CS_AberdeenPigFarmer",
        "U_M_M_DORHOMESTEADHUSBAND_01",
        "A_M_M_EmRFarmHand_01",
        "U_M_M_EMRFATHER_01",
        "U_M_Y_EMRSON_01",
        "A_M_M_ValTownfolk_01",
        "A_M_M_ValFarmer_01",
        "A_M_M_ValTownfolk_02",
        "S_M_M_ValCowpoke_01",
        "A_M_M_ValLaborer_01",
        "S_M_M_LiveryWorker_01",
        "A_M_M_NBXDOCKWORKERS_01",
        "A_M_M_NBXLABORERS_01",
        "A_M_M_LagTownfolk_01",
        "A_M_M_BtcHillbilly_01",
        "A_M_O_BTCHILLBILLY_01",
        "A_M_M_VhtTownfolk_01",
        "CS_TomDickens",
        "A_M_M_STRTOWNFOLK_01",
        "A_M_M_RHDTOWNFOLK_01",
        "A_M_M_RhdForeman_01",
        "S_M_Y_Army_01",
        "A_F_M_NbxWhore_01",
        "A_F_M_VHTPROSTITUTE_01",
        "A_F_M_VALPROSTITUTE_01",
        "A_C_Cat_01",
        "A_C_CedarWaxwing_01",
        "A_C_Chipmunk_01",
        "A_C_CRAB_01",
        "A_C_Cormorant_01",
        "A_C_CarolinaParakeet_01",
        "A_C_DogCatahoulaCur_01",
        "A_C_DOGHOBO_01",
        "A_C_DOGHOUND_01",
        "A_C_DogHusky_01",
        "A_C_DOGRUFUS_01",
        "A_C_DOGBLUETICKCOONHOUND_01",
        "A_C_Donkey_01",
        "A_C_Elk_01",
        "A_C_FISHBULLHEADCAT_01_SM",
        "A_C_FISHNORTHERNPIKE_01_LG",
        "A_C_FISHRAINBOWTROUT_01_MS",
        "A_C_FISHSALMONSOCKEYE_01_MS",
        "A_C_GILAMONSTER_01",
        "A_C_Goat_01",
        "A_C_HORSE_AMERICANPAINT_GREYOVERO",
        "A_C_HORSE_AMERICANSTANDARDBRED_PALOMINODAPPLE",
        "A_C_HORSE_AMERICANSTANDARDBRED_SILVERTAILBUCKSKIN",
        "A_C_HORSE_ANDALUSIAN_DARKBAY",
        "A_C_HORSE_ANDALUSIAN_ROSEGRAY",
        "A_C_HORSE_APPALOOSA_BROWNLEOPARD",
        "A_C_HORSE_APPALOOSA_LEOPARD",
        "A_C_HORSE_ARABIAN_BLACK",
        "A_C_HORSE_ARABIAN_ROSEGREYBAY",
        "A_C_HORSE_ARDENNES_BAYROAN",
        "A_C_HORSE_ARDENNES_STRAWBERRYROAN",
        "A_C_HORSE_BELGIAN_BLONDCHESTNUT",
        "A_C_HORSE_BELGIAN_MEALYCHESTNUT",
        "A_C_HORSE_DUTCHWARMBLOOD_CHOCOLATEROAN",
        "A_C_HORSE_DUTCHWARMBLOOD_SEALBROWN",
        "A_C_HORSE_DUTCHWARMBLOOD_SOOTYBUCKSKIN",
        "A_C_HORSE_HUNGARIANHALFBRED_DARKDAPPLEGREY",
        "A_C_HORSE_HUNGARIANHALFBRED_PIEBALDTOBIANO",
        "A_C_HORSE_MISSOURIFOXTROTTER_AMBERCHAMPAGNE",
        "A_C_HORSE_MISSOURIFOXTROTTER_SILVERDAPPLEPINTO",
        "A_C_HORSE_NOKOTA_REVERSEDAPPLEROAN",
        "A_C_HORSE_SHIRE_DARKBAY",
        "A_C_HORSE_SHIRE_LIGHTGREY",
        "A_C_HORSE_SUFFOLKPUNCH_SORREL",
        "A_C_HORSE_SUFFOLKPUNCH_REDCHESTNUT",
        "A_C_HORSE_TENNESSEEWALKER_FLAXENROAN",
        "A_C_HORSE_THOROUGHBRED_BRINDLE",
        "A_C_HORSE_TURKOMAN_DARKBAY",
        "A_C_HORSE_TURKOMAN_GOLD",
        "A_C_HORSE_TURKOMAN_SILVER",
        "A_C_HORSE_GANG_BILL",
        "A_C_HORSE_GANG_CHARLES",
        "A_C_HORSE_GANG_DUTCH",
        "A_C_HORSE_GANG_HOSEA",
        "A_C_HORSE_GANG_JAVIER",
        "A_C_HORSE_GANG_JOHN",
        "A_C_HORSE_GANG_KAREN",
        "A_C_HORSE_GANG_LENNY",
        "A_C_HORSE_GANG_MICAH",
        "A_C_HORSE_GANG_SADIE",
        "A_C_HORSE_GANG_SEAN",
        "A_C_HORSE_GANG_TRELAWNEY",
        "A_C_HORSE_GANG_UNCLE",
        "A_C_HORSE_GANG_SADIE_ENDLESSSUMMER",
        "A_C_HORSE_GANG_CHARLES_ENDLESSSUMMER",
        "A_C_HORSE_GANG_UNCLE_ENDLESSSUMMER",
        "A_C_HORSE_AMERICANPAINT_OVERO",
        "A_C_HORSE_AMERICANPAINT_TOBIANO",
        "A_C_HORSE_AMERICANPAINT_SPLASHEDWHITE",
        "A_C_HORSE_AMERICANSTANDARDBRED_BLACK",
        "A_C_HORSE_AMERICANSTANDARDBRED_BUCKSKIN",
        "A_C_HORSE_APPALOOSA_BLANKET",
        "A_C_HORSE_APPALOOSA_LEOPARDBLANKET",
        "A_C_HORSE_ARABIAN_WHITE",
        "A_C_HORSE_HUNGARIANHALFBRED_FLAXENCHESTNUT",
        "A_C_HORSE_MUSTANG_GRULLODUN",
        "A_C_HORSE_MUSTANG_WILDBAY",
        "A_C_HORSE_MUSTANG_TIGERSTRIPEDBAY",
        "A_C_HORSE_NOKOTA_BLUEROAN",
        "A_C_HORSE_NOKOTA_WHITEROAN",
        "A_C_HORSE_THOROUGHBRED_BLOODBAY",
        "A_C_HORSE_THOROUGHBRED_DAPPLEGREY",
        "A_C_HorseMule_01",
        "A_C_Ox_01",
        "A_C_REDFOOTEDBOOBY_01",
        "A_C_SHARKHAMMERHEAD_01",
        "A_C_SharkTiger",
        "A_C_SHEEP_01",
        "A_C_SNAKEBLACKTAILRATTLE_01",
        "A_C_snakeferdelance_01",
        "A_C_ROSEATESPOONBILL_01",
        "A_C_TURKEY_01",
        //"A_C_WOODPECKER_02",
        "A_C_PIG_01",
        "A_C_SNAKEWATER_01",
        /*"A_C_SPARROW_01",
        "A_C_Egret_01",
        "A_C_PARROT_01",
        "A_C_PRAIRIECHICKEN_01",
        "A_C_BAT_01",
        "A_C_Heron_01",
        "A_C_Oriole_01",
        "A_C_BLUEJAY_01",
        "A_C_CARDINAL_01",
        "A_C_Duck_01",
        "A_C_PIGEON",
        "A_C_ROBIN_01",
        "A_C_SONGBIRD_01",
        "A_C_Woodpecker_01",*/
        "A_C_IGUANA_01",
        "A_C_ROOSTER_01",
        "A_C_SNAKEFERDELANCE_01",
        "A_C_Armadillo_01",
        "A_C_IGUANADESERT_01",
        "A_C_Quail_01",
        "A_C_SNAKEREDBOA_01",
        "A_C_Chicken_01",
        "A_C_FROGBULL_01",
        "A_C_SQUIRREL_01",
        "A_C_Toad_01",
        //"A_C_TURTLESNAPPING_01",
        "A_C_Bull_01",
        "A_C_Cow",
        "A_C_MUSKRAT_01",
        "A_C_RAT_01",
        "A_C_SNAKE_01",
        "A_C_Beaver_01",
        "A_C_PHEASANT_01",
        "A_C_Rabbit_01",
        "A_C_TurkeyWild_01",
        "A_C_BigHornRam_01",
        "A_C_Buck_01",
        "A_C_Buffalo_01",
        "A_C_DEER_01",
        "A_C_ELK_01",
        "A_C_MOOSE_01",
        "A_C_ProngHorn_01",
        "A_C_HORSE_MORGAN_BAY",
        "A_C_HORSE_MORGAN_BAYROAN",
        "A_C_HORSE_MORGAN_FLAXENCHESTNUT",
        "A_C_HORSE_MORGAN_PALOMINO",
        "A_C_HORSE_KENTUCKYSADDLE_BLACK",
        "A_C_HORSE_KENTUCKYSADDLE_CHESTNUTPINTO",
        "A_C_HORSE_KENTUCKYSADDLE_GREY",
        "A_C_HORSE_KENTUCKYSADDLE_SILVERBAY",
        "A_C_HORSE_TENNESSEEWALKER_BLACKRABICANO",
        "A_C_HORSE_TENNESSEEWALKER_CHESTNUT",
        "A_C_HORSE_TENNESSEEWALKER_DAPPLEBAY",
        "A_C_HORSE_TENNESSEEWALKER_REDROAN",
        "A_C_BEAR_01",
        "A_C_DOGAMERICANFOXHOUND_01",
        "A_C_DOGCOLLIE_01",
        "A_C_DogAustralianSheperd_01",
        "A_C_DogChesBayRetriever_01",
        "A_C_DogLab_01",
        "A_C_DogStreet_01",
        "A_C_DogBlueTickCoonHound_01",
        "A_C_DogHound_01",
        "A_C_TURTLESEA_01",
        "A_C_HAWK_01",
        "A_C_DUCK_01",
        "A_C_LOON_01",
        "A_C_CORMORANT_01",
        "A_C_GOOSECANADA_01",
        "A_C_HERON_01",
        "A_C_EGRET_01",
        "A_C_CraneWhooping_01",
        "A_C_PELICAN_01",
        "A_C_Badger_01",
        "A_C_BOAR_01",
        "A_C_JAVELINA_01",
        "A_C_OWL_01",
        "A_C_PANTHER_01",
        "A_C_POSSUM_01",
        "A_C_Raccoon_01",
        "A_C_SKUNK_01",
        "A_C_Alligator_01",
        "A_C_Alligator_02",
        "A_C_Alligator_03",
        "A_C_Bear_01",
        "A_C_BearBlack_01",
        "A_C_Boar_01",
        "A_C_CALIFORNIACONDOR_01",
        "A_C_Cougar_01",
        "A_C_Coyote_01",
        "A_C_Crow_01",
        "A_C_Eagle_01",
        "A_C_Fox_01",
        "A_C_Hawk_01",
        "A_C_Owl_01",
        "A_C_Panther_01",
        "A_C_RAVEN_01",
        "A_C_SEAGULL_01",
        "A_C_Vulture_01",
        "A_C_Wolf",
        "A_C_Wolf_Medium",
        "A_C_Wolf_Small",
        /*"A_C_FishMuskie_01_lg",
        "A_C_FISHLAKESTURGEON_01_LG",
        "A_C_FISHLONGNOSEGAR_01_LG",
        "A_C_FISHCHANNELCATFISH_01_LG",
        "A_C_FISHBLUEGIL_01_SM",
        "A_C_FISHPERCH_01_SM",
        "A_C_FISHCHAINPICKEREL_01_SM",
        "A_C_FISHROCKBASS_01_SM",
        "A_C_FISHREDFINPICKEREL_01_SM",
        "A_C_FISHBLUEGIL_01_MS",
        "A_C_FISHPERCH_01_MS",
        "A_C_FISHREDFINPICKEREL_01_MS",
        "A_C_FISHROCKBASS_01_MS",
        "A_C_FISHSMALLMOUTHBASS_01_MS",
        "A_C_FISHBULLHEADCAT_01_MS",
        "A_C_FISHLARGEMOUTHBASS_01_MS",*/
        };
    }
}
