using System;
using static System.Console;

class RaceMaker
{
    static void Main()
    {
//                                                                                                   Main Tracks
//   =============================================================================================================================================================================================================
//         Track Object Names     ||  Track ID #  ||     Cup     || Secondary Cup ||     Track Name       ||       Region       || Is Intermission Track? ||               Connecting Tracks
//   -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track Acorn_Heights        = new Track(  1,  "Special"   ,       ""       , "Acorn Heights"       , "Forest"            ,         false           , new int[] {  2,  3,  4,  5,  6                });
        Track Dry_Bones_Burnout    = new Track(  2,  "Leaf"      ,       ""       , "Dry Bones Burnout"   , "Volcano"           ,         false           , new int[] {  1,  3,  4,  7                    });
        Track Toads_Factory        = new Track(  3,  "Lightning" ,       ""       , "Toad's Factory"      , "Volcano"           ,         false           , new int[] {  1,  2,  4,  5,  7, 8, 12, 15, 20 });
        Track SNES_Mario_Circuit_5 = new Track(  4,  "Special"   ,       ""       , "SNES Mario Circuit 5", "Forest"            ,         false           , new int[] {  1,  2,  3,  9, 12                });
        Track Dandelion_Depths     = new Track(  5,  "Leaf"      ,       ""       , "Dandelion Depths"    , "Dandelion Depths"  ,         false           , new int[] {  1,  3, 10, 12, 16                });
        Track Boo_Cinema           = new Track(  6,  "Leaf"      ,       ""       , "Boo Cinema"          , "Forest"            ,         false           , new int[] {  1,  9                            });
        Track Bowsers_Castle       = new Track(  7,  "Lightning" ,       ""       , "Bowser's Castle"     , "Volcano"           ,         false           , new int[] {  2,  3,  8, 13                    });
        Track Airship_Fortress     = new Track(  8,  "Flower"    ,       ""       , "Airship Fortress"    , "Volcano"           ,         false           , new int[] {  3,  7, 13, 14                    });
        Track Starview_Peak        = new Track(  9,  "Star"      ,       ""       , "Starview Peak"       , "Starview Peak"     ,         false           , new int[] {  4,  6, 10, 11, 16                });
        Track Sky_High_Sundae      = new Track( 10,  "Star"      ,       ""       , "Sky-High Sundae"     , "Starview Peak"     ,         false           , new int[] {  5,  9, 11, 17                    });
        Track DK_Pass              = new Track( 11,  "Star"      ,       ""       , "DK Pass"             , "Starview Peak"     ,         false           , new int[] {  9, 10, 16, 17, 18                });
        Track Moo_Moo_Meadows      = new Track( 12,  "Lightning" ,       ""       , "Moo Moo Meadows"     , "Central"           ,         false           , new int[] {  3,  4,  5, 15, 16, 19            });
        Track Wario_Stadium        = new Track( 13,  "Flower"    ,       ""       , "Wario Stadium"       , "Badlands"          ,         false           , new int[] {  7,  8, 14, 20, 22                });
        Track Shy_Guy_Bazaar       = new Track( 14,  "Flower"    ,       ""       , "Shy Guy Bazaar"      , "Desert"            ,         false           , new int[] {  8, 13, 15, 21                    });
        Track Choco_Mountain       = new Track( 15,  "Lightning" ,       ""       , "Choco Mountain"      , "Central"           ,         false           , new int[] {  3, 12, 14, 16, 19, 22            });
        Track Cheep_Cheep_Falls    = new Track( 16,  "Leaf"      ,       ""       , "Cheep Cheep Falls"   , "Cheep Cheep Falls" ,         false           , new int[] {  5,  9, 11, 12, 15, 17, 19, 24    });
        Track Warios_Galleon       = new Track( 17,  "Star"      ,       ""       , "Wario's Galleon"     , "Eastern Coast"     ,         false           , new int[] { 10, 11, 16, 25                    });
        Track Salty_Salty_Speedway = new Track( 18,  "Banana"    ,       ""       , "Salty Salty Speedway", "Eastern Coast"     ,         false           , new int[] { 11, 24, 25, 26, 27                });
        Track Peach_Stadium        = new Track( 19,  "Special"   ,     "Shell"    , "Peach Stadium"       , "Central"           ,         false           , new int[] { 12, 15, 16, 22, 23, 24            });
        Track Mario_Bros_Circuit   = new Track( 20,  "Mushroom"  ,       ""       , "Mario Bros. Circuit" , "Badlands"          ,         false           , new int[] {  3, 13, 21, 29, 30                });
        Track Desert_Hills         = new Track( 21,  "Flower"    ,       ""       , "Desert Hills"        , "Desert"            ,         false           , new int[] { 14, 20, 22, 30                    });
        Track Crown_City           = new Track( 22,  "Mushroom"  ,     "Shell"    , "Crown City"          , "Southern Coast"    ,         false           , new int[] { 13, 15, 19, 21, 23, 29            });
        Track Rainbow_Road         = new Track( 23,  "Special"   ,       ""       , "Rainbow Road"        , "Southern Coast"    ,         false           , new int[] { 19, 22, 24, 28                    });
        Track Faraway_Oasis        = new Track( 24,  "Shell"     ,       ""       , "Faraway Oasis"       , "Faraway Oasis"     ,         false           , new int[] { 16, 18, 19, 23, 26, 27, 28        });
        Track Peach_Beach          = new Track( 25,  "Banana"    ,       ""       , "Peach Beach"         , "Eastern Coast"     ,         false           , new int[] { 17, 18, 26                        });
        Track Great_Block_Ruins    = new Track( 26,  "Banana"    ,       ""       , "Great ? Block Ruins" , "Jungle"            ,         false           , new int[] { 18, 24, 25, 27                    });
        Track Dino_Dino_Jungle     = new Track( 27,  "Banana"    ,       ""       , "Dino Dino Jungle"    , "Jungle"            ,         false           , new int[] { 18, 24, 26, 28                    });
        Track Koopa_Troopa_Beach   = new Track( 28,  "Shell"     ,       ""       , "Koopa Troopa Beach"  , "Southern Coast"    ,         false           , new int[] { 23, 24, 27, 29                    });
        Track DK_Spaceport         = new Track( 29,  "Mushroom"  ,       ""       , "DK Spaceport"        , "Southern Coast"    ,         false           , new int[] { 20, 22, 28, 30                    });
        Track Whistletop_Summit    = new Track( 30,  "Mushroom"  ,       ""       , "Whistletop Summit"   , "Badlands"          ,         false           , new int[] { 20, 21, 29                        });
//   -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
//                                                                                                Intermission Tracks
//   =============================================================================================================================================================================================================================
//                 Track Object Names              ||   Track ID #  ||      Cup      || Secondary Cup ||                Track Name                    ||       Region       || Is Intermission Track? || Connecting Tracks
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track AcornHeights_to_DryBonesBurnout       = new Track(  31, "Intermission" ,        ""      , "Acorn Heights to Dry Bones Burnout"          ,      "Transfer"     ,            true         , new int[] {  1,  2  });
        Track AcornHeights_to_ToadsFactory          = new Track(  32, "Intermission" ,        ""      , "Acorn Heights to Toad's Factory"             ,      "Transfer"     ,            true         , new int[] {  1,  3  });
        Track AcornHeights_to_SNESMarioCircuit5     = new Track(  33, "Intermission" ,        ""      , "Acorn Heights to SNES Mario Circuit 5"       ,      "Transfer"     ,            true         , new int[] {  1,  4  });
        Track AcornHeights_to_DandelionDepths       = new Track(  34, "Intermission" ,        ""      , "Acorn Heights to Dandelion Depths"           ,      "Transfer"     ,            true         , new int[] {  1,  5  });
        Track AcornHeights_to_BooCinema             = new Track(  35, "Intermission" ,        ""      , "Acorn Heights to Boo Cinema"                 ,      "Transfer"     ,            true         , new int[] {  1,  6  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------      
        Track BowsersCastle_to_DryBonesBurnout      = new Track(  36, "Intermission" ,        ""      , "Bowser's Castle to Dry Bones Burnout"        ,      "Transfer"     ,            true         , new int[] {  7,  2  });
        Track BowsersCastle_to_ToadsFactory         = new Track(  37, "Intermission" ,        ""      , "Bowser's Castle to Toad's Factory"           ,      "Transfer"     ,            true         , new int[] {  7,  3  });
        Track BowsersCastle_to_WarioStadium         = new Track(  38, "Intermission" ,        ""      , "Bowser's Castle to Wario Stadium"            ,      "Transfer"     ,            true         , new int[] {  7, 13  });
        Track BowsersCastle_to_AirshipFortress      = new Track(  39, "Intermission" ,        ""      , "Bowser's Castle to Airship Fortress"         ,      "Transfer"     ,            true         , new int[] {  7,  8  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DryBonesBurnout_to_BowsersCastle      = new Track(  40, "Intermission" ,        ""      , "Dry Bones Burnout to Bowser's Castle"        ,      "Transfer"     ,            true         , new int[] {  2,  7  });
        Track DryBonesBurnout_to_ToadsFactory       = new Track(  41, "Intermission" ,        ""      , "Dry Bones Burnout to Toad's Factory"         ,      "Transfer"     ,            true         , new int[] {  2,  3  });
        Track DryBonesBurnout_to_SNESMarioCircuit5  = new Track(  42, "Intermission" ,        ""      , "Dry Bones Burnout to SNES Mario Circuit 5"   ,      "Transfer"     ,            true         , new int[] {  2,  4  });
        Track DryBonesBurnout_to_AcornHeights       = new Track(  43, "Intermission" ,        ""      , "Dry Bones Burnout to Acorn Heights"          ,      "Transfer"     ,            true         , new int[] {  2,  1  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track BooCinema_to_AcornHeights             = new Track(  44, "Intermission" ,        ""      , "Boo Cinema to Acorn Heights"                 ,      "Transfer"     ,            true         , new int[] {  6,  1  });
        Track BooCinema_to_StarviewPeak             = new Track(  45, "Intermission" ,        ""      , "Boo Cinema to Starview Peak"                 ,      "Transfer"     ,            true         , new int[] {  6,  9  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track SNESMarioCircuit5_to_AcornHeights     = new Track(  46, "Intermission" ,        ""      , "SNES Mario Circuit 5 to Acorn Heights"       ,      "Transfer"     ,            true         , new int[] {  4,  1  });
        Track SNESMarioCircuit5_to_StarviewPeak     = new Track(  47, "Intermission" ,        ""      , "SNES Mario Circuit 5 to Starview Peak"       ,      "Transfer"     ,            true         , new int[] {  4,  9  });
        Track SNESMarioCircuit5_to_MooMooMeadows    = new Track(  48, "Intermission" ,        ""      , "SNES Mario Circuit 5 to Moo Moo Meadows"     ,      "Transfer"     ,            true         , new int[] {  4, 12  });
        Track SNESMarioCircuit5_to_ToadsFactory     = new Track(  49, "Intermission" ,        ""      , "SNES Mario Circuit 5 to Toad's Factory"      ,      "Transfer"     ,            true         , new int[] {  4,  3  });
        Track SNESMarioCircuit5_to_DryBonesBurnout  = new Track(  50, "Intermission" ,        ""      , "SNES Mario Circuit 5 to Dry Bones Burnout"   ,      "Transfer"     ,            true         , new int[] {  4,  2  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track StarviewPeak_to_BooCinema             = new Track(  51, "Intermission" ,        ""      , "Starview Peak to Boo Cinema"                 ,      "Transfer"     ,            true         , new int[] {  9,  6  });
        Track StarviewPeak_to_SNESMarioCircuit5     = new Track(  52, "Intermission" ,        ""      , "Starview Peak to SNES Mario Circuit 5"       ,      "Transfer"     ,            true         , new int[] {  9,  4  });
        Track StarviewPeak_to_CheepCheepFalls       = new Track(  53, "Intermission" ,        ""      , "Starview Peak to Cheep Cheep Falls"          ,      "Transfer"     ,            true         , new int[] {  9, 16  });
        Track StarviewPeak_to_DKPass                = new Track(  54, "Intermission" ,        ""      , "Starview Peak to DK Pass"                    ,      "Transfer"     ,            true         , new int[] {  9, 11  });
        Track StarviewPeak_to_SkyHighSundae         = new Track(  55, "Intermission" ,        ""      , "Starview Peak to Sky High Sundae"            ,      "Transfer"     ,            true         , new int[] {  9, 10  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track AirshipFortress_to_BowsersCastle      = new Track(  56, "Intermission" ,        ""      , "Airship Fortress to Bowser's Castle"         ,      "Transfer"     ,            true         , new int[] {  8,  7  });
        Track AirshipFortress_to_ToadsFactory       = new Track(  57, "Intermission" ,        ""      , "Airship Fortress to Toad's Factory"          ,      "Transfer"     ,            true         , new int[] {  8,  3  });
        Track AirshipFortress_to_WarioStadium       = new Track(  58, "Intermission" ,        ""      , "Airship Fortress to Wario Stadium"           ,      "Transfer"     ,            true         , new int[] {  8, 13  });
        Track AirshipFortress_to_ShyGuyBazaar       = new Track(  59, "Intermission" ,        ""      , "Airship Fortress to Shy Guy Bazaar"          ,      "Transfer"     ,            true         , new int[] {  8, 14  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track ToadsFactory_to_DryBonesBurnout       = new Track(  60, "Intermission" ,        ""      , "Toad's Factory to Dry Bones Burnout"         ,      "Transfer"     ,            true         , new int[] {  3,  2  });
        Track ToadsFactory_to_AcornHeights          = new Track(  61, "Intermission" ,        ""      , "Toad's Factory to Acorn Heights"             ,      "Transfer"     ,            true         , new int[] {  3,  1  });
        Track ToadsFactory_to_SNESMarioCircuit5     = new Track(  62, "Intermission" ,        ""      , "Toad's Factory to SNES Mario Circuit 5"      ,      "Transfer"     ,            true         , new int[] {  3,  4  });
        Track ToadsFactory_to_DandelionDepths       = new Track(  63, "Intermission" ,        ""      , "Toad's Factory to Dandelion Depths"          ,      "Transfer"     ,            true         , new int[] {  3,  5  });
        Track ToadsFactory_to_MooMooMeadows         = new Track(  64, "Intermission" ,        ""      , "Toad's Factory to Moo Moo Meadows"           ,      "Transfer"     ,            true         , new int[] {  3, 12  });
        Track ToadsFactory_to_ChocoMountain         = new Track(  65, "Intermission" ,        ""      , "Toad's Factory to Choco Mountain"            ,      "Transfer"     ,            true         , new int[] {  3, 15  });
        Track ToadsFactory_to_MarioBrosCircuit      = new Track(  66, "Intermission" ,        ""      , "Toad's Factory to Mario Bros. Circuit"       ,      "Transfer"     ,            true         , new int[] {  3, 20  });
        Track ToadsFactory_to_AirshipFortress       = new Track(  67, "Intermission" ,        ""      , "Toad's Factory to Airship Fortress"          ,      "Transfer"     ,            true         , new int[] {  3,  8  });
        Track ToadsFactory_to_BowsersCastle         = new Track(  68, "Intermission" ,        ""      , "Toad's Factory to Bowser's Castle"           ,      "Transfer"     ,            true         , new int[] {  3,  7  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DandelionDepths_to_AcornHeights       = new Track(  69, "Intermission" ,        ""      , "Dandelion Depths to Acorn Heights"           ,      "Transfer"     ,            true         , new int[] {  5,  1  });
        Track DandelionDepths_to_SkyHighSundae      = new Track(  70, "Intermission" ,        ""      , "Dandelion Depths to Sky High Sundae"         ,      "Transfer"     ,            true         , new int[] {  5, 10  });
        Track DandelionDepths_to_CheepCheepFalls    = new Track(  71, "Intermission" ,        ""      , "Dandelion Depths to Cheep Cheep Falls"       ,      "Transfer"     ,            true         , new int[] {  5, 16  });
        Track DandelionDepths_to_MooMooMeadows      = new Track(  72, "Intermission" ,        ""      , "Dandelion Depths to Moo Moo Meadows"         ,      "Transfer"     ,            true         , new int[] {  5, 12  });
        Track DandelionDepths_to_ToadsFactory       = new Track(  73, "Intermission" ,        ""      , "Dandelion Depths to Toad's Factory"          ,      "Transfer"     ,            true         , new int[] {  5,  3  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track SkyHighSundae_to_StarviewPeak         = new Track(  74, "Intermission" ,        ""      , "Sky High Sundae to Starview Peak"            ,      "Transfer"     ,            true         , new int[] { 10,  9  });
        Track SkyHighSundae_to_DandelionDepths      = new Track(  75, "Intermission" ,        ""      , "Sky High Sundae to Dandelion Depths"         ,      "Transfer"     ,            true         , new int[] { 10,  5  });
        Track SkyHighSundae_to_DKPass               = new Track(  76, "Intermission" ,        ""      , "Sky High Sundae to DK Pass"                  ,      "Transfer"     ,            true         , new int[] { 10, 11  });
        Track SkyHighSundae_to_WariosGalleon        = new Track(  77, "Intermission" ,        ""      , "Sky High Sundae to Wario's Galleon"          ,      "Transfer"     ,            true         , new int[] { 10, 17  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track ShyGuyBazaar_to_AirshipFortress       = new Track(  78, "Intermission" ,        ""      , "Shy Guy Bazaar to Airship Fortress"          ,      "Transfer"     ,            true         , new int[] { 14,  8  });
        Track ShyGuyBazaar_to_WarioStadium          = new Track(  79, "Intermission" ,        ""      , "Shy Guy Bazaar to Wario Stadium"             ,      "Transfer"     ,            true         , new int[] { 14, 13  });
        Track ShyGuyBazaar_to_ChocoMountain         = new Track(  80, "Intermission" ,        ""      , "Shy Guy Bazaar to Choco Mountain"            ,      "Transfer"     ,            true         , new int[] { 14, 15  });
        Track ShyGuyBazaar_to_DesertHills           = new Track(  81, "Intermission" ,        ""      , "Shy Guy Bazaar to Desert Hills"              ,      "Transfer"     ,            true         , new int[] { 14, 21  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track WarioStadium_to_BowsersCastle         = new Track(  82, "Intermission" ,        ""      , "Wario Stadium to Bowser's Castle"            ,      "Transfer"     ,            true         , new int[] { 13,  7  });
        Track WarioStadium_to_AirshipFortress       = new Track(  83, "Intermission" ,        ""      , "Wario Stadium to Airship Fortress"           ,      "Transfer"     ,            true         , new int[] { 13,  8  });
        Track WarioStadium_to_ShyGuyBazaar          = new Track(  84, "Intermission" ,        ""      , "Wario Stadium to Shy Guy Bazaar"             ,      "Transfer"     ,            true         , new int[] { 13, 14  });
        Track WarioStadium_to_MarioBrosCircuit      = new Track(  85, "Intermission" ,        ""      , "Wario Stadium to Mario Bros. Circuit"        ,      "Transfer"     ,            true         , new int[] { 13, 20  });
        Track WarioStadium_to_CrownCity             = new Track(  86, "Intermission" ,        ""      , "Wario Stadium to Crown City"                 ,      "Transfer"     ,            true         , new int[] { 13, 22  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track ChocoMountain_to_ToadsFactory         = new Track(  87, "Intermission" ,        ""      , "Choco Mountain to Toad's Factory"            ,      "Transfer"     ,            true         , new int[] { 15,  3  });
        Track ChocoMountain_to_MooMooMeadows        = new Track(  88, "Intermission" ,        ""      , "Choco Mountain to Moo Moo Meadows"           ,      "Transfer"     ,            true         , new int[] { 15, 12  });
        Track ChocoMountain_to_CheepCheepFalls      = new Track(  89, "Intermission" ,        ""      , "Choco Mountain to Cheep Cheep Falls"         ,      "Transfer"     ,            true         , new int[] { 15, 16  });
        Track ChocoMountain_to_PeachStadium         = new Track(  90, "Intermission" ,        ""      , "Choco Mountain to Peach Stadium"             ,      "Transfer"     ,            true         , new int[] { 15, 19  });
        Track ChocoMountain_to_CrownCity            = new Track(  91, "Intermission" ,        ""      , "Choco Mountain to Crown City"                ,      "Transfer"     ,            true         , new int[] { 15, 22  });
        Track ChocoMountain_to_ShyGuyBazaar         = new Track(  92, "Intermission" ,        ""      , "Choco Mountain to Shy Guy Bazaar"            ,      "Transfer"     ,            true         , new int[] { 15, 14  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track MooMooMeadows_to_SNESMarioCircuit5    = new Track(  93, "Intermission" ,        ""      , "Moo Moo Meadows to SNES Mario Circuit 5"     ,      "Transfer"     ,            true         , new int[] { 12,  4  });
        Track MooMooMeadows_to_DandelionDepths      = new Track(  94, "Intermission" ,        ""      , "Moo Moo Meadows to Dandelion Depths"         ,      "Transfer"     ,            true         , new int[] { 12,  5  });
        Track MooMooMeadows_to_CheepCheepFalls      = new Track(  95, "Intermission" ,        ""      , "Moo Moo Meadows to Cheep Cheep Falls"        ,      "Transfer"     ,            true         , new int[] { 12, 16  });
        Track MooMooMeadows_to_PeachStadium         = new Track(  96, "Intermission" ,        ""      , "Moo Moo Meadows to Peach Stadium"            ,      "Transfer"     ,            true         , new int[] { 12, 19  });
        Track MooMooMeadows_to_ChocoMountain        = new Track(  97, "Intermission" ,        ""      , "Moo Moo Meadows to Choco Mountain"           ,      "Transfer"     ,            true         , new int[] { 12, 15  });
        Track MooMooMeadows_to_ToadsFactory         = new Track(  98, "Intermission" ,        ""      , "Moo Moo Meadows to Toad's Factory"           ,      "Transfer"     ,            true         , new int[] { 12,  3  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track CheepCheepFalls_to_DandelionDepths    = new Track(  99, "Intermission" ,        ""      , "Cheep Cheep Falls to Dandelion Depths"       ,      "Transfer"     ,            true         , new int[] { 16,  5  });
        Track CheepCheepFalls_to_StarviewPeak       = new Track( 100, "Intermission" ,        ""      , "Cheep Cheep Falls to Starview Peak"          ,      "Transfer"     ,            true         , new int[] { 16,  9  });
        Track CheepCheepFalls_to_DKPass             = new Track( 101, "Intermission" ,        ""      , "Cheep Cheep Falls to DK Pass"                ,      "Transfer"     ,            true         , new int[] { 16, 11  });
        Track CheepCheepFalls_to_WariosGalleon      = new Track( 102, "Intermission" ,        ""      , "Cheep Cheep Falls to Wario's Galleon"        ,      "Transfer"     ,            true         , new int[] { 16, 17  });
        Track CheepCheepFalls_to_FarawayOasis       = new Track( 103, "Intermission" ,        ""      , "Cheep Cheep Falls to Faraway Oasis"          ,      "Transfer"     ,            true         , new int[] { 16, 24  });
        Track CheepCheepFalls_to_PeachStadium       = new Track( 104, "Intermission" ,        ""      , "Cheep Cheep Falls to Peach Stadium"          ,      "Transfer"     ,            true         , new int[] { 16, 19  });
        Track CheepCheepFalls_to_ChocoMountain      = new Track( 105, "Intermission" ,        ""      , "Cheep Cheep Falls to Choco Mountain"         ,      "Transfer"     ,            true         , new int[] { 16, 15  });
        Track CheepCheepFalls_to_MooMooMeadows      = new Track( 106, "Intermission" ,        ""      , "Cheep Cheep Falls to Moo Moo Meadows"        ,      "Transfer"     ,            true         , new int[] { 16, 12  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DKPass_to_StarviewPeak                = new Track( 107, "Intermission" ,        ""      , "DK Pass to Starview Peak"                    ,      "Transfer"     ,            true         , new int[] { 11,  9  });
        Track DKPass_to_SkyHighSundae               = new Track( 108, "Intermission" ,        ""      , "DK Pass to Sky High Sundae"                  ,      "Transfer"     ,            true         , new int[] { 11, 10  });
        Track DKPass_to_WariosGalleon               = new Track( 109, "Intermission" ,        ""      , "DK Pass to Wario's Galleon"                  ,      "Transfer"     ,            true         , new int[] { 11, 17  });
        Track DKPass_to_SaltySaltySpeedway          = new Track( 110, "Intermission" ,        ""      , "DK Pass to Salty Salty Speedway"             ,      "Transfer"     ,            true         , new int[] { 11, 18  });
        Track DKPass_to_CheepCheepFalls             = new Track( 111, "Intermission" ,        ""      , "DK Pass to Cheep Cheep Falls"                ,      "Transfer"     ,            true         , new int[] { 11, 16  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track WariosGalleon_to_SkyHighSundae        = new Track( 112, "Intermission" ,        ""      , "Wario's Galleon to Sky High Sundae"          ,      "Transfer"     ,            true         , new int[] { 17, 10  });
        Track WariosGalleon_to_DKPass               = new Track( 113, "Intermission" ,        ""      , "Wario's Galleon to DK Pass"                  ,      "Transfer"     ,            true         , new int[] { 17, 11  });
        Track WariosGalleon_to_CheepCheepFalls      = new Track( 114, "Intermission" ,        ""      , "Wario's Galleon to Cheep Cheep Falls"        ,      "Transfer"     ,            true         , new int[] { 17, 16  });
        Track WariosGalleon_to_PeachBeach           = new Track( 115, "Intermission" ,        ""      , "Wario's Galleon to Peach Beach"              ,      "Transfer"     ,            true         , new int[] { 17, 25  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track MarioBrosCircuit_to_WarioStadium      = new Track( 116, "Intermission" ,        ""      , "Mario Bros. Circuit to Wario Stadium"        ,      "Transfer"     ,            true         , new int[] { 20, 13  });
        Track MarioBrosCircuit_to_ToadsFactory      = new Track( 117, "Intermission" ,        ""      , "Mario Bros. Circuit to Toad's Factory"       ,      "Transfer"     ,            true         , new int[] { 20,  3  });
        Track MarioBrosCircuit_to_DKSpaceport       = new Track( 118, "Intermission" ,        ""      , "Mario Bros. Circuit to DK Spaceport"         ,      "Transfer"     ,            true         , new int[] { 20, 29  });
        Track MarioBrosCircuit_to_WhistletopSummit  = new Track( 119, "Intermission" ,        ""      , "Mario Bros. Circuit to Whistletop Summit"    ,      "Transfer"     ,            true         , new int[] { 20, 30  });
        Track MarioBrosCircuit_to_DesertHills       = new Track( 120, "Intermission" ,        ""      , "Mario Bros. Circuit to Desert Hills"         ,      "Transfer"     ,            true         , new int[] { 20, 21  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track PeachStadium_to_MooMooMeadows         = new Track( 121, "Intermission" ,        ""      , "Peach Stadium to Moo Moo Meadows"            ,      "Transfer"     ,            true         , new int[] { 19, 12  });
        Track PeachStadium_to_CheepCheepFalls       = new Track( 122, "Intermission" ,        ""      , "Peach Stadium to Cheep Cheep Falls"          ,      "Transfer"     ,            true         , new int[] { 19, 16  });
        Track PeachStadium_to_FarawayOasis          = new Track( 123, "Intermission" ,        ""      , "Peach Stadium to Faraway Oasis"              ,      "Transfer"     ,            true         , new int[] { 19, 24  });
        Track PeachStadium_to_RainbowRoad           = new Track( 124, "Intermission" ,        ""      , "Peach Stadium to Rainbow Road"               ,      "Transfer"     ,            true         , new int[] { 19, 23  });
        Track PeachStadium_to_CrownCity             = new Track( 125, "Intermission" ,        ""      , "Peach Stadium to Crown City"                 ,      "Transfer"     ,            true         , new int[] { 19, 22  });
        Track PeachStadium_to_ChocoMountain         = new Track( 126, "Intermission" ,        ""      , "Peach Stadium to Choco Mountain"             ,      "Transfer"     ,            true         , new int[] { 19, 15  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track SaltySaltySpeedway_to_DKPass          = new Track( 127, "Intermission" ,        ""      , "Salty Salty Speedway to DK Pass"             ,      "Transfer"     ,            true         , new int[] { 18, 11  });
        Track SaltySaltySpeedway_to_PeachBeach      = new Track( 128, "Intermission" ,        ""      , "Salty Salty Speedway to Peach Beach"         ,      "Transfer"     ,            true         , new int[] { 18, 25  });
        Track SaltySaltySpeedway_to_GreatBlockRuins = new Track( 129, "Intermission" ,        ""      , "Salty Salty Speedway to Great ? Block Ruins" ,      "Transfer"     ,            true         , new int[] { 18, 26  });
        Track SaltySaltySpeedway_to_DinoDinoJungle  = new Track( 130, "Intermission" ,        ""      , "Salty Salty Speedway to Dino Dino Jungle"    ,      "Transfer"     ,            true         , new int[] { 18, 27  });
        Track SaltySaltySpeedway_to_FarawayOasis    = new Track( 131, "Intermission" ,        ""      , "Salty Salty Speedway to Faraway Oasis"       ,      "Transfer"     ,            true         , new int[] { 18, 24  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DesertHills_to_ShyGuyBazaar           = new Track( 132, "Intermission" ,        ""      , "Desert Hills to Shy Guy Bazaar"              ,      "Transfer"     ,            true         , new int[] { 21, 14  });
        Track DesertHills_to_MarioBrosCircuit       = new Track( 133, "Intermission" ,        ""      , "Desert Hills to Mario Bros Circuit"          ,      "Transfer"     ,            true         , new int[] { 21, 20  });
        Track DesertHills_to_CrownCity              = new Track( 134, "Intermission" ,        ""      , "Desert Hills to Crown City"                  ,      "Transfer"     ,            true         , new int[] { 21, 22  });
        Track DesertHills_to_WhistletopSummit       = new Track( 135, "Intermission" ,        ""      , "Desert Hills to Whistletop Summit"           ,      "Transfer"     ,            true         , new int[] { 21, 30  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track CrownCity_to_WarioStadium             = new Track( 136, "Intermission" ,        ""      , "Crown City to Wario Stadium"                 ,      "Transfer"     ,            true         , new int[] { 22, 13  });
        Track CrownCity_to_ChocoMountain            = new Track( 137, "Intermission" ,        ""      , "Crown City to Choco Mountain"                ,      "Transfer"     ,            true         , new int[] { 22, 15  });
        Track CrownCity_to_PeachStadium             = new Track( 138, "Intermission" ,        ""      , "Crown City to Peach Stadium"                 ,      "Transfer"     ,            true         , new int[] { 22, 19  });
        Track CrownCity_to_RainbowRoad              = new Track( 139, "Intermission" ,        ""      , "Crown City to Rainbow Road"                  ,      "Transfer"     ,            true         , new int[] { 22, 23  });
        Track CrownCity_to_DKSpaceport              = new Track( 140, "Intermission" ,        ""      , "Crown City to DK Spaceport"                  ,      "Transfer"     ,            true         , new int[] { 22, 29  });
        Track CrownCity_to_DesertHills              = new Track( 141, "Intermission" ,        ""      , "Crown City to Desert Hills"                  ,      "Transfer"     ,            true         , new int[] { 22, 21  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track RainbowRoad_to_PeachStadium           = new Track( 142, "Intermission" ,        ""      , "Rainbow Road to Peach Stadium"               ,      "Transfer"     ,            true         , new int[] { 23, 19  });
        Track RainbowRoad_to_FarawayOasis           = new Track( 143, "Intermission" ,        ""      , "Rainbow Road to Faraway Oasis"               ,      "Transfer"     ,            true         , new int[] { 23, 24  });
        Track RainbowRoad_to_KoopaTroopaBeach       = new Track( 144, "Intermission" ,        ""      , "Rainbow Road to Koopa Troopa Beach"          ,      "Transfer"     ,            true         , new int[] { 23, 28  });
        Track RainbowRoad_to_CrownCity              = new Track( 145, "Intermission" ,        ""      , "Rainbow Road to Crown City"                  ,      "Transfer"     ,            true         , new int[] { 23, 22  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track FarawayOasis_to_CheepCheepFalls       = new Track( 146, "Intermission" ,        ""      , "Faraway Oasis to Cheep Cheep Falls"          ,      "Transfer"     ,            true         , new int[] { 24, 16  });
        Track FarawayOasis_to_SaltySaltySpeedway    = new Track( 147, "Intermission" ,        ""      , "Faraway Oasis to Salty Salty Speedway"       ,      "Transfer"     ,            true         , new int[] { 24, 18  });
        Track FarawayOasis_to_GreatBlockRuins       = new Track( 148, "Intermission" ,        ""      , "Faraway Oasis to Great ? Block Ruins"        ,      "Transfer"     ,            true         , new int[] { 24, 26  });
        Track FarawayOasis_to_DinoDinoJungle        = new Track( 149, "Intermission" ,        ""      , "Faraway Oasis to Dino Dino Jungle"           ,      "Transfer"     ,            true         , new int[] { 24, 27  });
        Track FarawayOasis_to_KoopaTroopaBeach      = new Track( 150, "Intermission" ,        ""      , "Faraway Oasis to Koopa Troopa Beach"         ,      "Transfer"     ,            true         , new int[] { 24, 28  });
        Track FarawayOasis_to_RainbowRoad           = new Track( 151, "Intermission" ,        ""      , "Faraway Oasis to Rainbow Road"               ,      "Transfer"     ,            true         , new int[] { 24, 23  });
        Track FarawayOasis_to_PeachStadium          = new Track( 152, "Intermission" ,        ""      , "Faraway Oasis to Peach Stadium"              ,      "Transfer"     ,            true         , new int[] { 24, 19  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track PeachBeach_to_WariosGalleon           = new Track( 153, "Intermission" ,        ""      , "Peach Beach to Wario's Galleon"              ,      "Transfer"     ,            true         , new int[] { 25, 17  });
        Track PeachBeach_to_SaltySaltySpeedway      = new Track( 154, "Intermission" ,        ""      , "Peach Beach to Salty Salty Speedway"         ,      "Transfer"     ,            true         , new int[] { 25, 18  });
        Track PeachBeach_to_GreatBlockRuins         = new Track( 155, "Intermission" ,        ""      , "Peach Beach to Great ? Block Ruins"          ,      "Transfer"     ,            true         , new int[] { 25, 26  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track WhistletopSummit_to_DesertHills       = new Track( 156, "Intermission" ,        ""      , "Whistletop Summit to Desert Hills"           ,      "Transfer"     ,            true         , new int[] { 30, 21  });
        Track WhistletopSummit_to_MarioBrosCircuit  = new Track( 157, "Intermission" ,        ""      , "Whistletop Summit to Mario Bros. Circuit"    ,      "Transfer"     ,            true         , new int[] { 30, 20  });
        Track WhistletopSummit_to_DKSpaceport       = new Track( 158, "Intermission" ,        ""      , "Whistletop Summit to DK Spaceport"           ,      "Transfer"     ,            true         , new int[] { 30, 29  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DKSpaceport_to_WhistletopSummit       = new Track( 159, "Intermission" ,        ""      , "DK Spaceport to Whistletop Summit"           ,      "Transfer"     ,            true         , new int[] { 29, 30  });
        Track DKSpaceport_to_MarioBrosCircuit       = new Track( 160, "Intermission" ,        ""      , "DK Spaceport to Mario Bros. Circuit"         ,      "Transfer"     ,            true         , new int[] { 29, 20  });
        Track DKSpaceport_to_CrownCity              = new Track( 161, "Intermission" ,        ""      , "DK Spaceport to Crown City"                  ,      "Transfer"     ,            true         , new int[] { 29, 22  });
        Track DKSpaceport_to_KoopaTroopaBeach       = new Track( 162, "Intermission" ,        ""      , "DK Spaceport to Koopa Troopa Beach"          ,      "Transfer"     ,            true         , new int[] { 29, 28  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track KoopaTroopaBeach_to_DKSpaceport       = new Track( 163, "Intermission" ,        ""      , "Koopa Troopa Beach to DK Spaceport"          ,      "Transfer"     ,            true         , new int[] { 28, 29  });
        Track KoopaTroopaBeach_to_RainbowRoad       = new Track( 164, "Intermission" ,        ""      , "Koopa Troopa Beach to Rainbow Road"          ,      "Transfer"     ,            true         , new int[] { 28, 23  });
        Track KoopaTroopaBeach_to_FarawayOasis      = new Track( 165, "Intermission" ,        ""      , "Koopa Troopa Beach to Faraway Oasis"         ,      "Transfer"     ,            true         , new int[] { 28, 24  });
        Track KoopaTroopaBeach_to_DinoDinoJungle    = new Track( 166, "Intermission" ,        ""      , "Koopa Troopa Beach to Dino Dino Jungle"      ,      "Transfer"     ,            true         , new int[] { 28, 27  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track DinoDinoJungle_to_KoopaTroopaBeach    = new Track( 167, "Intermission" ,        ""      , "Dino Dino Jungle to Koopa Troopa Beach"      ,      "Transfer"     ,            true         , new int[] { 27, 28  });
        Track DinoDinoJungle_to_FarawayOasis        = new Track( 168, "Intermission" ,        ""      , "Dino Dino Jungle to Faraway Oasis"           ,      "Transfer"     ,            true         , new int[] { 27, 24  });
        Track DinoDinoJungle_to_SaltySaltySpeedway  = new Track( 169, "Intermission" ,        ""      , "Dino Dino Jungle to Salty Salty Speedway"    ,      "Transfer"     ,            true         , new int[] { 27, 18  });
        Track DinoDinoJungle_to_GreatBlockRuins     = new Track( 170, "Intermission" ,        ""      , "Dino Dino Jungle to Great ? Block Ruins"     ,      "Transfer"     ,            true         , new int[] { 27, 26  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Track GreatBlockRuins_to_DinoDinoJungle     = new Track( 171, "Intermission" ,        ""      , "Great ? Block Ruins to Dino Dino Jungle"     ,      "Transfer"     ,            true         , new int[] { 26, 27  });
        Track GreatBlockRuins_to_FarawayOasis       = new Track( 172, "Intermission" ,        ""      , "Great ? Block Ruins to Faraway Oasis"        ,      "Transfer"     ,            true         , new int[] { 26, 24  });
        Track GreatBlockRuins_to_SaltySaltySpeedway = new Track( 173, "Intermission" ,        ""      , "Great ? Block Ruins to Salty Salty Speedway" ,      "Transfer"     ,            true         , new int[] { 26, 18  });
        Track GreatBlockRuins_to_PeachBeach         = new Track( 174, "Intermission" ,        ""      , "Great ? Block Ruins to Peach Beach"          ,      "Transfer"     ,            true         , new int[] { 26, 25  });
//   -----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------


    }


}

class Track
{
    private int trkID;
    private string cup;
    private string secondaryCup;
    private string name;
    private string region;
    private bool isIntermission;
    private int[] conTracks;

    public Track(int trkID, string cup, string secondaryCup, string name, string region, bool isIntermission, int[] conTracks)
    {
        this.trkID = trkID;
        this.cup = cup;
        this.secondaryCup = secondaryCup;
        this.name = name;
        this.region = region;
        this.isIntermission = isIntermission;
        this.conTracks = conTracks;
    }
}

