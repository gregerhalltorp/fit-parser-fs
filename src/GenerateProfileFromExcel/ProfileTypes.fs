namespace Fit

module ProfileTypes =

  module File =
    [<Literal>]
    let Device = 1uy
    [<Literal>]
    let Settings = 2uy
    [<Literal>]
    let Sport = 3uy
    [<Literal>]
    let Activity = 4uy
    [<Literal>]
    let Workout = 5uy
    [<Literal>]
    let Course = 6uy
    [<Literal>]
    let Schedules = 7uy
    [<Literal>]
    let Weight = 9uy
    [<Literal>]
    let Totals = 10uy
    [<Literal>]
    let Goals = 11uy
    [<Literal>]
    let BloodPressure = 14uy
    [<Literal>]
    let MonitoringA = 15uy
    [<Literal>]
    let ActivitySummary = 20uy
    [<Literal>]
    let MonitoringDaily = 28uy
    [<Literal>]
    let MonitoringB = 32uy
    [<Literal>]
    let Segment = 34uy
    [<Literal>]
    let SegmentList = 35uy
    [<Literal>]
    let ExdConfiguration = 40uy
    [<Literal>]
    let MfgRangeMin = 0xF7uy
    [<Literal>]
    let MfgRangeMax = 0xFEuy

  module MesgNum =
    [<Literal>]
    let FileId = 0us
    [<Literal>]
    let Capabilities = 1us
    [<Literal>]
    let DeviceSettings = 2us
    [<Literal>]
    let UserProfile = 3us
    [<Literal>]
    let HrmProfile = 4us
    [<Literal>]
    let SdmProfile = 5us
    [<Literal>]
    let BikeProfile = 6us
    [<Literal>]
    let ZonesTarget = 7us
    [<Literal>]
    let HrZone = 8us
    [<Literal>]
    let PowerZone = 9us
    [<Literal>]
    let MetZone = 10us
    [<Literal>]
    let Sport = 12us
    [<Literal>]
    let Goal = 15us
    [<Literal>]
    let Session = 18us
    [<Literal>]
    let Lap = 19us
    [<Literal>]
    let Record = 20us
    [<Literal>]
    let Event = 21us
    [<Literal>]
    let DeviceInfo = 23us
    [<Literal>]
    let Workout = 26us
    [<Literal>]
    let WorkoutStep = 27us
    [<Literal>]
    let Schedule = 28us
    [<Literal>]
    let WeightScale = 30us
    [<Literal>]
    let Course = 31us
    [<Literal>]
    let CoursePoint = 32us
    [<Literal>]
    let Totals = 33us
    [<Literal>]
    let Activity = 34us
    [<Literal>]
    let Software = 35us
    [<Literal>]
    let FileCapabilities = 37us
    [<Literal>]
    let MesgCapabilities = 38us
    [<Literal>]
    let FieldCapabilities = 39us
    [<Literal>]
    let FileCreator = 49us
    [<Literal>]
    let BloodPressure = 51us
    [<Literal>]
    let SpeedZone = 53us
    [<Literal>]
    let Monitoring = 55us
    [<Literal>]
    let TrainingFile = 72us
    [<Literal>]
    let Hrv = 78us
    [<Literal>]
    let AntRx = 80us
    [<Literal>]
    let AntTx = 81us
    [<Literal>]
    let AntChannelId = 82us
    [<Literal>]
    let Length = 101us
    [<Literal>]
    let MonitoringInfo = 103us
    [<Literal>]
    let Pad = 105us
    [<Literal>]
    let SlaveDevice = 106us
    [<Literal>]
    let Connectivity = 127us
    [<Literal>]
    let WeatherConditions = 128us
    [<Literal>]
    let WeatherAlert = 129us
    [<Literal>]
    let CadenceZone = 131us
    [<Literal>]
    let Hr = 132us
    [<Literal>]
    let SegmentLap = 142us
    [<Literal>]
    let MemoGlob = 145us
    [<Literal>]
    let SegmentId = 148us
    [<Literal>]
    let SegmentLeaderboardEntry = 149us
    [<Literal>]
    let SegmentPoint = 150us
    [<Literal>]
    let SegmentFile = 151us
    [<Literal>]
    let WorkoutSession = 158us
    [<Literal>]
    let WatchfaceSettings = 159us
    [<Literal>]
    let GpsMetadata = 160us
    [<Literal>]
    let CameraEvent = 161us
    [<Literal>]
    let TimestampCorrelation = 162us
    [<Literal>]
    let GyroscopeData = 164us
    [<Literal>]
    let AccelerometerData = 165us
    [<Literal>]
    let ThreeDSensorCalibration = 167us
    [<Literal>]
    let VideoFrame = 169us
    [<Literal>]
    let ObdiiData = 174us
    [<Literal>]
    let NmeaSentence = 177us
    [<Literal>]
    let AviationAttitude = 178us
    [<Literal>]
    let Video = 184us
    [<Literal>]
    let VideoTitle = 185us
    [<Literal>]
    let VideoDescription = 186us
    [<Literal>]
    let VideoClip = 187us
    [<Literal>]
    let OhrSettings = 188us
    [<Literal>]
    let ExdScreenConfiguration = 200us
    [<Literal>]
    let ExdDataFieldConfiguration = 201us
    [<Literal>]
    let ExdDataConceptConfiguration = 202us
    [<Literal>]
    let FieldDescription = 206us
    [<Literal>]
    let DeveloperDataId = 207us
    [<Literal>]
    let MagnetometerData = 208us
    [<Literal>]
    let BarometerData = 209us
    [<Literal>]
    let OneDSensorCalibration = 210us
    [<Literal>]
    let Set = 225us
    [<Literal>]
    let StressLevel = 227us
    [<Literal>]
    let DiveSettings = 258us
    [<Literal>]
    let DiveGas = 259us
    [<Literal>]
    let DiveAlarm = 262us
    [<Literal>]
    let ExerciseTitle = 264us
    [<Literal>]
    let DiveSummary = 268us
    [<Literal>]
    let Jump = 285us
    [<Literal>]
    let ClimbPro = 317us
    [<Literal>]
    let MfgRangeMin = 0xFF00us
    [<Literal>]
    let MfgRangeMax = 0xFFFEus

  module Checksum =
    [<Literal>]
    let Clear = 0uy
    [<Literal>]
    let Ok = 1uy

  module FileFlags =
    [<Literal>]
    let Read = 0x02uy
    [<Literal>]
    let Write = 0x04uy
    [<Literal>]
    let Erase = 0x08uy

  module MesgCount =
    [<Literal>]
    let NumPerFile = 0uy
    [<Literal>]
    let MaxPerFile = 1uy
    [<Literal>]
    let MaxPerFileType = 2uy

  module DateTime =
    [<Literal>]
    let Min = 0x10000000u

  module LocalDateTime =
    [<Literal>]
    let Min = 0x10000000u

  module MessageIndex =
    [<Literal>]
    let Selected = 0x8000us
    [<Literal>]
    let Reserved = 0x7000us
    [<Literal>]
    let Mask = 0x0FFFus

  module DeviceIndex =
    [<Literal>]
    let Creator = 0uy

  module Gender =
    [<Literal>]
    let Female = 0uy
    [<Literal>]
    let Male = 1uy

  module Language =
    [<Literal>]
    let English = 0uy
    [<Literal>]
    let French = 1uy
    [<Literal>]
    let Italian = 2uy
    [<Literal>]
    let German = 3uy
    [<Literal>]
    let Spanish = 4uy
    [<Literal>]
    let Croatian = 5uy
    [<Literal>]
    let Czech = 6uy
    [<Literal>]
    let Danish = 7uy
    [<Literal>]
    let Dutch = 8uy
    [<Literal>]
    let Finnish = 9uy
    [<Literal>]
    let Greek = 10uy
    [<Literal>]
    let Hungarian = 11uy
    [<Literal>]
    let Norwegian = 12uy
    [<Literal>]
    let Polish = 13uy
    [<Literal>]
    let Portuguese = 14uy
    [<Literal>]
    let Slovakian = 15uy
    [<Literal>]
    let Slovenian = 16uy
    [<Literal>]
    let Swedish = 17uy
    [<Literal>]
    let Russian = 18uy
    [<Literal>]
    let Turkish = 19uy
    [<Literal>]
    let Latvian = 20uy
    [<Literal>]
    let Ukrainian = 21uy
    [<Literal>]
    let Arabic = 22uy
    [<Literal>]
    let Farsi = 23uy
    [<Literal>]
    let Bulgarian = 24uy
    [<Literal>]
    let Romanian = 25uy
    [<Literal>]
    let Chinese = 26uy
    [<Literal>]
    let Japanese = 27uy
    [<Literal>]
    let Korean = 28uy
    [<Literal>]
    let Taiwanese = 29uy
    [<Literal>]
    let Thai = 30uy
    [<Literal>]
    let Hebrew = 31uy
    [<Literal>]
    let BrazilianPortuguese = 32uy
    [<Literal>]
    let Indonesian = 33uy
    [<Literal>]
    let Malaysian = 34uy
    [<Literal>]
    let Vietnamese = 35uy
    [<Literal>]
    let Burmese = 36uy
    [<Literal>]
    let Mongolian = 37uy
    [<Literal>]
    let Custom = 254uy

  module LanguageBits0 =
    [<Literal>]
    let English = 0x01uy
    [<Literal>]
    let French = 0x02uy
    [<Literal>]
    let Italian = 0x04uy
    [<Literal>]
    let German = 0x08uy
    [<Literal>]
    let Spanish = 0x10uy
    [<Literal>]
    let Croatian = 0x20uy
    [<Literal>]
    let Czech = 0x40uy
    [<Literal>]
    let Danish = 0x80uy

  module LanguageBits1 =
    [<Literal>]
    let Dutch = 0x01uy
    [<Literal>]
    let Finnish = 0x02uy
    [<Literal>]
    let Greek = 0x04uy
    [<Literal>]
    let Hungarian = 0x08uy
    [<Literal>]
    let Norwegian = 0x10uy
    [<Literal>]
    let Polish = 0x20uy
    [<Literal>]
    let Portuguese = 0x40uy
    [<Literal>]
    let Slovakian = 0x80uy

  module LanguageBits2 =
    [<Literal>]
    let Slovenian = 0x01uy
    [<Literal>]
    let Swedish = 0x02uy
    [<Literal>]
    let Russian = 0x04uy
    [<Literal>]
    let Turkish = 0x08uy
    [<Literal>]
    let Latvian = 0x10uy
    [<Literal>]
    let Ukrainian = 0x20uy
    [<Literal>]
    let Arabic = 0x40uy
    [<Literal>]
    let Farsi = 0x80uy

  module LanguageBits3 =
    [<Literal>]
    let Bulgarian = 0x01uy
    [<Literal>]
    let Romanian = 0x02uy
    [<Literal>]
    let Chinese = 0x04uy
    [<Literal>]
    let Japanese = 0x08uy
    [<Literal>]
    let Korean = 0x10uy
    [<Literal>]
    let Taiwanese = 0x20uy
    [<Literal>]
    let Thai = 0x40uy
    [<Literal>]
    let Hebrew = 0x80uy

  module LanguageBits4 =
    [<Literal>]
    let BrazilianPortuguese = 0x01uy
    [<Literal>]
    let Indonesian = 0x02uy
    [<Literal>]
    let Malaysian = 0x04uy
    [<Literal>]
    let Vietnamese = 0x08uy
    [<Literal>]
    let Burmese = 0x10uy
    [<Literal>]
    let Mongolian = 0x20uy

  module TimeZone =
    [<Literal>]
    let Almaty = 0uy
    [<Literal>]
    let Bangkok = 1uy
    [<Literal>]
    let Bombay = 2uy
    [<Literal>]
    let Brasilia = 3uy
    [<Literal>]
    let Cairo = 4uy
    [<Literal>]
    let CapeVerdeIs = 5uy
    [<Literal>]
    let Darwin = 6uy
    [<Literal>]
    let Eniwetok = 7uy
    [<Literal>]
    let Fiji = 8uy
    [<Literal>]
    let HongKong = 9uy
    [<Literal>]
    let Islamabad = 10uy
    [<Literal>]
    let Kabul = 11uy
    [<Literal>]
    let Magadan = 12uy
    [<Literal>]
    let MidAtlantic = 13uy
    [<Literal>]
    let Moscow = 14uy
    [<Literal>]
    let Muscat = 15uy
    [<Literal>]
    let Newfoundland = 16uy
    [<Literal>]
    let Samoa = 17uy
    [<Literal>]
    let Sydney = 18uy
    [<Literal>]
    let Tehran = 19uy
    [<Literal>]
    let Tokyo = 20uy
    [<Literal>]
    let UsAlaska = 21uy
    [<Literal>]
    let UsAtlantic = 22uy
    [<Literal>]
    let UsCentral = 23uy
    [<Literal>]
    let UsEastern = 24uy
    [<Literal>]
    let UsHawaii = 25uy
    [<Literal>]
    let UsMountain = 26uy
    [<Literal>]
    let UsPacific = 27uy
    [<Literal>]
    let Other = 28uy
    [<Literal>]
    let Auckland = 29uy
    [<Literal>]
    let Kathmandu = 30uy
    [<Literal>]
    let EuropeWesternWet = 31uy
    [<Literal>]
    let EuropeCentralCet = 32uy
    [<Literal>]
    let EuropeEasternEet = 33uy
    [<Literal>]
    let Jakarta = 34uy
    [<Literal>]
    let Perth = 35uy
    [<Literal>]
    let Adelaide = 36uy
    [<Literal>]
    let Brisbane = 37uy
    [<Literal>]
    let Tasmania = 38uy
    [<Literal>]
    let Iceland = 39uy
    [<Literal>]
    let Amsterdam = 40uy
    [<Literal>]
    let Athens = 41uy
    [<Literal>]
    let Barcelona = 42uy
    [<Literal>]
    let Berlin = 43uy
    [<Literal>]
    let Brussels = 44uy
    [<Literal>]
    let Budapest = 45uy
    [<Literal>]
    let Copenhagen = 46uy
    [<Literal>]
    let Dublin = 47uy
    [<Literal>]
    let Helsinki = 48uy
    [<Literal>]
    let Lisbon = 49uy
    [<Literal>]
    let London = 50uy
    [<Literal>]
    let Madrid = 51uy
    [<Literal>]
    let Munich = 52uy
    [<Literal>]
    let Oslo = 53uy
    [<Literal>]
    let Paris = 54uy
    [<Literal>]
    let Prague = 55uy
    [<Literal>]
    let Reykjavik = 56uy
    [<Literal>]
    let Rome = 57uy
    [<Literal>]
    let Stockholm = 58uy
    [<Literal>]
    let Vienna = 59uy
    [<Literal>]
    let Warsaw = 60uy
    [<Literal>]
    let Zurich = 61uy
    [<Literal>]
    let Quebec = 62uy
    [<Literal>]
    let Ontario = 63uy
    [<Literal>]
    let Manitoba = 64uy
    [<Literal>]
    let Saskatchewan = 65uy
    [<Literal>]
    let Alberta = 66uy
    [<Literal>]
    let BritishColumbia = 67uy
    [<Literal>]
    let Boise = 68uy
    [<Literal>]
    let Boston = 69uy
    [<Literal>]
    let Chicago = 70uy
    [<Literal>]
    let Dallas = 71uy
    [<Literal>]
    let Denver = 72uy
    [<Literal>]
    let KansasCity = 73uy
    [<Literal>]
    let LasVegas = 74uy
    [<Literal>]
    let LosAngeles = 75uy
    [<Literal>]
    let Miami = 76uy
    [<Literal>]
    let Minneapolis = 77uy
    [<Literal>]
    let NewYork = 78uy
    [<Literal>]
    let NewOrleans = 79uy
    [<Literal>]
    let Phoenix = 80uy
    [<Literal>]
    let SantaFe = 81uy
    [<Literal>]
    let Seattle = 82uy
    [<Literal>]
    let WashingtonDc = 83uy
    [<Literal>]
    let UsArizona = 84uy
    [<Literal>]
    let Chita = 85uy
    [<Literal>]
    let Ekaterinburg = 86uy
    [<Literal>]
    let Irkutsk = 87uy
    [<Literal>]
    let Kaliningrad = 88uy
    [<Literal>]
    let Krasnoyarsk = 89uy
    [<Literal>]
    let Novosibirsk = 90uy
    [<Literal>]
    let PetropavlovskKamchatskiy = 91uy
    [<Literal>]
    let Samara = 92uy
    [<Literal>]
    let Vladivostok = 93uy
    [<Literal>]
    let MexicoCentral = 94uy
    [<Literal>]
    let MexicoMountain = 95uy
    [<Literal>]
    let MexicoPacific = 96uy
    [<Literal>]
    let CapeTown = 97uy
    [<Literal>]
    let Winkhoek = 98uy
    [<Literal>]
    let Lagos = 99uy
    [<Literal>]
    let Riyahd = 100uy
    [<Literal>]
    let Venezuela = 101uy
    [<Literal>]
    let AustraliaLh = 102uy
    [<Literal>]
    let Santiago = 103uy
    [<Literal>]
    let Manual = 253uy
    [<Literal>]
    let Automatic = 254uy

  module DisplayMeasure =
    [<Literal>]
    let Metric = 0uy
    [<Literal>]
    let Statute = 1uy
    [<Literal>]
    let Nautical = 2uy

  module DisplayHeart =
    [<Literal>]
    let Bpm = 0uy
    [<Literal>]
    let Max = 1uy
    [<Literal>]
    let Reserve = 2uy

  module DisplayPower =
    [<Literal>]
    let Watts = 0uy
    [<Literal>]
    let PercentFtp = 1uy

  module DisplayPosition =
    [<Literal>]
    let Degree = 0uy
    [<Literal>]
    let DegreeMinute = 1uy
    [<Literal>]
    let DegreeMinuteSecond = 2uy
    [<Literal>]
    let AustrianGrid = 3uy
    [<Literal>]
    let BritishGrid = 4uy
    [<Literal>]
    let DutchGrid = 5uy
    [<Literal>]
    let HungarianGrid = 6uy
    [<Literal>]
    let FinnishGrid = 7uy
    [<Literal>]
    let GermanGrid = 8uy
    [<Literal>]
    let IcelandicGrid = 9uy
    [<Literal>]
    let IndonesianEquatorial = 10uy
    [<Literal>]
    let IndonesianIrian = 11uy
    [<Literal>]
    let IndonesianSouthern = 12uy
    [<Literal>]
    let IndiaZone0 = 13uy
    [<Literal>]
    let IndiaZoneIA = 14uy
    [<Literal>]
    let IndiaZoneIB = 15uy
    [<Literal>]
    let IndiaZoneIIA = 16uy
    [<Literal>]
    let IndiaZoneIIB = 17uy
    [<Literal>]
    let IndiaZoneIIIA = 18uy
    [<Literal>]
    let IndiaZoneIIIB = 19uy
    [<Literal>]
    let IndiaZoneIVA = 20uy
    [<Literal>]
    let IndiaZoneIVB = 21uy
    [<Literal>]
    let IrishTransverse = 22uy
    [<Literal>]
    let IrishGrid = 23uy
    [<Literal>]
    let Loran = 24uy
    [<Literal>]
    let MaidenheadGrid = 25uy
    [<Literal>]
    let MgrsGrid = 26uy
    [<Literal>]
    let NewZealandGrid = 27uy
    [<Literal>]
    let NewZealandTransverse = 28uy
    [<Literal>]
    let QatarGrid = 29uy
    [<Literal>]
    let ModifiedSwedishGrid = 30uy
    [<Literal>]
    let SwedishGrid = 31uy
    [<Literal>]
    let SouthAfricanGrid = 32uy
    [<Literal>]
    let SwissGrid = 33uy
    [<Literal>]
    let TaiwanGrid = 34uy
    [<Literal>]
    let UnitedStatesGrid = 35uy
    [<Literal>]
    let UtmUpsGrid = 36uy
    [<Literal>]
    let WestMalayan = 37uy
    [<Literal>]
    let BorneoRso = 38uy
    [<Literal>]
    let EstonianGrid = 39uy
    [<Literal>]
    let LatvianGrid = 40uy
    [<Literal>]
    let SwedishRef99Grid = 41uy

  module Switch =
    [<Literal>]
    let Off = 0uy
    [<Literal>]
    let On = 1uy
    [<Literal>]
    let Auto = 2uy

  module Sport =
    [<Literal>]
    let Generic = 0uy
    [<Literal>]
    let Running = 1uy
    [<Literal>]
    let Cycling = 2uy
    [<Literal>]
    let Transition = 3uy
    [<Literal>]
    let FitnessEquipment = 4uy
    [<Literal>]
    let Swimming = 5uy
    [<Literal>]
    let Basketball = 6uy
    [<Literal>]
    let Soccer = 7uy
    [<Literal>]
    let Tennis = 8uy
    [<Literal>]
    let AmericanFootball = 9uy
    [<Literal>]
    let Training = 10uy
    [<Literal>]
    let Walking = 11uy
    [<Literal>]
    let CrossCountrySkiing = 12uy
    [<Literal>]
    let AlpineSkiing = 13uy
    [<Literal>]
    let Snowboarding = 14uy
    [<Literal>]
    let Rowing = 15uy
    [<Literal>]
    let Mountaineering = 16uy
    [<Literal>]
    let Hiking = 17uy
    [<Literal>]
    let Multisport = 18uy
    [<Literal>]
    let Paddling = 19uy
    [<Literal>]
    let Flying = 20uy
    [<Literal>]
    let EBiking = 21uy
    [<Literal>]
    let Motorcycling = 22uy
    [<Literal>]
    let Boating = 23uy
    [<Literal>]
    let Driving = 24uy
    [<Literal>]
    let Golf = 25uy
    [<Literal>]
    let HangGliding = 26uy
    [<Literal>]
    let HorsebackRiding = 27uy
    [<Literal>]
    let Hunting = 28uy
    [<Literal>]
    let Fishing = 29uy
    [<Literal>]
    let InlineSkating = 30uy
    [<Literal>]
    let RockClimbing = 31uy
    [<Literal>]
    let Sailing = 32uy
    [<Literal>]
    let IceSkating = 33uy
    [<Literal>]
    let SkyDiving = 34uy
    [<Literal>]
    let Snowshoeing = 35uy
    [<Literal>]
    let Snowmobiling = 36uy
    [<Literal>]
    let StandUpPaddleboarding = 37uy
    [<Literal>]
    let Surfing = 38uy
    [<Literal>]
    let Wakeboarding = 39uy
    [<Literal>]
    let WaterSkiing = 40uy
    [<Literal>]
    let Kayaking = 41uy
    [<Literal>]
    let Rafting = 42uy
    [<Literal>]
    let Windsurfing = 43uy
    [<Literal>]
    let Kitesurfing = 44uy
    [<Literal>]
    let Tactical = 45uy
    [<Literal>]
    let Jumpmaster = 46uy
    [<Literal>]
    let Boxing = 47uy
    [<Literal>]
    let FloorClimbing = 48uy
    [<Literal>]
    let All = 254uy

  module SportBits0 =
    [<Literal>]
    let Generic = 0x01uy
    [<Literal>]
    let Running = 0x02uy
    [<Literal>]
    let Cycling = 0x04uy
    [<Literal>]
    let Transition = 0x08uy
    [<Literal>]
    let FitnessEquipment = 0x10uy
    [<Literal>]
    let Swimming = 0x20uy
    [<Literal>]
    let Basketball = 0x40uy
    [<Literal>]
    let Soccer = 0x80uy

  module SportBits1 =
    [<Literal>]
    let Tennis = 0x01uy
    [<Literal>]
    let AmericanFootball = 0x02uy
    [<Literal>]
    let Training = 0x04uy
    [<Literal>]
    let Walking = 0x08uy
    [<Literal>]
    let CrossCountrySkiing = 0x10uy
    [<Literal>]
    let AlpineSkiing = 0x20uy
    [<Literal>]
    let Snowboarding = 0x40uy
    [<Literal>]
    let Rowing = 0x80uy

  module SportBits2 =
    [<Literal>]
    let Mountaineering = 0x01uy
    [<Literal>]
    let Hiking = 0x02uy
    [<Literal>]
    let Multisport = 0x04uy
    [<Literal>]
    let Paddling = 0x08uy
    [<Literal>]
    let Flying = 0x10uy
    [<Literal>]
    let EBiking = 0x20uy
    [<Literal>]
    let Motorcycling = 0x40uy
    [<Literal>]
    let Boating = 0x80uy

  module SportBits3 =
    [<Literal>]
    let Driving = 0x01uy
    [<Literal>]
    let Golf = 0x02uy
    [<Literal>]
    let HangGliding = 0x04uy
    [<Literal>]
    let HorsebackRiding = 0x08uy
    [<Literal>]
    let Hunting = 0x10uy
    [<Literal>]
    let Fishing = 0x20uy
    [<Literal>]
    let InlineSkating = 0x40uy
    [<Literal>]
    let RockClimbing = 0x80uy

  module SportBits4 =
    [<Literal>]
    let Sailing = 0x01uy
    [<Literal>]
    let IceSkating = 0x02uy
    [<Literal>]
    let SkyDiving = 0x04uy
    [<Literal>]
    let Snowshoeing = 0x08uy
    [<Literal>]
    let Snowmobiling = 0x10uy
    [<Literal>]
    let StandUpPaddleboarding = 0x20uy
    [<Literal>]
    let Surfing = 0x40uy
    [<Literal>]
    let Wakeboarding = 0x80uy

  module SportBits5 =
    [<Literal>]
    let WaterSkiing = 0x01uy
    [<Literal>]
    let Kayaking = 0x02uy
    [<Literal>]
    let Rafting = 0x04uy
    [<Literal>]
    let Windsurfing = 0x08uy
    [<Literal>]
    let Kitesurfing = 0x10uy
    [<Literal>]
    let Tactical = 0x20uy
    [<Literal>]
    let Jumpmaster = 0x40uy
    [<Literal>]
    let Boxing = 0x80uy

  module SportBits6 =
    [<Literal>]
    let FloorClimbing = 0x01uy

  module SubSport =
    [<Literal>]
    let Generic = 0uy
    [<Literal>]
    let Treadmill = 1uy
    [<Literal>]
    let Street = 2uy
    [<Literal>]
    let Trail = 3uy
    [<Literal>]
    let Track = 4uy
    [<Literal>]
    let Spin = 5uy
    [<Literal>]
    let IndoorCycling = 6uy
    [<Literal>]
    let Road = 7uy
    [<Literal>]
    let Mountain = 8uy
    [<Literal>]
    let Downhill = 9uy
    [<Literal>]
    let Recumbent = 10uy
    [<Literal>]
    let Cyclocross = 11uy
    [<Literal>]
    let HandCycling = 12uy
    [<Literal>]
    let TrackCycling = 13uy
    [<Literal>]
    let IndoorRowing = 14uy
    [<Literal>]
    let Elliptical = 15uy
    [<Literal>]
    let StairClimbing = 16uy
    [<Literal>]
    let LapSwimming = 17uy
    [<Literal>]
    let OpenWater = 18uy
    [<Literal>]
    let FlexibilityTraining = 19uy
    [<Literal>]
    let StrengthTraining = 20uy
    [<Literal>]
    let WarmUp = 21uy
    [<Literal>]
    let Match = 22uy
    [<Literal>]
    let Exercise = 23uy
    [<Literal>]
    let Challenge = 24uy
    [<Literal>]
    let IndoorSkiing = 25uy
    [<Literal>]
    let CardioTraining = 26uy
    [<Literal>]
    let IndoorWalking = 27uy
    [<Literal>]
    let EBikeFitness = 28uy
    [<Literal>]
    let Bmx = 29uy
    [<Literal>]
    let CasualWalking = 30uy
    [<Literal>]
    let SpeedWalking = 31uy
    [<Literal>]
    let BikeToRunTransition = 32uy
    [<Literal>]
    let RunToBikeTransition = 33uy
    [<Literal>]
    let SwimToBikeTransition = 34uy
    [<Literal>]
    let Atv = 35uy
    [<Literal>]
    let Motocross = 36uy
    [<Literal>]
    let Backcountry = 37uy
    [<Literal>]
    let Resort = 38uy
    [<Literal>]
    let RcDrone = 39uy
    [<Literal>]
    let Wingsuit = 40uy
    [<Literal>]
    let Whitewater = 41uy
    [<Literal>]
    let SkateSkiing = 42uy
    [<Literal>]
    let Yoga = 43uy
    [<Literal>]
    let Pilates = 44uy
    [<Literal>]
    let IndoorRunning = 45uy
    [<Literal>]
    let GravelCycling = 46uy
    [<Literal>]
    let EBikeMountain = 47uy
    [<Literal>]
    let Commuting = 48uy
    [<Literal>]
    let MixedSurface = 49uy
    [<Literal>]
    let Navigate = 50uy
    [<Literal>]
    let TrackMe = 51uy
    [<Literal>]
    let Map = 52uy
    [<Literal>]
    let SingleGasDiving = 53uy
    [<Literal>]
    let MultiGasDiving = 54uy
    [<Literal>]
    let GaugeDiving = 55uy
    [<Literal>]
    let ApneaDiving = 56uy
    [<Literal>]
    let ApneaHunting = 57uy
    [<Literal>]
    let VirtualActivity = 58uy
    [<Literal>]
    let Obstacle = 59uy
    [<Literal>]
    let All = 254uy

  module SportEvent =
    [<Literal>]
    let Uncategorized = 0uy
    [<Literal>]
    let Geocaching = 1uy
    [<Literal>]
    let Fitness = 2uy
    [<Literal>]
    let Recreation = 3uy
    [<Literal>]
    let Race = 4uy
    [<Literal>]
    let SpecialEvent = 5uy
    [<Literal>]
    let Training = 6uy
    [<Literal>]
    let Transportation = 7uy
    [<Literal>]
    let Touring = 8uy

  module Activity =
    [<Literal>]
    let Manual = 0uy
    [<Literal>]
    let AutoMultiSport = 1uy

  module Intensity =
    [<Literal>]
    let Active = 0uy
    [<Literal>]
    let Rest = 1uy
    [<Literal>]
    let Warmup = 2uy
    [<Literal>]
    let Cooldown = 3uy

  module SessionTrigger =
    [<Literal>]
    let ActivityEnd = 0uy
    [<Literal>]
    let Manual = 1uy
    [<Literal>]
    let AutoMultiSport = 2uy
    [<Literal>]
    let FitnessEquipment = 3uy

  module AutolapTrigger =
    [<Literal>]
    let Time = 0uy
    [<Literal>]
    let Distance = 1uy
    [<Literal>]
    let PositionStart = 2uy
    [<Literal>]
    let PositionLap = 3uy
    [<Literal>]
    let PositionWaypoint = 4uy
    [<Literal>]
    let PositionMarked = 5uy
    [<Literal>]
    let Off = 6uy

  module LapTrigger =
    [<Literal>]
    let Manual = 0uy
    [<Literal>]
    let Time = 1uy
    [<Literal>]
    let Distance = 2uy
    [<Literal>]
    let PositionStart = 3uy
    [<Literal>]
    let PositionLap = 4uy
    [<Literal>]
    let PositionWaypoint = 5uy
    [<Literal>]
    let PositionMarked = 6uy
    [<Literal>]
    let SessionEnd = 7uy
    [<Literal>]
    let FitnessEquipment = 8uy

  module TimeMode =
    [<Literal>]
    let Hour12 = 0uy
    [<Literal>]
    let Hour24 = 1uy
    [<Literal>]
    let Military = 2uy
    [<Literal>]
    let Hour12WithSeconds = 3uy
    [<Literal>]
    let Hour24WithSeconds = 4uy
    [<Literal>]
    let Utc = 5uy

  module BacklightMode =
    [<Literal>]
    let Off = 0uy
    [<Literal>]
    let Manual = 1uy
    [<Literal>]
    let KeyAndMessages = 2uy
    [<Literal>]
    let AutoBrightness = 3uy
    [<Literal>]
    let SmartNotifications = 4uy
    [<Literal>]
    let KeyAndMessagesNight = 5uy
    [<Literal>]
    let KeyAndMessagesAndSmartNotifications = 6uy

  module DateMode =
    [<Literal>]
    let DayMonth = 0uy
    [<Literal>]
    let MonthDay = 1uy

  module BacklightTimeout =
    [<Literal>]
    let Infinite = 0uy

  module Event =
    [<Literal>]
    let Timer = 0uy
    [<Literal>]
    let Workout = 3uy
    [<Literal>]
    let WorkoutStep = 4uy
    [<Literal>]
    let PowerDown = 5uy
    [<Literal>]
    let PowerUp = 6uy
    [<Literal>]
    let OffCourse = 7uy
    [<Literal>]
    let Session = 8uy
    [<Literal>]
    let Lap = 9uy
    [<Literal>]
    let CoursePoint = 10uy
    [<Literal>]
    let Battery = 11uy
    [<Literal>]
    let VirtualPartnerPace = 12uy
    [<Literal>]
    let HrHighAlert = 13uy
    [<Literal>]
    let HrLowAlert = 14uy
    [<Literal>]
    let SpeedHighAlert = 15uy
    [<Literal>]
    let SpeedLowAlert = 16uy
    [<Literal>]
    let CadHighAlert = 17uy
    [<Literal>]
    let CadLowAlert = 18uy
    [<Literal>]
    let PowerHighAlert = 19uy
    [<Literal>]
    let PowerLowAlert = 20uy
    [<Literal>]
    let RecoveryHr = 21uy
    [<Literal>]
    let BatteryLow = 22uy
    [<Literal>]
    let TimeDurationAlert = 23uy
    [<Literal>]
    let DistanceDurationAlert = 24uy
    [<Literal>]
    let CalorieDurationAlert = 25uy
    [<Literal>]
    let Activity = 26uy
    [<Literal>]
    let FitnessEquipment = 27uy
    [<Literal>]
    let Length = 28uy
    [<Literal>]
    let UserMarker = 32uy
    [<Literal>]
    let SportPoint = 33uy
    [<Literal>]
    let Calibration = 36uy
    [<Literal>]
    let FrontGearChange = 42uy
    [<Literal>]
    let RearGearChange = 43uy
    [<Literal>]
    let RiderPositionChange = 44uy
    [<Literal>]
    let ElevHighAlert = 45uy
    [<Literal>]
    let ElevLowAlert = 46uy
    [<Literal>]
    let CommTimeout = 47uy
    [<Literal>]
    let RadarThreatAlert = 75uy

  module EventType =
    [<Literal>]
    let Start = 0uy
    [<Literal>]
    let Stop = 1uy
    [<Literal>]
    let ConsecutiveDepreciated = 2uy
    [<Literal>]
    let Marker = 3uy
    [<Literal>]
    let StopAll = 4uy
    [<Literal>]
    let BeginDepreciated = 5uy
    [<Literal>]
    let EndDepreciated = 6uy
    [<Literal>]
    let EndAllDepreciated = 7uy
    [<Literal>]
    let StopDisable = 8uy
    [<Literal>]
    let StopDisableAll = 9uy

  module TimerTrigger =
    [<Literal>]
    let Manual = 0uy
    [<Literal>]
    let Auto = 1uy
    [<Literal>]
    let FitnessEquipment = 2uy

  module FitnessEquipmentState =
    [<Literal>]
    let Ready = 0uy
    [<Literal>]
    let InUse = 1uy
    [<Literal>]
    let Paused = 2uy
    [<Literal>]
    let Unknown = 3uy

  module Tone =
    [<Literal>]
    let Off = 0uy
    [<Literal>]
    let Tone = 1uy
    [<Literal>]
    let Vibrate = 2uy
    [<Literal>]
    let ToneAndVibrate = 3uy

  module Autoscroll =
    [<Literal>]
    let None = 0uy
    [<Literal>]
    let Slow = 1uy
    [<Literal>]
    let Medium = 2uy
    [<Literal>]
    let Fast = 3uy

  module ActivityClass =
    [<Literal>]
    let Level = 0x7Fuy
    [<Literal>]
    let LevelMax = 100uy
    [<Literal>]
    let Athlete = 0x80uy

  module HrZoneCalc =
    [<Literal>]
    let Custom = 0uy
    [<Literal>]
    let PercentMaxHr = 1uy
    [<Literal>]
    let PercentHrr = 2uy

  module PwrZoneCalc =
    [<Literal>]
    let Custom = 0uy
    [<Literal>]
    let PercentFtp = 1uy

  module WktStepDuration =
    [<Literal>]
    let Time = 0uy
    [<Literal>]
    let Distance = 1uy
    [<Literal>]
    let HrLessThan = 2uy
    [<Literal>]
    let HrGreaterThan = 3uy
    [<Literal>]
    let Calories = 4uy
    [<Literal>]
    let Open = 5uy
    [<Literal>]
    let RepeatUntilStepsCmplt = 6uy
    [<Literal>]
    let RepeatUntilTime = 7uy
    [<Literal>]
    let RepeatUntilDistance = 8uy
    [<Literal>]
    let RepeatUntilCalories = 9uy
    [<Literal>]
    let RepeatUntilHrLessThan = 10uy
    [<Literal>]
    let RepeatUntilHrGreaterThan = 11uy
    [<Literal>]
    let RepeatUntilPowerLessThan = 12uy
    [<Literal>]
    let RepeatUntilPowerGreaterThan = 13uy
    [<Literal>]
    let PowerLessThan = 14uy
    [<Literal>]
    let PowerGreaterThan = 15uy
    [<Literal>]
    let TrainingPeaksTss = 16uy
    [<Literal>]
    let RepeatUntilPowerLastLapLessThan = 17uy
    [<Literal>]
    let RepeatUntilMaxPowerLastLapLessThan = 18uy
    [<Literal>]
    let Power3sLessThan = 19uy
    [<Literal>]
    let Power10sLessThan = 20uy
    [<Literal>]
    let Power30sLessThan = 21uy
    [<Literal>]
    let Power3sGreaterThan = 22uy
    [<Literal>]
    let Power10sGreaterThan = 23uy
    [<Literal>]
    let Power30sGreaterThan = 24uy
    [<Literal>]
    let PowerLapLessThan = 25uy
    [<Literal>]
    let PowerLapGreaterThan = 26uy
    [<Literal>]
    let RepeatUntilTrainingPeaksTss = 27uy
    [<Literal>]
    let RepetitionTime = 28uy
    [<Literal>]
    let Reps = 29uy
    [<Literal>]
    let TimeOnly = 31uy

  module WktStepTarget =
    [<Literal>]
    let Speed = 0uy
    [<Literal>]
    let HeartRate = 1uy
    [<Literal>]
    let Open = 2uy
    [<Literal>]
    let Cadence = 3uy
    [<Literal>]
    let Power = 4uy
    [<Literal>]
    let Grade = 5uy
    [<Literal>]
    let Resistance = 6uy
    [<Literal>]
    let Power3s = 7uy
    [<Literal>]
    let Power10s = 8uy
    [<Literal>]
    let Power30s = 9uy
    [<Literal>]
    let PowerLap = 10uy
    [<Literal>]
    let SwimStroke = 11uy
    [<Literal>]
    let SpeedLap = 12uy
    [<Literal>]
    let HeartRateLap = 13uy

  module Goal =
    [<Literal>]
    let Time = 0uy
    [<Literal>]
    let Distance = 1uy
    [<Literal>]
    let Calories = 2uy
    [<Literal>]
    let Frequency = 3uy
    [<Literal>]
    let Steps = 4uy
    [<Literal>]
    let Ascent = 5uy
    [<Literal>]
    let ActiveMinutes = 6uy

  module GoalRecurrence =
    [<Literal>]
    let Off = 0uy
    [<Literal>]
    let Daily = 1uy
    [<Literal>]
    let Weekly = 2uy
    [<Literal>]
    let Monthly = 3uy
    [<Literal>]
    let Yearly = 4uy
    [<Literal>]
    let Custom = 5uy

  module GoalSource =
    [<Literal>]
    let Auto = 0uy
    [<Literal>]
    let Community = 1uy
    [<Literal>]
    let User = 2uy

  module Schedule =
    [<Literal>]
    let Workout = 0uy
    [<Literal>]
    let Course = 1uy

  module CoursePoint =
    [<Literal>]
    let Generic = 0uy
    [<Literal>]
    let Summit = 1uy
    [<Literal>]
    let Valley = 2uy
    [<Literal>]
    let Water = 3uy
    [<Literal>]
    let Food = 4uy
    [<Literal>]
    let Danger = 5uy
    [<Literal>]
    let Left = 6uy
    [<Literal>]
    let Right = 7uy
    [<Literal>]
    let Straight = 8uy
    [<Literal>]
    let FirstAid = 9uy
    [<Literal>]
    let FourthCategory = 10uy
    [<Literal>]
    let ThirdCategory = 11uy
    [<Literal>]
    let SecondCategory = 12uy
    [<Literal>]
    let FirstCategory = 13uy
    [<Literal>]
    let HorsCategory = 14uy
    [<Literal>]
    let Sprint = 15uy
    [<Literal>]
    let LeftFork = 16uy
    [<Literal>]
    let RightFork = 17uy
    [<Literal>]
    let MiddleFork = 18uy
    [<Literal>]
    let SlightLeft = 19uy
    [<Literal>]
    let SharpLeft = 20uy
    [<Literal>]
    let SlightRight = 21uy
    [<Literal>]
    let SharpRight = 22uy
    [<Literal>]
    let UTurn = 23uy
    [<Literal>]
    let SegmentStart = 24uy
    [<Literal>]
    let SegmentEnd = 25uy

  module Manufacturer =
    [<Literal>]
    let Garmin = 1us
    [<Literal>]
    let GarminFr405Antfs = 2us
    [<Literal>]
    let Zephyr = 3us
    [<Literal>]
    let Dayton = 4us
    [<Literal>]
    let Idt = 5us
    [<Literal>]
    let Srm = 6us
    [<Literal>]
    let Quarq = 7us
    [<Literal>]
    let Ibike = 8us
    [<Literal>]
    let Saris = 9us
    [<Literal>]
    let SparkHk = 10us
    [<Literal>]
    let Tanita = 11us
    [<Literal>]
    let Echowell = 12us
    [<Literal>]
    let DynastreamOem = 13us
    [<Literal>]
    let Nautilus = 14us
    [<Literal>]
    let Dynastream = 15us
    [<Literal>]
    let Timex = 16us
    [<Literal>]
    let Metrigear = 17us
    [<Literal>]
    let Xelic = 18us
    [<Literal>]
    let Beurer = 19us
    [<Literal>]
    let Cardiosport = 20us
    [<Literal>]
    let AAndD = 21us
    [<Literal>]
    let Hmm = 22us
    [<Literal>]
    let Suunto = 23us
    [<Literal>]
    let ThitaElektronik = 24us
    [<Literal>]
    let Gpulse = 25us
    [<Literal>]
    let CleanMobile = 26us
    [<Literal>]
    let PedalBrain = 27us
    [<Literal>]
    let Peaksware = 28us
    [<Literal>]
    let Saxonar = 29us
    [<Literal>]
    let LemondFitness = 30us
    [<Literal>]
    let Dexcom = 31us
    [<Literal>]
    let WahooFitness = 32us
    [<Literal>]
    let OctaneFitness = 33us
    [<Literal>]
    let Archinoetics = 34us
    [<Literal>]
    let TheHurtBox = 35us
    [<Literal>]
    let CitizenSystems = 36us
    [<Literal>]
    let Magellan = 37us
    [<Literal>]
    let Osynce = 38us
    [<Literal>]
    let Holux = 39us
    [<Literal>]
    let Concept2 = 40us
    [<Literal>]
    let OneGiantLeap = 42us
    [<Literal>]
    let AceSensor = 43us
    [<Literal>]
    let BrimBrothers = 44us
    [<Literal>]
    let Xplova = 45us
    [<Literal>]
    let PerceptionDigital = 46us
    [<Literal>]
    let Bf1systems = 47us
    [<Literal>]
    let Pioneer = 48us
    [<Literal>]
    let Spantec = 49us
    [<Literal>]
    let Metalogics = 50us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _4iiiis = 51us
    [<Literal>]
    let SeikoEpson = 52us
    [<Literal>]
    let SeikoEpsonOem = 53us
    [<Literal>]
    let IforPowell = 54us
    [<Literal>]
    let MaxwellGuider = 55us
    [<Literal>]
    let StarTrac = 56us
    [<Literal>]
    let Breakaway = 57us
    [<Literal>]
    let AlatechTechnologyLtd = 58us
    [<Literal>]
    let MioTechnologyEurope = 59us
    [<Literal>]
    let Rotor = 60us
    [<Literal>]
    let Geonaute = 61us
    [<Literal>]
    let IdBike = 62us
    [<Literal>]
    let Specialized = 63us
    [<Literal>]
    let Wtek = 64us
    [<Literal>]
    let PhysicalEnterprises = 65us
    [<Literal>]
    let NorthPoleEngineering = 66us
    [<Literal>]
    let Bkool = 67us
    [<Literal>]
    let Cateye = 68us
    [<Literal>]
    let StagesCycling = 69us
    [<Literal>]
    let Sigmasport = 70us
    [<Literal>]
    let Tomtom = 71us
    [<Literal>]
    let Peripedal = 72us
    [<Literal>]
    let Wattbike = 73us
    [<Literal>]
    let Moxy = 76us
    [<Literal>]
    let Ciclosport = 77us
    [<Literal>]
    let Powerbahn = 78us
    [<Literal>]
    let AcornProjectsAps = 79us
    [<Literal>]
    let Lifebeam = 80us
    [<Literal>]
    let Bontrager = 81us
    [<Literal>]
    let Wellgo = 82us
    [<Literal>]
    let Scosche = 83us
    [<Literal>]
    let Magura = 84us
    [<Literal>]
    let Woodway = 85us
    [<Literal>]
    let Elite = 86us
    [<Literal>]
    let NielsenKellerman = 87us
    [<Literal>]
    let DkCity = 88us
    [<Literal>]
    let Tacx = 89us
    [<Literal>]
    let DirectionTechnology = 90us
    [<Literal>]
    let Magtonic = 91us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _1partcarbon = 92us
    [<Literal>]
    let InsideRideTechnologies = 93us
    [<Literal>]
    let SoundOfMotion = 94us
    [<Literal>]
    let Stryd = 95us
    [<Literal>]
    let Icg = 96us
    [<Literal>]
    let MiPulse = 97us
    [<Literal>]
    let BsxAthletics = 98us
    [<Literal>]
    let Look = 99us
    [<Literal>]
    let CampagnoloSrl = 100us
    [<Literal>]
    let BodyBikeSmart = 101us
    [<Literal>]
    let Praxisworks = 102us
    [<Literal>]
    let LimitsTechnology = 103us
    [<Literal>]
    let TopactionTechnology = 104us
    [<Literal>]
    let Cosinuss = 105us
    [<Literal>]
    let Fitcare = 106us
    [<Literal>]
    let Magene = 107us
    [<Literal>]
    let GiantManufacturingCo = 108us
    [<Literal>]
    let Tigrasport = 109us
    [<Literal>]
    let Salutron = 110us
    [<Literal>]
    let Technogym = 111us
    [<Literal>]
    let BrytonSensors = 112us
    [<Literal>]
    let LatitudeLimited = 113us
    [<Literal>]
    let SoaringTechnology = 114us
    [<Literal>]
    let Igpsport = 115us
    [<Literal>]
    let Thinkrider = 116us
    [<Literal>]
    let GopherSport = 117us
    [<Literal>]
    let Waterrower = 118us
    [<Literal>]
    let Orangetheory = 119us
    [<Literal>]
    let Inpeak = 120us
    [<Literal>]
    let Kinetic = 121us
    [<Literal>]
    let JohnsonHealthTech = 122us
    [<Literal>]
    let PolarElectro = 123us
    [<Literal>]
    let Seesense = 124us
    [<Literal>]
    let NciTechnology = 125us
    [<Literal>]
    let Iqsquare = 126us
    [<Literal>]
    let Leomo = 127us
    [<Literal>]
    let IfitCom = 128us
    [<Literal>]
    let CorosByte = 129us
    [<Literal>]
    let VersaDesign = 130us
    [<Literal>]
    let Chileaf = 131us
    [<Literal>]
    let Cycplus = 132us
    [<Literal>]
    let Development = 255us
    [<Literal>]
    let Healthandlife = 257us
    [<Literal>]
    let Lezyne = 258us
    [<Literal>]
    let ScribeLabs = 259us
    [<Literal>]
    let Zwift = 260us
    [<Literal>]
    let Watteam = 261us
    [<Literal>]
    let Recon = 262us
    [<Literal>]
    let FaveroElectronics = 263us
    [<Literal>]
    let Dynovelo = 264us
    [<Literal>]
    let Strava = 265us
    [<Literal>]
    let Precor = 266us
    [<Literal>]
    let Bryton = 267us
    [<Literal>]
    let Sram = 268us
    [<Literal>]
    let Navman = 269us
    [<Literal>]
    let Cobi = 270us
    [<Literal>]
    let Spivi = 271us
    [<Literal>]
    let MioMagellan = 272us
    [<Literal>]
    let Evesports = 273us
    [<Literal>]
    let SensitivusGauge = 274us
    [<Literal>]
    let Podoon = 275us
    [<Literal>]
    let LifeTimeFitness = 276us
    [<Literal>]
    let FalcoEMotors = 277us
    [<Literal>]
    let Minoura = 278us
    [<Literal>]
    let Cycliq = 279us
    [<Literal>]
    let Luxottica = 280us
    [<Literal>]
    let TrainerRoad = 281us
    [<Literal>]
    let TheSufferfest = 282us
    [<Literal>]
    let Fullspeedahead = 283us
    [<Literal>]
    let Virtualtraining = 284us
    [<Literal>]
    let Feedbacksports = 285us
    [<Literal>]
    let Omata = 286us
    [<Literal>]
    let Vdo = 287us
    [<Literal>]
    let Magneticdays = 288us
    [<Literal>]
    let Hammerhead = 289us
    [<Literal>]
    let KineticByKurt = 290us
    [<Literal>]
    let Shapelog = 291us
    [<Literal>]
    let Dabuziduo = 292us
    [<Literal>]
    let Jetblack = 293us
    [<Literal>]
    let Coros = 294us
    [<Literal>]
    let Virtugo = 295us
    [<Literal>]
    let Velosense = 296us
    [<Literal>]
    let Cycligentinc = 297us
    [<Literal>]
    let Trailforks = 298us
    [<Literal>]
    let MahleEbikemotion = 299us
    [<Literal>]
    let Nurvv = 300us
    [<Literal>]
    let Microprogram = 301us
    [<Literal>]
    let Zone5cloud = 302us
    [<Literal>]
    let Greenteg = 303us
    [<Literal>]
    let YamahaMotors = 304us
    [<Literal>]
    let Actigraphcorp = 5759us

  module GarminProduct =
    [<Literal>]
    let Hrm1 = 1us
    [<Literal>]
    let Axh01 = 2us
    [<Literal>]
    let Axb01 = 3us
    [<Literal>]
    let Axb02 = 4us
    [<Literal>]
    let Hrm2ss = 5us
    [<Literal>]
    let DsiAlf02 = 6us
    [<Literal>]
    let Hrm3ss = 7us
    [<Literal>]
    let HrmRunSingleByteProductId = 8us
    [<Literal>]
    let Bsm = 9us
    [<Literal>]
    let Bcm = 10us
    [<Literal>]
    let Axs01 = 11us
    [<Literal>]
    let HrmTriSingleByteProductId = 12us
    [<Literal>]
    let Hrm4RunSingleByteProductId = 13us
    [<Literal>]
    let Fr225SingleByteProductId = 14us
    [<Literal>]
    let Fr301China = 473us
    [<Literal>]
    let Fr301Japan = 474us
    [<Literal>]
    let Fr301Korea = 475us
    [<Literal>]
    let Fr301Taiwan = 494us
    [<Literal>]
    let Fr405 = 717us
    [<Literal>]
    let Fr50 = 782us
    [<Literal>]
    let Fr405Japan = 987us
    [<Literal>]
    let Fr60 = 988us
    [<Literal>]
    let DsiAlf01 = 1011us
    [<Literal>]
    let Fr310xt = 1018us
    [<Literal>]
    let Edge500 = 1036us
    [<Literal>]
    let Fr110 = 1124us
    [<Literal>]
    let Edge800 = 1169us
    [<Literal>]
    let Edge500Taiwan = 1199us
    [<Literal>]
    let Edge500Japan = 1213us
    [<Literal>]
    let Chirp = 1253us
    [<Literal>]
    let Fr110Japan = 1274us
    [<Literal>]
    let Edge200 = 1325us
    [<Literal>]
    let Fr910xt = 1328us
    [<Literal>]
    let Edge800Taiwan = 1333us
    [<Literal>]
    let Edge800Japan = 1334us
    [<Literal>]
    let Alf04 = 1341us
    [<Literal>]
    let Fr610 = 1345us
    [<Literal>]
    let Fr210Japan = 1360us
    [<Literal>]
    let VectorSs = 1380us
    [<Literal>]
    let VectorCp = 1381us
    [<Literal>]
    let Edge800China = 1386us
    [<Literal>]
    let Edge500China = 1387us
    [<Literal>]
    let ApproachG10 = 1405us
    [<Literal>]
    let Fr610Japan = 1410us
    [<Literal>]
    let Edge500Korea = 1422us
    [<Literal>]
    let Fr70 = 1436us
    [<Literal>]
    let Fr310xt4t = 1446us
    [<Literal>]
    let Amx = 1461us
    [<Literal>]
    let Fr10 = 1482us
    [<Literal>]
    let Edge800Korea = 1497us
    [<Literal>]
    let Swim = 1499us
    [<Literal>]
    let Fr910xtChina = 1537us
    [<Literal>]
    let Fenix = 1551us
    [<Literal>]
    let Edge200Taiwan = 1555us
    [<Literal>]
    let Edge510 = 1561us
    [<Literal>]
    let Edge810 = 1567us
    [<Literal>]
    let Tempe = 1570us
    [<Literal>]
    let Fr910xtJapan = 1600us
    [<Literal>]
    let Fr620 = 1623us
    [<Literal>]
    let Fr220 = 1632us
    [<Literal>]
    let Fr910xtKorea = 1664us
    [<Literal>]
    let Fr10Japan = 1688us
    [<Literal>]
    let Edge810Japan = 1721us
    [<Literal>]
    let VirbElite = 1735us
    [<Literal>]
    let EdgeTouring = 1736us
    [<Literal>]
    let Edge510Japan = 1742us
    [<Literal>]
    let HrmTri = 1743us
    [<Literal>]
    let HrmRun = 1752us
    [<Literal>]
    let Fr920xt = 1765us
    [<Literal>]
    let Edge510Asia = 1821us
    [<Literal>]
    let Edge810China = 1822us
    [<Literal>]
    let Edge810Taiwan = 1823us
    [<Literal>]
    let Edge1000 = 1836us
    [<Literal>]
    let VivoFit = 1837us
    [<Literal>]
    let VirbRemote = 1853us
    [<Literal>]
    let VivoKi = 1885us
    [<Literal>]
    let Fr15 = 1903us
    [<Literal>]
    let VivoActive = 1907us
    [<Literal>]
    let Edge510Korea = 1918us
    [<Literal>]
    let Fr620Japan = 1928us
    [<Literal>]
    let Fr620China = 1929us
    [<Literal>]
    let Fr220Japan = 1930us
    [<Literal>]
    let Fr220China = 1931us
    [<Literal>]
    let ApproachS6 = 1936us
    [<Literal>]
    let VivoSmart = 1956us
    [<Literal>]
    let Fenix2 = 1967us
    [<Literal>]
    let Epix = 1988us
    [<Literal>]
    let Fenix3 = 2050us
    [<Literal>]
    let Edge1000Taiwan = 2052us
    [<Literal>]
    let Edge1000Japan = 2053us
    [<Literal>]
    let Fr15Japan = 2061us
    [<Literal>]
    let Edge520 = 2067us
    [<Literal>]
    let Edge1000China = 2070us
    [<Literal>]
    let Fr620Russia = 2072us
    [<Literal>]
    let Fr220Russia = 2073us
    [<Literal>]
    let VectorS = 2079us
    [<Literal>]
    let Edge1000Korea = 2100us
    [<Literal>]
    let Fr920xtTaiwan = 2130us
    [<Literal>]
    let Fr920xtChina = 2131us
    [<Literal>]
    let Fr920xtJapan = 2132us
    [<Literal>]
    let Virbx = 2134us
    [<Literal>]
    let VivoSmartApac = 2135us
    [<Literal>]
    let EtrexTouch = 2140us
    [<Literal>]
    let Edge25 = 2147us
    [<Literal>]
    let Fr25 = 2148us
    [<Literal>]
    let VivoFit2 = 2150us
    [<Literal>]
    let Fr225 = 2153us
    [<Literal>]
    let Fr630 = 2156us
    [<Literal>]
    let Fr230 = 2157us
    [<Literal>]
    let Fr735xt = 2158us
    [<Literal>]
    let VivoActiveApac = 2160us
    [<Literal>]
    let Vector2 = 2161us
    [<Literal>]
    let Vector2s = 2162us
    [<Literal>]
    let Virbxe = 2172us
    [<Literal>]
    let Fr620Taiwan = 2173us
    [<Literal>]
    let Fr220Taiwan = 2174us
    [<Literal>]
    let Truswing = 2175us
    [<Literal>]
    let Fenix3China = 2188us
    [<Literal>]
    let Fenix3Twn = 2189us
    [<Literal>]
    let VariaHeadlight = 2192us
    [<Literal>]
    let VariaTaillightOld = 2193us
    [<Literal>]
    let EdgeExplore1000 = 2204us
    [<Literal>]
    let Fr225Asia = 2219us
    [<Literal>]
    let VariaRadarTaillight = 2225us
    [<Literal>]
    let VariaRadarDisplay = 2226us
    [<Literal>]
    let Edge20 = 2238us
    [<Literal>]
    let Edge520Asia = 2260us
    [<Literal>]
    let Edge520Japan = 2261us
    [<Literal>]
    let D2Bravo = 2262us
    [<Literal>]
    let ApproachS20 = 2266us
    [<Literal>]
    let VivoSmart2 = 2271us
    [<Literal>]
    let Edge1000Thai = 2274us
    [<Literal>]
    let VariaRemote = 2276us
    [<Literal>]
    let Edge25Asia = 2288us
    [<Literal>]
    let Edge25Jpn = 2289us
    [<Literal>]
    let Edge20Asia = 2290us
    [<Literal>]
    let ApproachX40 = 2292us
    [<Literal>]
    let Fenix3Japan = 2293us
    [<Literal>]
    let VivoSmartEmea = 2294us
    [<Literal>]
    let Fr630Asia = 2310us
    [<Literal>]
    let Fr630Jpn = 2311us
    [<Literal>]
    let Fr230Jpn = 2313us
    [<Literal>]
    let Hrm4Run = 2327us
    [<Literal>]
    let EpixJapan = 2332us
    [<Literal>]
    let VivoActiveHr = 2337us
    [<Literal>]
    let VivoSmartGpsHr = 2347us
    [<Literal>]
    let VivoSmartHr = 2348us
    [<Literal>]
    let VivoSmartHrAsia = 2361us
    [<Literal>]
    let VivoSmartGpsHrAsia = 2362us
    [<Literal>]
    let VivoMove = 2368us
    [<Literal>]
    let VariaTaillight = 2379us
    [<Literal>]
    let Fr235Japan = 2397us
    [<Literal>]
    let VariaVision = 2398us
    [<Literal>]
    let VivoFit3 = 2406us
    [<Literal>]
    let Fenix3Korea = 2407us
    [<Literal>]
    let Fenix3Sea = 2408us
    [<Literal>]
    let Fenix3Hr = 2413us
    [<Literal>]
    let VirbUltra30 = 2417us
    [<Literal>]
    let IndexSmartScale = 2429us
    [<Literal>]
    let Fr235 = 2431us
    [<Literal>]
    let Fenix3Chronos = 2432us
    [<Literal>]
    let Oregon7xx = 2441us
    [<Literal>]
    let Rino7xx = 2444us
    [<Literal>]
    let EpixKorea = 2457us
    [<Literal>]
    let Fenix3HrChn = 2473us
    [<Literal>]
    let Fenix3HrTwn = 2474us
    [<Literal>]
    let Fenix3HrJpn = 2475us
    [<Literal>]
    let Fenix3HrSea = 2476us
    [<Literal>]
    let Fenix3HrKor = 2477us
    [<Literal>]
    let Nautix = 2496us
    [<Literal>]
    let VivoActiveHrApac = 2497us
    [<Literal>]
    let Oregon7xxWw = 2512us
    [<Literal>]
    let Edge820 = 2530us
    [<Literal>]
    let EdgeExplore820 = 2531us
    [<Literal>]
    let Fr735xtApac = 2533us
    [<Literal>]
    let Fr735xtJapan = 2534us
    [<Literal>]
    let Fenix5s = 2544us
    [<Literal>]
    let D2BravoTitanium = 2547us
    [<Literal>]
    let VariaUt800 = 2567us
    [<Literal>]
    let RunningDynamicsPod = 2593us
    [<Literal>]
    let Edge820China = 2599us
    [<Literal>]
    let Edge820Japan = 2600us
    [<Literal>]
    let Fenix5x = 2604us
    [<Literal>]
    let VivoFitJr = 2606us
    [<Literal>]
    let VivoSmart3 = 2622us
    [<Literal>]
    let VivoSport = 2623us
    [<Literal>]
    let Edge820Taiwan = 2628us
    [<Literal>]
    let Edge820Korea = 2629us
    [<Literal>]
    let Edge820Sea = 2630us
    [<Literal>]
    let Fr35Hebrew = 2650us
    [<Literal>]
    let ApproachS60 = 2656us
    [<Literal>]
    let Fr35Apac = 2667us
    [<Literal>]
    let Fr35Japan = 2668us
    [<Literal>]
    let Fenix3ChronosAsia = 2675us
    [<Literal>]
    let Virb360 = 2687us
    [<Literal>]
    let Fr935 = 2691us
    [<Literal>]
    let Fenix5 = 2697us
    [<Literal>]
    let Vivoactive3 = 2700us
    [<Literal>]
    let Fr235ChinaNfc = 2733us
    [<Literal>]
    let Foretrex601701 = 2769us
    [<Literal>]
    let VivoMoveHr = 2772us
    [<Literal>]
    let Edge1030 = 2713us
    [<Literal>]
    let Fenix5Asia = 2796us
    [<Literal>]
    let Fenix5sAsia = 2797us
    [<Literal>]
    let Fenix5xAsia = 2798us
    [<Literal>]
    let ApproachZ80 = 2806us
    [<Literal>]
    let Fr35Korea = 2814us
    [<Literal>]
    let D2charlie = 2819us
    [<Literal>]
    let VivoSmart3Apac = 2831us
    [<Literal>]
    let VivoSportApac = 2832us
    [<Literal>]
    let Fr935Asia = 2833us
    [<Literal>]
    let Descent = 2859us
    [<Literal>]
    let Fr645 = 2886us
    [<Literal>]
    let Fr645m = 2888us
    [<Literal>]
    let Fr30 = 2891us
    [<Literal>]
    let Fenix5sPlus = 2900us
    [<Literal>]
    let Edge130 = 2909us
    [<Literal>]
    let Edge1030Asia = 2924us
    [<Literal>]
    let Vivosmart4 = 2927us
    [<Literal>]
    let VivoMoveHrAsia = 2945us
    [<Literal>]
    let ApproachX10 = 2962us
    [<Literal>]
    let Fr30Asia = 2977us
    [<Literal>]
    let Vivoactive3mW = 2988us
    [<Literal>]
    let Fr645Asia = 3003us
    [<Literal>]
    let Fr645mAsia = 3004us
    [<Literal>]
    let EdgeExplore = 3011us
    [<Literal>]
    let Gpsmap66 = 3028us
    [<Literal>]
    let ApproachS10 = 3049us
    [<Literal>]
    let Vivoactive3mL = 3066us
    [<Literal>]
    let ApproachG80 = 3085us
    [<Literal>]
    let Edge130Asia = 3092us
    [<Literal>]
    let Edge1030Bontrager = 3095us
    [<Literal>]
    let Fenix5Plus = 3110us
    [<Literal>]
    let Fenix5xPlus = 3111us
    [<Literal>]
    let Edge520Plus = 3112us
    [<Literal>]
    let Edge530 = 3121us
    [<Literal>]
    let Edge830 = 3122us
    [<Literal>]
    let Fenix5sPlusApac = 3134us
    [<Literal>]
    let Fenix5xPlusApac = 3135us
    [<Literal>]
    let Edge520PlusApac = 3142us
    [<Literal>]
    let Fr235lAsia = 3144us
    [<Literal>]
    let Fr245Asia = 3145us
    [<Literal>]
    let VivoActive3mApac = 3163us
    [<Literal>]
    let VivoSmart4Asia = 3218us
    [<Literal>]
    let Vivoactive4Small = 3224us
    [<Literal>]
    let Vivoactive4Large = 3225us
    [<Literal>]
    let Venu = 3226us
    [<Literal>]
    let MarqDriver = 3246us
    [<Literal>]
    let MarqAviator = 3247us
    [<Literal>]
    let MarqCaptain = 3248us
    [<Literal>]
    let MarqCommander = 3249us
    [<Literal>]
    let MarqExpedition = 3250us
    [<Literal>]
    let MarqAthlete = 3251us
    [<Literal>]
    let Fenix6SSport = 3287us
    [<Literal>]
    let Fenix6S = 3288us
    [<Literal>]
    let Fenix6Sport = 3289us
    [<Literal>]
    let Fenix6 = 3290us
    [<Literal>]
    let Fenix6x = 3291us
    [<Literal>]
    let HrmDual = 3299us
    [<Literal>]
    let VivoMove3Premium = 3308us
    [<Literal>]
    let ApproachS40 = 3314us
    [<Literal>]
    let Fr245mAsia = 3321us
    [<Literal>]
    let Edge530Apac = 3349us
    [<Literal>]
    let Edge830Apac = 3350us
    [<Literal>]
    let VivoMove3 = 3378us
    [<Literal>]
    let VivoActive4SmallAsia = 3387us
    [<Literal>]
    let VivoActive4LargeAsia = 3388us
    [<Literal>]
    let VivoActive4OledAsia = 3389us
    [<Literal>]
    let Swim2 = 3405us
    [<Literal>]
    let MarqDriverAsia = 3420us
    [<Literal>]
    let MarqAviatorAsia = 3421us
    [<Literal>]
    let VivoMove3Asia = 3422us
    [<Literal>]
    let VivoActive3tChn = 3446us
    [<Literal>]
    let MarqCaptainAsia = 3448us
    [<Literal>]
    let MarqCommanderAsia = 3449us
    [<Literal>]
    let MarqExpeditionAsia = 3450us
    [<Literal>]
    let MarqAthleteAsia = 3451us
    [<Literal>]
    let Fr45Asia = 3469us
    [<Literal>]
    let Vivoactive3Daimler = 3473us
    [<Literal>]
    let Fenix6sSportAsia = 3512us
    [<Literal>]
    let Fenix6sAsia = 3513us
    [<Literal>]
    let Fenix6SportAsia = 3514us
    [<Literal>]
    let Fenix6Asia = 3515us
    [<Literal>]
    let Fenix6xAsia = 3516us
    [<Literal>]
    let MarqAdventurer = 3624us
    [<Literal>]
    let MarqAdventurerAsia = 3648us
    [<Literal>]
    let Swim2Apac = 3639us
    [<Literal>]
    let VenuDaimlerAsia = 3737us
    [<Literal>]
    let VenuDaimler = 3740us
    [<Literal>]
    let Sdm4 = 10007us
    [<Literal>]
    let EdgeRemote = 10014us
    [<Literal>]
    let TrainingCenter = 20119us
    [<Literal>]
    let ConnectiqSimulator = 65531us
    [<Literal>]
    let AndroidAntplusPlugin = 65532us
    [<Literal>]
    let Connect = 65534us

  module AntplusDeviceType =
    [<Literal>]
    let Antfs = 1uy
    [<Literal>]
    let BikePower = 11uy
    [<Literal>]
    let EnvironmentSensorLegacy = 12uy
    [<Literal>]
    let MultiSportSpeedDistance = 15uy
    [<Literal>]
    let Control = 16uy
    [<Literal>]
    let FitnessEquipment = 17uy
    [<Literal>]
    let BloodPressure = 18uy
    [<Literal>]
    let GeocacheNode = 19uy
    [<Literal>]
    let LightElectricVehicle = 20uy
    [<Literal>]
    let EnvSensor = 25uy
    [<Literal>]
    let Racquet = 26uy
    [<Literal>]
    let ControlHub = 27uy
    [<Literal>]
    let MuscleOxygen = 31uy
    [<Literal>]
    let BikeLightMain = 35uy
    [<Literal>]
    let BikeLightShared = 36uy
    [<Literal>]
    let Exd = 38uy
    [<Literal>]
    let BikeRadar = 40uy
    [<Literal>]
    let BikeAero = 46uy
    [<Literal>]
    let WeightScale = 119uy
    [<Literal>]
    let HeartRate = 120uy
    [<Literal>]
    let BikeSpeedCadence = 121uy
    [<Literal>]
    let BikeCadence = 122uy
    [<Literal>]
    let BikeSpeed = 123uy
    [<Literal>]
    let StrideSpeedDistance = 124uy

  module AntNetwork =
    [<Literal>]
    let Public = 0uy
    [<Literal>]
    let Antplus = 1uy
    [<Literal>]
    let Antfs = 2uy
    [<Literal>]
    let Private = 3uy

  module WorkoutCapabilities =
    [<Literal>]
    let Interval = 0x00000001u
    [<Literal>]
    let Custom = 0x00000002u
    [<Literal>]
    let FitnessEquipment = 0x00000004u
    [<Literal>]
    let Firstbeat = 0x00000008u
    [<Literal>]
    let NewLeaf = 0x00000010u
    [<Literal>]
    let Tcx = 0x00000020u
    [<Literal>]
    let Speed = 0x00000080u
    [<Literal>]
    let HeartRate = 0x00000100u
    [<Literal>]
    let Distance = 0x00000200u
    [<Literal>]
    let Cadence = 0x00000400u
    [<Literal>]
    let Power = 0x00000800u
    [<Literal>]
    let Grade = 0x00001000u
    [<Literal>]
    let Resistance = 0x00002000u
    [<Literal>]
    let Protected = 0x00004000u

  module BatteryStatus =
    [<Literal>]
    let New = 1uy
    [<Literal>]
    let Good = 2uy
    [<Literal>]
    let Ok = 3uy
    [<Literal>]
    let Low = 4uy
    [<Literal>]
    let Critical = 5uy
    [<Literal>]
    let Charging = 6uy
    [<Literal>]
    let Unknown = 7uy

  module HrType =
    [<Literal>]
    let Normal = 0uy
    [<Literal>]
    let Irregular = 1uy

  module CourseCapabilities =
    [<Literal>]
    let Processed = 0x00000001u
    [<Literal>]
    let Valid = 0x00000002u
    [<Literal>]
    let Time = 0x00000004u
    [<Literal>]
    let Distance = 0x00000008u
    [<Literal>]
    let Position = 0x00000010u
    [<Literal>]
    let HeartRate = 0x00000020u
    [<Literal>]
    let Power = 0x00000040u
    [<Literal>]
    let Cadence = 0x00000080u
    [<Literal>]
    let Training = 0x00000100u
    [<Literal>]
    let Navigation = 0x00000200u
    [<Literal>]
    let Bikeway = 0x00000400u

  module Weight =
    [<Literal>]
    let Calculating = 0xFFFEus

  module WorkoutHr =
    [<Literal>]
    let BpmOffset = 100u

  module WorkoutPower =
    [<Literal>]
    let WattsOffset = 1000u

  module BpStatus =
    [<Literal>]
    let NoError = 0uy
    [<Literal>]
    let ErrorIncompleteData = 1uy
    [<Literal>]
    let ErrorNoMeasurement = 2uy
    [<Literal>]
    let ErrorDataOutOfRange = 3uy
    [<Literal>]
    let ErrorIrregularHeartRate = 4uy

  module UserLocalId =
    [<Literal>]
    let LocalMin = 0x0000us
    [<Literal>]
    let LocalMax = 0x000Fus
    [<Literal>]
    let StationaryMin = 0x0010us
    [<Literal>]
    let StationaryMax = 0x00FFus
    [<Literal>]
    let PortableMin = 0x0100us
    [<Literal>]
    let PortableMax = 0xFFFEus

  module SwimStroke =
    [<Literal>]
    let Freestyle = 0uy
    [<Literal>]
    let Backstroke = 1uy
    [<Literal>]
    let Breaststroke = 2uy
    [<Literal>]
    let Butterfly = 3uy
    [<Literal>]
    let Drill = 4uy
    [<Literal>]
    let Mixed = 5uy
    [<Literal>]
    let Im = 6uy

  module ActivityType =
    [<Literal>]
    let Generic = 0uy
    [<Literal>]
    let Running = 1uy
    [<Literal>]
    let Cycling = 2uy
    [<Literal>]
    let Transition = 3uy
    [<Literal>]
    let FitnessEquipment = 4uy
    [<Literal>]
    let Swimming = 5uy
    [<Literal>]
    let Walking = 6uy
    [<Literal>]
    let Sedentary = 8uy
    [<Literal>]
    let All = 254uy

  module ActivitySubtype =
    [<Literal>]
    let Generic = 0uy
    [<Literal>]
    let Treadmill = 1uy
    [<Literal>]
    let Street = 2uy
    [<Literal>]
    let Trail = 3uy
    [<Literal>]
    let Track = 4uy
    [<Literal>]
    let Spin = 5uy
    [<Literal>]
    let IndoorCycling = 6uy
    [<Literal>]
    let Road = 7uy
    [<Literal>]
    let Mountain = 8uy
    [<Literal>]
    let Downhill = 9uy
    [<Literal>]
    let Recumbent = 10uy
    [<Literal>]
    let Cyclocross = 11uy
    [<Literal>]
    let HandCycling = 12uy
    [<Literal>]
    let TrackCycling = 13uy
    [<Literal>]
    let IndoorRowing = 14uy
    [<Literal>]
    let Elliptical = 15uy
    [<Literal>]
    let StairClimbing = 16uy
    [<Literal>]
    let LapSwimming = 17uy
    [<Literal>]
    let OpenWater = 18uy
    [<Literal>]
    let All = 254uy

  module ActivityLevel =
    [<Literal>]
    let Low = 0uy
    [<Literal>]
    let Medium = 1uy
    [<Literal>]
    let High = 2uy

  module Side =
    [<Literal>]
    let Right = 0uy
    [<Literal>]
    let Left = 1uy

  module LeftRightBalance =
    [<Literal>]
    let Mask = 0x7Fuy
    [<Literal>]
    let Right = 0x80uy

  module LeftRightBalance100 =
    [<Literal>]
    let Mask = 0x3FFFus
    [<Literal>]
    let Right = 0x8000us

  module LengthType =
    [<Literal>]
    let Idle = 0uy
    [<Literal>]
    let Active = 1uy

  module DayOfWeek =
    [<Literal>]
    let Sunday = 0uy
    [<Literal>]
    let Monday = 1uy
    [<Literal>]
    let Tuesday = 2uy
    [<Literal>]
    let Wednesday = 3uy
    [<Literal>]
    let Thursday = 4uy
    [<Literal>]
    let Friday = 5uy
    [<Literal>]
    let Saturday = 6uy

  module ConnectivityCapabilities =
    [<Literal>]
    let Bluetooth = 0x00000001u
    [<Literal>]
    let BluetoothLe = 0x00000002u
    [<Literal>]
    let Ant = 0x00000004u
    [<Literal>]
    let ActivityUpload = 0x00000008u
    [<Literal>]
    let CourseDownload = 0x00000010u
    [<Literal>]
    let WorkoutDownload = 0x00000020u
    [<Literal>]
    let LiveTrack = 0x00000040u
    [<Literal>]
    let WeatherConditions = 0x00000080u
    [<Literal>]
    let WeatherAlerts = 0x00000100u
    [<Literal>]
    let GpsEphemerisDownload = 0x00000200u
    [<Literal>]
    let ExplicitArchive = 0x00000400u
    [<Literal>]
    let SetupIncomplete = 0x00000800u
    [<Literal>]
    let ContinueSyncAfterSoftwareUpdate = 0x00001000u
    [<Literal>]
    let ConnectIqAppDownload = 0x00002000u
    [<Literal>]
    let GolfCourseDownload = 0x00004000u
    [<Literal>]
    let DeviceInitiatesSync = 0x00008000u
    [<Literal>]
    let ConnectIqWatchAppDownload = 0x00010000u
    [<Literal>]
    let ConnectIqWidgetDownload = 0x00020000u
    [<Literal>]
    let ConnectIqWatchFaceDownload = 0x00040000u
    [<Literal>]
    let ConnectIqDataFieldDownload = 0x00080000u
    [<Literal>]
    let ConnectIqAppManagment = 0x00100000u
    [<Literal>]
    let SwingSensor = 0x00200000u
    [<Literal>]
    let SwingSensorRemote = 0x00400000u
    [<Literal>]
    let IncidentDetection = 0x00800000u
    [<Literal>]
    let AudioPrompts = 0x01000000u
    [<Literal>]
    let WifiVerification = 0x02000000u
    [<Literal>]
    let TrueUp = 0x04000000u
    [<Literal>]
    let FindMyWatch = 0x08000000u
    [<Literal>]
    let RemoteManualSync = 0x10000000u
    [<Literal>]
    let LiveTrackAutoStart = 0x20000000u
    [<Literal>]
    let LiveTrackMessaging = 0x40000000u
    [<Literal>]
    let InstantInput = 0x80000000u

  module WeatherReport =
    [<Literal>]
    let Current = 0uy
    [<Literal>]
    let Forecast = 1uy
    [<Literal>]
    let HourlyForecast = 1uy
    [<Literal>]
    let DailyForecast = 2uy

  module WeatherStatus =
    [<Literal>]
    let Clear = 0uy
    [<Literal>]
    let PartlyCloudy = 1uy
    [<Literal>]
    let MostlyCloudy = 2uy
    [<Literal>]
    let Rain = 3uy
    [<Literal>]
    let Snow = 4uy
    [<Literal>]
    let Windy = 5uy
    [<Literal>]
    let Thunderstorms = 6uy
    [<Literal>]
    let WintryMix = 7uy
    [<Literal>]
    let Fog = 8uy
    [<Literal>]
    let Hazy = 11uy
    [<Literal>]
    let Hail = 12uy
    [<Literal>]
    let ScatteredShowers = 13uy
    [<Literal>]
    let ScatteredThunderstorms = 14uy
    [<Literal>]
    let UnknownPrecipitation = 15uy
    [<Literal>]
    let LightRain = 16uy
    [<Literal>]
    let HeavyRain = 17uy
    [<Literal>]
    let LightSnow = 18uy
    [<Literal>]
    let HeavySnow = 19uy
    [<Literal>]
    let LightRainSnow = 20uy
    [<Literal>]
    let HeavyRainSnow = 21uy
    [<Literal>]
    let Cloudy = 22uy

  module WeatherSeverity =
    [<Literal>]
    let Unknown = 0uy
    [<Literal>]
    let Warning = 1uy
    [<Literal>]
    let Watch = 2uy
    [<Literal>]
    let Advisory = 3uy
    [<Literal>]
    let Statement = 4uy

  module WeatherSevereType =
    [<Literal>]
    let Unspecified = 0uy
    [<Literal>]
    let Tornado = 1uy
    [<Literal>]
    let Tsunami = 2uy
    [<Literal>]
    let Hurricane = 3uy
    [<Literal>]
    let ExtremeWind = 4uy
    [<Literal>]
    let Typhoon = 5uy
    [<Literal>]
    let InlandHurricane = 6uy
    [<Literal>]
    let HurricaneForceWind = 7uy
    [<Literal>]
    let Waterspout = 8uy
    [<Literal>]
    let SevereThunderstorm = 9uy
    [<Literal>]
    let WreckhouseWinds = 10uy
    [<Literal>]
    let LesSuetesWind = 11uy
    [<Literal>]
    let Avalanche = 12uy
    [<Literal>]
    let FlashFlood = 13uy
    [<Literal>]
    let TropicalStorm = 14uy
    [<Literal>]
    let InlandTropicalStorm = 15uy
    [<Literal>]
    let Blizzard = 16uy
    [<Literal>]
    let IceStorm = 17uy
    [<Literal>]
    let FreezingRain = 18uy
    [<Literal>]
    let DebrisFlow = 19uy
    [<Literal>]
    let FlashFreeze = 20uy
    [<Literal>]
    let DustStorm = 21uy
    [<Literal>]
    let HighWind = 22uy
    [<Literal>]
    let WinterStorm = 23uy
    [<Literal>]
    let HeavyFreezingSpray = 24uy
    [<Literal>]
    let ExtremeCold = 25uy
    [<Literal>]
    let WindChill = 26uy
    [<Literal>]
    let ColdWave = 27uy
    [<Literal>]
    let HeavySnowAlert = 28uy
    [<Literal>]
    let LakeEffectBlowingSnow = 29uy
    [<Literal>]
    let SnowSquall = 30uy
    [<Literal>]
    let LakeEffectSnow = 31uy
    [<Literal>]
    let WinterWeather = 32uy
    [<Literal>]
    let Sleet = 33uy
    [<Literal>]
    let Snowfall = 34uy
    [<Literal>]
    let SnowAndBlowingSnow = 35uy
    [<Literal>]
    let BlowingSnow = 36uy
    [<Literal>]
    let SnowAlert = 37uy
    [<Literal>]
    let ArcticOutflow = 38uy
    [<Literal>]
    let FreezingDrizzle = 39uy
    [<Literal>]
    let Storm = 40uy
    [<Literal>]
    let StormSurge = 41uy
    [<Literal>]
    let Rainfall = 42uy
    [<Literal>]
    let ArealFlood = 43uy
    [<Literal>]
    let CoastalFlood = 44uy
    [<Literal>]
    let LakeshoreFlood = 45uy
    [<Literal>]
    let ExcessiveHeat = 46uy
    [<Literal>]
    let Heat = 47uy
    [<Literal>]
    let Weather = 48uy
    [<Literal>]
    let HighHeatAndHumidity = 49uy
    [<Literal>]
    let HumidexAndHealth = 50uy
    [<Literal>]
    let Humidex = 51uy
    [<Literal>]
    let Gale = 52uy
    [<Literal>]
    let FreezingSpray = 53uy
    [<Literal>]
    let SpecialMarine = 54uy
    [<Literal>]
    let Squall = 55uy
    [<Literal>]
    let StrongWind = 56uy
    [<Literal>]
    let LakeWind = 57uy
    [<Literal>]
    let MarineWeather = 58uy
    [<Literal>]
    let Wind = 59uy
    [<Literal>]
    let SmallCraftHazardousSeas = 60uy
    [<Literal>]
    let HazardousSeas = 61uy
    [<Literal>]
    let SmallCraft = 62uy
    [<Literal>]
    let SmallCraftWinds = 63uy
    [<Literal>]
    let SmallCraftRoughBar = 64uy
    [<Literal>]
    let HighWaterLevel = 65uy
    [<Literal>]
    let Ashfall = 66uy
    [<Literal>]
    let FreezingFog = 67uy
    [<Literal>]
    let DenseFog = 68uy
    [<Literal>]
    let DenseSmoke = 69uy
    [<Literal>]
    let BlowingDust = 70uy
    [<Literal>]
    let HardFreeze = 71uy
    [<Literal>]
    let Freeze = 72uy
    [<Literal>]
    let Frost = 73uy
    [<Literal>]
    let FireWeather = 74uy
    [<Literal>]
    let Flood = 75uy
    [<Literal>]
    let RipTide = 76uy
    [<Literal>]
    let HighSurf = 77uy
    [<Literal>]
    let Smog = 78uy
    [<Literal>]
    let AirQuality = 79uy
    [<Literal>]
    let BriskWind = 80uy
    [<Literal>]
    let AirStagnation = 81uy
    [<Literal>]
    let LowWater = 82uy
    [<Literal>]
    let Hydrological = 83uy
    [<Literal>]
    let SpecialWeather = 84uy

  type TimeIntoDay = TimeIntoDay of int

  type LocaltimeIntoDay = LocaltimeIntoDay of int

  module StrokeType =
    [<Literal>]
    let NoEvent = 0uy
    [<Literal>]
    let Other = 1uy
    [<Literal>]
    let Serve = 2uy
    [<Literal>]
    let Forehand = 3uy
    [<Literal>]
    let Backhand = 4uy
    [<Literal>]
    let Smash = 5uy

  module BodyLocation =
    [<Literal>]
    let LeftLeg = 0uy
    [<Literal>]
    let LeftCalf = 1uy
    [<Literal>]
    let LeftShin = 2uy
    [<Literal>]
    let LeftHamstring = 3uy
    [<Literal>]
    let LeftQuad = 4uy
    [<Literal>]
    let LeftGlute = 5uy
    [<Literal>]
    let RightLeg = 6uy
    [<Literal>]
    let RightCalf = 7uy
    [<Literal>]
    let RightShin = 8uy
    [<Literal>]
    let RightHamstring = 9uy
    [<Literal>]
    let RightQuad = 10uy
    [<Literal>]
    let RightGlute = 11uy
    [<Literal>]
    let TorsoBack = 12uy
    [<Literal>]
    let LeftLowerBack = 13uy
    [<Literal>]
    let LeftUpperBack = 14uy
    [<Literal>]
    let RightLowerBack = 15uy
    [<Literal>]
    let RightUpperBack = 16uy
    [<Literal>]
    let TorsoFront = 17uy
    [<Literal>]
    let LeftAbdomen = 18uy
    [<Literal>]
    let LeftChest = 19uy
    [<Literal>]
    let RightAbdomen = 20uy
    [<Literal>]
    let RightChest = 21uy
    [<Literal>]
    let LeftArm = 22uy
    [<Literal>]
    let LeftShoulder = 23uy
    [<Literal>]
    let LeftBicep = 24uy
    [<Literal>]
    let LeftTricep = 25uy
    [<Literal>]
    let LeftBrachioradialis = 26uy
    [<Literal>]
    let LeftForearmExtensors = 27uy
    [<Literal>]
    let RightArm = 28uy
    [<Literal>]
    let RightShoulder = 29uy
    [<Literal>]
    let RightBicep = 30uy
    [<Literal>]
    let RightTricep = 31uy
    [<Literal>]
    let RightBrachioradialis = 32uy
    [<Literal>]
    let RightForearmExtensors = 33uy
    [<Literal>]
    let Neck = 34uy
    [<Literal>]
    let Throat = 35uy
    [<Literal>]
    let WaistMidBack = 36uy
    [<Literal>]
    let WaistFront = 37uy
    [<Literal>]
    let WaistLeft = 38uy
    [<Literal>]
    let WaistRight = 39uy

  module SegmentLapStatus =
    [<Literal>]
    let End = 0uy
    [<Literal>]
    let Fail = 1uy

  module SegmentLeaderboardType =
    [<Literal>]
    let Overall = 0uy
    [<Literal>]
    let PersonalBest = 1uy
    [<Literal>]
    let Connections = 2uy
    [<Literal>]
    let Group = 3uy
    [<Literal>]
    let Challenger = 4uy
    [<Literal>]
    let Kom = 5uy
    [<Literal>]
    let Qom = 6uy
    [<Literal>]
    let Pr = 7uy
    [<Literal>]
    let Goal = 8uy
    [<Literal>]
    let Rival = 9uy
    [<Literal>]
    let ClubLeader = 10uy

  module SegmentDeleteStatus =
    [<Literal>]
    let DoNotDelete = 0uy
    [<Literal>]
    let DeleteOne = 1uy
    [<Literal>]
    let DeleteAll = 2uy

  module SegmentSelectionType =
    [<Literal>]
    let Starred = 0uy
    [<Literal>]
    let Suggested = 1uy

  module SourceType =
    [<Literal>]
    let Ant = 0uy
    [<Literal>]
    let Antplus = 1uy
    [<Literal>]
    let Bluetooth = 2uy
    [<Literal>]
    let BluetoothLowEnergy = 3uy
    [<Literal>]
    let Wifi = 4uy
    [<Literal>]
    let Local = 5uy

  type LocalDeviceType = LocalDeviceType of byte

  module DisplayOrientation =
    [<Literal>]
    let Auto = 0uy
    [<Literal>]
    let Portrait = 1uy
    [<Literal>]
    let Landscape = 2uy
    [<Literal>]
    let PortraitFlipped = 3uy
    [<Literal>]
    let LandscapeFlipped = 4uy

  module WorkoutEquipment =
    [<Literal>]
    let None = 0uy
    [<Literal>]
    let SwimFins = 1uy
    [<Literal>]
    let SwimKickboard = 2uy
    [<Literal>]
    let SwimPaddles = 3uy
    [<Literal>]
    let SwimPullBuoy = 4uy
    [<Literal>]
    let SwimSnorkel = 5uy

  module WatchfaceMode =
    [<Literal>]
    let Digital = 0uy
    [<Literal>]
    let Analog = 1uy
    [<Literal>]
    let ConnectIq = 2uy
    [<Literal>]
    let Disabled = 3uy

  module DigitalWatchfaceLayout =
    [<Literal>]
    let Traditional = 0uy
    [<Literal>]
    let Modern = 1uy
    [<Literal>]
    let Bold = 2uy

  module AnalogWatchfaceLayout =
    [<Literal>]
    let Minimal = 0uy
    [<Literal>]
    let Traditional = 1uy
    [<Literal>]
    let Modern = 2uy

  module RiderPositionType =
    [<Literal>]
    let Seated = 0uy
    [<Literal>]
    let Standing = 1uy
    [<Literal>]
    let TransitionToSeated = 2uy
    [<Literal>]
    let TransitionToStanding = 3uy

  module PowerPhaseType =
    [<Literal>]
    let PowerPhaseStartAngle = 0uy
    [<Literal>]
    let PowerPhaseEndAngle = 1uy
    [<Literal>]
    let PowerPhaseArcLength = 2uy
    [<Literal>]
    let PowerPhaseCenter = 3uy

  module CameraEventType =
    [<Literal>]
    let VideoStart = 0uy
    [<Literal>]
    let VideoSplit = 1uy
    [<Literal>]
    let VideoEnd = 2uy
    [<Literal>]
    let PhotoTaken = 3uy
    [<Literal>]
    let VideoSecondStreamStart = 4uy
    [<Literal>]
    let VideoSecondStreamSplit = 5uy
    [<Literal>]
    let VideoSecondStreamEnd = 6uy
    [<Literal>]
    let VideoSplitStart = 7uy
    [<Literal>]
    let VideoSecondStreamSplitStart = 8uy
    [<Literal>]
    let VideoPause = 11uy
    [<Literal>]
    let VideoSecondStreamPause = 12uy
    [<Literal>]
    let VideoResume = 13uy
    [<Literal>]
    let VideoSecondStreamResume = 14uy

  module SensorType =
    [<Literal>]
    let Accelerometer = 0uy
    [<Literal>]
    let Gyroscope = 1uy
    [<Literal>]
    let Compass = 2uy
    [<Literal>]
    let Barometer = 3uy

  module BikeLightNetworkConfigType =
    [<Literal>]
    let Auto = 0uy
    [<Literal>]
    let Individual = 4uy
    [<Literal>]
    let HighVisibility = 5uy
    [<Literal>]
    let Trail = 6uy

  module CommTimeoutType =
    [<Literal>]
    let WildcardPairingTimeout = 0us
    [<Literal>]
    let PairingTimeout = 1us
    [<Literal>]
    let ConnectionLost = 2us
    [<Literal>]
    let ConnectionTimeout = 3us

  module CameraOrientationType =
    [<Literal>]
    let CameraOrientation0 = 0uy
    [<Literal>]
    let CameraOrientation90 = 1uy
    [<Literal>]
    let CameraOrientation180 = 2uy
    [<Literal>]
    let CameraOrientation270 = 3uy

  module AttitudeStage =
    [<Literal>]
    let Failed = 0uy
    [<Literal>]
    let Aligning = 1uy
    [<Literal>]
    let Degraded = 2uy
    [<Literal>]
    let Valid = 3uy

  module AttitudeValidity =
    [<Literal>]
    let TrackAngleHeadingValid = 0x0001us
    [<Literal>]
    let PitchValid = 0x0002us
    [<Literal>]
    let RollValid = 0x0004us
    [<Literal>]
    let LateralBodyAccelValid = 0x0008us
    [<Literal>]
    let NormalBodyAccelValid = 0x0010us
    [<Literal>]
    let TurnRateValid = 0x0020us
    [<Literal>]
    let HwFail = 0x0040us
    [<Literal>]
    let MagInvalid = 0x0080us
    [<Literal>]
    let NoGps = 0x0100us
    [<Literal>]
    let GpsInvalid = 0x0200us
    [<Literal>]
    let SolutionCoasting = 0x0400us
    [<Literal>]
    let TrueTrackAngle = 0x0800us
    [<Literal>]
    let MagneticHeading = 0x1000us

  module AutoSyncFrequency =
    [<Literal>]
    let Never = 0uy
    [<Literal>]
    let Occasionally = 1uy
    [<Literal>]
    let Frequent = 2uy
    [<Literal>]
    let OnceADay = 3uy
    [<Literal>]
    let Remote = 4uy

  module ExdLayout =
    [<Literal>]
    let FullScreen = 0uy
    [<Literal>]
    let HalfVertical = 1uy
    [<Literal>]
    let HalfHorizontal = 2uy
    [<Literal>]
    let HalfVerticalRightSplit = 3uy
    [<Literal>]
    let HalfHorizontalBottomSplit = 4uy
    [<Literal>]
    let FullQuarterSplit = 5uy
    [<Literal>]
    let HalfVerticalLeftSplit = 6uy
    [<Literal>]
    let HalfHorizontalTopSplit = 7uy

  module ExdDisplayType =
    [<Literal>]
    let Numerical = 0uy
    [<Literal>]
    let Simple = 1uy
    [<Literal>]
    let Graph = 2uy
    [<Literal>]
    let Bar = 3uy
    [<Literal>]
    let CircleGraph = 4uy
    [<Literal>]
    let VirtualPartner = 5uy
    [<Literal>]
    let Balance = 6uy
    [<Literal>]
    let StringList = 7uy
    [<Literal>]
    let String = 8uy
    [<Literal>]
    let SimpleDynamicIcon = 9uy
    [<Literal>]
    let Gauge = 10uy

  module ExdDataUnits =
    [<Literal>]
    let NoUnits = 0uy
    [<Literal>]
    let Laps = 1uy
    [<Literal>]
    let MilesPerHour = 2uy
    [<Literal>]
    let KilometersPerHour = 3uy
    [<Literal>]
    let FeetPerHour = 4uy
    [<Literal>]
    let MetersPerHour = 5uy
    [<Literal>]
    let DegreesCelsius = 6uy
    [<Literal>]
    let DegreesFarenheit = 7uy
    [<Literal>]
    let Zone = 8uy
    [<Literal>]
    let Gear = 9uy
    [<Literal>]
    let Rpm = 10uy
    [<Literal>]
    let Bpm = 11uy
    [<Literal>]
    let Degrees = 12uy
    [<Literal>]
    let Millimeters = 13uy
    [<Literal>]
    let Meters = 14uy
    [<Literal>]
    let Kilometers = 15uy
    [<Literal>]
    let Feet = 16uy
    [<Literal>]
    let Yards = 17uy
    [<Literal>]
    let Kilofeet = 18uy
    [<Literal>]
    let Miles = 19uy
    [<Literal>]
    let Time = 20uy
    [<Literal>]
    let EnumTurnType = 21uy
    [<Literal>]
    let Percent = 22uy
    [<Literal>]
    let Watts = 23uy
    [<Literal>]
    let WattsPerKilogram = 24uy
    [<Literal>]
    let EnumBatteryStatus = 25uy
    [<Literal>]
    let EnumBikeLightBeamAngleMode = 26uy
    [<Literal>]
    let EnumBikeLightBatteryStatus = 27uy
    [<Literal>]
    let EnumBikeLightNetworkConfigType = 28uy
    [<Literal>]
    let Lights = 29uy
    [<Literal>]
    let Seconds = 30uy
    [<Literal>]
    let Minutes = 31uy
    [<Literal>]
    let Hours = 32uy
    [<Literal>]
    let Calories = 33uy
    [<Literal>]
    let Kilojoules = 34uy
    [<Literal>]
    let Milliseconds = 35uy
    [<Literal>]
    let SecondPerMile = 36uy
    [<Literal>]
    let SecondPerKilometer = 37uy
    [<Literal>]
    let Centimeter = 38uy
    [<Literal>]
    let EnumCoursePoint = 39uy
    [<Literal>]
    let Bradians = 40uy
    [<Literal>]
    let EnumSport = 41uy
    [<Literal>]
    let InchesHg = 42uy
    [<Literal>]
    let MmHg = 43uy
    [<Literal>]
    let Mbars = 44uy
    [<Literal>]
    let HectoPascals = 45uy
    [<Literal>]
    let FeetPerMin = 46uy
    [<Literal>]
    let MetersPerMin = 47uy
    [<Literal>]
    let MetersPerSec = 48uy
    [<Literal>]
    let EightCardinal = 49uy

  module ExdQualifiers =
    [<Literal>]
    let NoQualifier = 0uy
    [<Literal>]
    let Instantaneous = 1uy
    [<Literal>]
    let Average = 2uy
    [<Literal>]
    let Lap = 3uy
    [<Literal>]
    let Maximum = 4uy
    [<Literal>]
    let MaximumAverage = 5uy
    [<Literal>]
    let MaximumLap = 6uy
    [<Literal>]
    let LastLap = 7uy
    [<Literal>]
    let AverageLap = 8uy
    [<Literal>]
    let ToDestination = 9uy
    [<Literal>]
    let ToGo = 10uy
    [<Literal>]
    let ToNext = 11uy
    [<Literal>]
    let NextCoursePoint = 12uy
    [<Literal>]
    let Total = 13uy
    [<Literal>]
    let ThreeSecondAverage = 14uy
    [<Literal>]
    let TenSecondAverage = 15uy
    [<Literal>]
    let ThirtySecondAverage = 16uy
    [<Literal>]
    let PercentMaximum = 17uy
    [<Literal>]
    let PercentMaximumAverage = 18uy
    [<Literal>]
    let LapPercentMaximum = 19uy
    [<Literal>]
    let Elapsed = 20uy
    [<Literal>]
    let Sunrise = 21uy
    [<Literal>]
    let Sunset = 22uy
    [<Literal>]
    let ComparedToVirtualPartner = 23uy
    [<Literal>]
    let Maximum24h = 24uy
    [<Literal>]
    let Minimum24h = 25uy
    [<Literal>]
    let Minimum = 26uy
    [<Literal>]
    let First = 27uy
    [<Literal>]
    let Second = 28uy
    [<Literal>]
    let Third = 29uy
    [<Literal>]
    let Shifter = 30uy
    [<Literal>]
    let LastSport = 31uy
    [<Literal>]
    let Moving = 32uy
    [<Literal>]
    let Stopped = 33uy
    [<Literal>]
    let EstimatedTotal = 34uy
    [<Literal>]
    let Zone9 = 242uy
    [<Literal>]
    let Zone8 = 243uy
    [<Literal>]
    let Zone7 = 244uy
    [<Literal>]
    let Zone6 = 245uy
    [<Literal>]
    let Zone5 = 246uy
    [<Literal>]
    let Zone4 = 247uy
    [<Literal>]
    let Zone3 = 248uy
    [<Literal>]
    let Zone2 = 249uy
    [<Literal>]
    let Zone1 = 250uy

  module ExdDescriptors =
    [<Literal>]
    let BikeLightBatteryStatus = 0uy
    [<Literal>]
    let BeamAngleStatus = 1uy
    [<Literal>]
    let BateryLevel = 2uy
    [<Literal>]
    let LightNetworkMode = 3uy
    [<Literal>]
    let NumberLightsConnected = 4uy
    [<Literal>]
    let Cadence = 5uy
    [<Literal>]
    let Distance = 6uy
    [<Literal>]
    let EstimatedTimeOfArrival = 7uy
    [<Literal>]
    let Heading = 8uy
    [<Literal>]
    let Time = 9uy
    [<Literal>]
    let BatteryLevel = 10uy
    [<Literal>]
    let TrainerResistance = 11uy
    [<Literal>]
    let TrainerTargetPower = 12uy
    [<Literal>]
    let TimeSeated = 13uy
    [<Literal>]
    let TimeStanding = 14uy
    [<Literal>]
    let Elevation = 15uy
    [<Literal>]
    let Grade = 16uy
    [<Literal>]
    let Ascent = 17uy
    [<Literal>]
    let Descent = 18uy
    [<Literal>]
    let VerticalSpeed = 19uy
    [<Literal>]
    let Di2BatteryLevel = 20uy
    [<Literal>]
    let FrontGear = 21uy
    [<Literal>]
    let RearGear = 22uy
    [<Literal>]
    let GearRatio = 23uy
    [<Literal>]
    let HeartRate = 24uy
    [<Literal>]
    let HeartRateZone = 25uy
    [<Literal>]
    let TimeInHeartRateZone = 26uy
    [<Literal>]
    let HeartRateReserve = 27uy
    [<Literal>]
    let Calories = 28uy
    [<Literal>]
    let GpsAccuracy = 29uy
    [<Literal>]
    let GpsSignalStrength = 30uy
    [<Literal>]
    let Temperature = 31uy
    [<Literal>]
    let TimeOfDay = 32uy
    [<Literal>]
    let Balance = 33uy
    [<Literal>]
    let PedalSmoothness = 34uy
    [<Literal>]
    let Power = 35uy
    [<Literal>]
    let FunctionalThresholdPower = 36uy
    [<Literal>]
    let IntensityFactor = 37uy
    [<Literal>]
    let Work = 38uy
    [<Literal>]
    let PowerRatio = 39uy
    [<Literal>]
    let NormalizedPower = 40uy
    [<Literal>]
    let TrainingStressScore = 41uy
    [<Literal>]
    let TimeOnZone = 42uy
    [<Literal>]
    let Speed = 43uy
    [<Literal>]
    let Laps = 44uy
    [<Literal>]
    let Reps = 45uy
    [<Literal>]
    let WorkoutStep = 46uy
    [<Literal>]
    let CourseDistance = 47uy
    [<Literal>]
    let NavigationDistance = 48uy
    [<Literal>]
    let CourseEstimatedTimeOfArrival = 49uy
    [<Literal>]
    let NavigationEstimatedTimeOfArrival = 50uy
    [<Literal>]
    let CourseTime = 51uy
    [<Literal>]
    let NavigationTime = 52uy
    [<Literal>]
    let CourseHeading = 53uy
    [<Literal>]
    let NavigationHeading = 54uy
    [<Literal>]
    let PowerZone = 55uy
    [<Literal>]
    let TorqueEffectiveness = 56uy
    [<Literal>]
    let TimerTime = 57uy
    [<Literal>]
    let PowerWeightRatio = 58uy
    [<Literal>]
    let LeftPlatformCenterOffset = 59uy
    [<Literal>]
    let RightPlatformCenterOffset = 60uy
    [<Literal>]
    let LeftPowerPhaseStartAngle = 61uy
    [<Literal>]
    let RightPowerPhaseStartAngle = 62uy
    [<Literal>]
    let LeftPowerPhaseFinishAngle = 63uy
    [<Literal>]
    let RightPowerPhaseFinishAngle = 64uy
    [<Literal>]
    let Gears = 65uy
    [<Literal>]
    let Pace = 66uy
    [<Literal>]
    let TrainingEffect = 67uy
    [<Literal>]
    let VerticalOscillation = 68uy
    [<Literal>]
    let VerticalRatio = 69uy
    [<Literal>]
    let GroundContactTime = 70uy
    [<Literal>]
    let LeftGroundContactTimeBalance = 71uy
    [<Literal>]
    let RightGroundContactTimeBalance = 72uy
    [<Literal>]
    let StrideLength = 73uy
    [<Literal>]
    let RunningCadence = 74uy
    [<Literal>]
    let PerformanceCondition = 75uy
    [<Literal>]
    let CourseType = 76uy
    [<Literal>]
    let TimeInPowerZone = 77uy
    [<Literal>]
    let NavigationTurn = 78uy
    [<Literal>]
    let CourseLocation = 79uy
    [<Literal>]
    let NavigationLocation = 80uy
    [<Literal>]
    let Compass = 81uy
    [<Literal>]
    let GearCombo = 82uy
    [<Literal>]
    let MuscleOxygen = 83uy
    [<Literal>]
    let Icon = 84uy
    [<Literal>]
    let CompassHeading = 85uy
    [<Literal>]
    let GpsHeading = 86uy
    [<Literal>]
    let GpsElevation = 87uy
    [<Literal>]
    let AnaerobicTrainingEffect = 88uy
    [<Literal>]
    let Course = 89uy
    [<Literal>]
    let OffCourse = 90uy
    [<Literal>]
    let GlideRatio = 91uy
    [<Literal>]
    let VerticalDistance = 92uy
    [<Literal>]
    let Vmg = 93uy
    [<Literal>]
    let AmbientPressure = 94uy
    [<Literal>]
    let Pressure = 95uy
    [<Literal>]
    let Vam = 96uy

  module AutoActivityDetect =
    [<Literal>]
    let None = 0x00000000u
    [<Literal>]
    let Running = 0x00000001u
    [<Literal>]
    let Cycling = 0x00000002u
    [<Literal>]
    let Swimming = 0x00000004u
    [<Literal>]
    let Walking = 0x00000008u
    [<Literal>]
    let Elliptical = 0x00000020u
    [<Literal>]
    let Sedentary = 0x00000400u

  module SupportedExdScreenLayouts =
    [<Literal>]
    let FullScreen = 0x00000001u
    [<Literal>]
    let HalfVertical = 0x00000002u
    [<Literal>]
    let HalfHorizontal = 0x00000004u
    [<Literal>]
    let HalfVerticalRightSplit = 0x00000008u
    [<Literal>]
    let HalfHorizontalBottomSplit = 0x00000010u
    [<Literal>]
    let FullQuarterSplit = 0x00000020u
    [<Literal>]
    let HalfVerticalLeftSplit = 0x00000040u
    [<Literal>]
    let HalfHorizontalTopSplit = 0x00000080u

  module FitBaseType =
    [<Literal>]
    let Enum = 0uy
    [<Literal>]
    let Sint8 = 1uy
    [<Literal>]
    let Uint8 = 2uy
    [<Literal>]
    let Sint16 = 131uy
    [<Literal>]
    let Uint16 = 132uy
    [<Literal>]
    let Sint32 = 133uy
    [<Literal>]
    let Uint32 = 134uy
    [<Literal>]
    let String = 7uy
    [<Literal>]
    let Float32 = 136uy
    [<Literal>]
    let Float64 = 137uy
    [<Literal>]
    let Uint8z = 10uy
    [<Literal>]
    let Uint16z = 139uy
    [<Literal>]
    let Uint32z = 140uy
    [<Literal>]
    let Byte = 13uy
    [<Literal>]
    let Sint64 = 142uy
    [<Literal>]
    let Uint64 = 143uy
    [<Literal>]
    let Uint64z = 144uy

  module TurnType =
    [<Literal>]
    let ArrivingIdx = 0uy
    [<Literal>]
    let ArrivingLeftIdx = 1uy
    [<Literal>]
    let ArrivingRightIdx = 2uy
    [<Literal>]
    let ArrivingViaIdx = 3uy
    [<Literal>]
    let ArrivingViaLeftIdx = 4uy
    [<Literal>]
    let ArrivingViaRightIdx = 5uy
    [<Literal>]
    let BearKeepLeftIdx = 6uy
    [<Literal>]
    let BearKeepRightIdx = 7uy
    [<Literal>]
    let ContinueIdx = 8uy
    [<Literal>]
    let ExitLeftIdx = 9uy
    [<Literal>]
    let ExitRightIdx = 10uy
    [<Literal>]
    let FerryIdx = 11uy
    [<Literal>]
    let Roundabout45Idx = 12uy
    [<Literal>]
    let Roundabout90Idx = 13uy
    [<Literal>]
    let Roundabout135Idx = 14uy
    [<Literal>]
    let Roundabout180Idx = 15uy
    [<Literal>]
    let Roundabout225Idx = 16uy
    [<Literal>]
    let Roundabout270Idx = 17uy
    [<Literal>]
    let Roundabout315Idx = 18uy
    [<Literal>]
    let Roundabout360Idx = 19uy
    [<Literal>]
    let RoundaboutNeg45Idx = 20uy
    [<Literal>]
    let RoundaboutNeg90Idx = 21uy
    [<Literal>]
    let RoundaboutNeg135Idx = 22uy
    [<Literal>]
    let RoundaboutNeg180Idx = 23uy
    [<Literal>]
    let RoundaboutNeg225Idx = 24uy
    [<Literal>]
    let RoundaboutNeg270Idx = 25uy
    [<Literal>]
    let RoundaboutNeg315Idx = 26uy
    [<Literal>]
    let RoundaboutNeg360Idx = 27uy
    [<Literal>]
    let RoundaboutGenericIdx = 28uy
    [<Literal>]
    let RoundaboutNegGenericIdx = 29uy
    [<Literal>]
    let SharpTurnLeftIdx = 30uy
    [<Literal>]
    let SharpTurnRightIdx = 31uy
    [<Literal>]
    let TurnLeftIdx = 32uy
    [<Literal>]
    let TurnRightIdx = 33uy
    [<Literal>]
    let UturnLeftIdx = 34uy
    [<Literal>]
    let UturnRightIdx = 35uy
    [<Literal>]
    let IconInvIdx = 36uy
    [<Literal>]
    let IconIdxCnt = 37uy

  module BikeLightBeamAngleMode =
    [<Literal>]
    let Manual = 0uy
    [<Literal>]
    let Auto = 1uy

  module FitBaseUnit =
    [<Literal>]
    let Other = 0us
    [<Literal>]
    let Kilogram = 1us
    [<Literal>]
    let Pound = 2us

  module SetType =
    [<Literal>]
    let Rest = 0uy
    [<Literal>]
    let Active = 1uy

  module ExerciseCategory =
    [<Literal>]
    let BenchPress = 0us
    [<Literal>]
    let CalfRaise = 1us
    [<Literal>]
    let Cardio = 2us
    [<Literal>]
    let Carry = 3us
    [<Literal>]
    let Chop = 4us
    [<Literal>]
    let Core = 5us
    [<Literal>]
    let Crunch = 6us
    [<Literal>]
    let Curl = 7us
    [<Literal>]
    let Deadlift = 8us
    [<Literal>]
    let Flye = 9us
    [<Literal>]
    let HipRaise = 10us
    [<Literal>]
    let HipStability = 11us
    [<Literal>]
    let HipSwing = 12us
    [<Literal>]
    let Hyperextension = 13us
    [<Literal>]
    let LateralRaise = 14us
    [<Literal>]
    let LegCurl = 15us
    [<Literal>]
    let LegRaise = 16us
    [<Literal>]
    let Lunge = 17us
    [<Literal>]
    let OlympicLift = 18us
    [<Literal>]
    let Plank = 19us
    [<Literal>]
    let Plyo = 20us
    [<Literal>]
    let PullUp = 21us
    [<Literal>]
    let PushUp = 22us
    [<Literal>]
    let Row = 23us
    [<Literal>]
    let ShoulderPress = 24us
    [<Literal>]
    let ShoulderStability = 25us
    [<Literal>]
    let Shrug = 26us
    [<Literal>]
    let SitUp = 27us
    [<Literal>]
    let Squat = 28us
    [<Literal>]
    let TotalBody = 29us
    [<Literal>]
    let TricepsExtension = 30us
    [<Literal>]
    let WarmUp = 31us
    [<Literal>]
    let Run = 32us
    [<Literal>]
    let Unknown = 65534us

  module BenchPressExerciseName =
    [<Literal>]
    let AlternatingDumbbellChestPressOnSwissBall = 0us
    [<Literal>]
    let BarbellBenchPress = 1us
    [<Literal>]
    let BarbellBoardBenchPress = 2us
    [<Literal>]
    let BarbellFloorPress = 3us
    [<Literal>]
    let CloseGripBarbellBenchPress = 4us
    [<Literal>]
    let DeclineDumbbellBenchPress = 5us
    [<Literal>]
    let DumbbellBenchPress = 6us
    [<Literal>]
    let DumbbellFloorPress = 7us
    [<Literal>]
    let InclineBarbellBenchPress = 8us
    [<Literal>]
    let InclineDumbbellBenchPress = 9us
    [<Literal>]
    let InclineSmithMachineBenchPress = 10us
    [<Literal>]
    let IsometricBarbellBenchPress = 11us
    [<Literal>]
    let KettlebellChestPress = 12us
    [<Literal>]
    let NeutralGripDumbbellBenchPress = 13us
    [<Literal>]
    let NeutralGripDumbbellInclineBenchPress = 14us
    [<Literal>]
    let OneArmFloorPress = 15us
    [<Literal>]
    let WeightedOneArmFloorPress = 16us
    [<Literal>]
    let PartialLockout = 17us
    [<Literal>]
    let ReverseGripBarbellBenchPress = 18us
    [<Literal>]
    let ReverseGripInclineBenchPress = 19us
    [<Literal>]
    let SingleArmCableChestPress = 20us
    [<Literal>]
    let SingleArmDumbbellBenchPress = 21us
    [<Literal>]
    let SmithMachineBenchPress = 22us
    [<Literal>]
    let SwissBallDumbbellChestPress = 23us
    [<Literal>]
    let TripleStopBarbellBenchPress = 24us
    [<Literal>]
    let WideGripBarbellBenchPress = 25us
    [<Literal>]
    let AlternatingDumbbellChestPress = 26us

  module CalfRaiseExerciseName =
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _3WayCalfRaise = 0us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _3WayWeightedCalfRaise = 1us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _3WaySingleLegCalfRaise = 2us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _3WayWeightedSingleLegCalfRaise = 3us
    [<Literal>]
    let DonkeyCalfRaise = 4us
    [<Literal>]
    let WeightedDonkeyCalfRaise = 5us
    [<Literal>]
    let SeatedCalfRaise = 6us
    [<Literal>]
    let WeightedSeatedCalfRaise = 7us
    [<Literal>]
    let SeatedDumbbellToeRaise = 8us
    [<Literal>]
    let SingleLegBentKneeCalfRaise = 9us
    [<Literal>]
    let WeightedSingleLegBentKneeCalfRaise = 10us
    [<Literal>]
    let SingleLegDeclinePushUp = 11us
    [<Literal>]
    let SingleLegDonkeyCalfRaise = 12us
    [<Literal>]
    let WeightedSingleLegDonkeyCalfRaise = 13us
    [<Literal>]
    let SingleLegHipRaiseWithKneeHold = 14us
    [<Literal>]
    let SingleLegStandingCalfRaise = 15us
    [<Literal>]
    let SingleLegStandingDumbbellCalfRaise = 16us
    [<Literal>]
    let StandingBarbellCalfRaise = 17us
    [<Literal>]
    let StandingCalfRaise = 18us
    [<Literal>]
    let WeightedStandingCalfRaise = 19us
    [<Literal>]
    let StandingDumbbellCalfRaise = 20us

  module CardioExerciseName =
    [<Literal>]
    let BobAndWeaveCircle = 0us
    [<Literal>]
    let WeightedBobAndWeaveCircle = 1us
    [<Literal>]
    let CardioCoreCrawl = 2us
    [<Literal>]
    let WeightedCardioCoreCrawl = 3us
    [<Literal>]
    let DoubleUnder = 4us
    [<Literal>]
    let WeightedDoubleUnder = 5us
    [<Literal>]
    let JumpRope = 6us
    [<Literal>]
    let WeightedJumpRope = 7us
    [<Literal>]
    let JumpRopeCrossover = 8us
    [<Literal>]
    let WeightedJumpRopeCrossover = 9us
    [<Literal>]
    let JumpRopeJog = 10us
    [<Literal>]
    let WeightedJumpRopeJog = 11us
    [<Literal>]
    let JumpingJacks = 12us
    [<Literal>]
    let WeightedJumpingJacks = 13us
    [<Literal>]
    let SkiMoguls = 14us
    [<Literal>]
    let WeightedSkiMoguls = 15us
    [<Literal>]
    let SplitJacks = 16us
    [<Literal>]
    let WeightedSplitJacks = 17us
    [<Literal>]
    let SquatJacks = 18us
    [<Literal>]
    let WeightedSquatJacks = 19us
    [<Literal>]
    let TripleUnder = 20us
    [<Literal>]
    let WeightedTripleUnder = 21us

  module CarryExerciseName =
    [<Literal>]
    let BarHolds = 0us
    [<Literal>]
    let FarmersWalk = 1us
    [<Literal>]
    let FarmersWalkOnToes = 2us
    [<Literal>]
    let HexDumbbellHold = 3us
    [<Literal>]
    let OverheadCarry = 4us

  module ChopExerciseName =
    [<Literal>]
    let CablePullThrough = 0us
    [<Literal>]
    let CableRotationalLift = 1us
    [<Literal>]
    let CableWoodchop = 2us
    [<Literal>]
    let CrossChopToKnee = 3us
    [<Literal>]
    let WeightedCrossChopToKnee = 4us
    [<Literal>]
    let DumbbellChop = 5us
    [<Literal>]
    let HalfKneelingRotation = 6us
    [<Literal>]
    let WeightedHalfKneelingRotation = 7us
    [<Literal>]
    let HalfKneelingRotationalChop = 8us
    [<Literal>]
    let HalfKneelingRotationalReverseChop = 9us
    [<Literal>]
    let HalfKneelingStabilityChop = 10us
    [<Literal>]
    let HalfKneelingStabilityReverseChop = 11us
    [<Literal>]
    let KneelingRotationalChop = 12us
    [<Literal>]
    let KneelingRotationalReverseChop = 13us
    [<Literal>]
    let KneelingStabilityChop = 14us
    [<Literal>]
    let KneelingWoodchopper = 15us
    [<Literal>]
    let MedicineBallWoodChops = 16us
    [<Literal>]
    let PowerSquatChops = 17us
    [<Literal>]
    let WeightedPowerSquatChops = 18us
    [<Literal>]
    let StandingRotationalChop = 19us
    [<Literal>]
    let StandingSplitRotationalChop = 20us
    [<Literal>]
    let StandingSplitRotationalReverseChop = 21us
    [<Literal>]
    let StandingStabilityReverseChop = 22us

  module CoreExerciseName =
    [<Literal>]
    let AbsJabs = 0us
    [<Literal>]
    let WeightedAbsJabs = 1us
    [<Literal>]
    let AlternatingPlateReach = 2us
    [<Literal>]
    let BarbellRollout = 3us
    [<Literal>]
    let WeightedBarbellRollout = 4us
    [<Literal>]
    let BodyBarObliqueTwist = 5us
    [<Literal>]
    let CableCorePress = 6us
    [<Literal>]
    let CableSideBend = 7us
    [<Literal>]
    let SideBend = 8us
    [<Literal>]
    let WeightedSideBend = 9us
    [<Literal>]
    let CrescentCircle = 10us
    [<Literal>]
    let WeightedCrescentCircle = 11us
    [<Literal>]
    let CyclingRussianTwist = 12us
    [<Literal>]
    let WeightedCyclingRussianTwist = 13us
    [<Literal>]
    let ElevatedFeetRussianTwist = 14us
    [<Literal>]
    let WeightedElevatedFeetRussianTwist = 15us
    [<Literal>]
    let HalfTurkishGetUp = 16us
    [<Literal>]
    let KettlebellWindmill = 17us
    [<Literal>]
    let KneelingAbWheel = 18us
    [<Literal>]
    let WeightedKneelingAbWheel = 19us
    [<Literal>]
    let ModifiedFrontLever = 20us
    [<Literal>]
    let OpenKneeTucks = 21us
    [<Literal>]
    let WeightedOpenKneeTucks = 22us
    [<Literal>]
    let SideAbsLegLift = 23us
    [<Literal>]
    let WeightedSideAbsLegLift = 24us
    [<Literal>]
    let SwissBallJackknife = 25us
    [<Literal>]
    let WeightedSwissBallJackknife = 26us
    [<Literal>]
    let SwissBallPike = 27us
    [<Literal>]
    let WeightedSwissBallPike = 28us
    [<Literal>]
    let SwissBallRollout = 29us
    [<Literal>]
    let WeightedSwissBallRollout = 30us
    [<Literal>]
    let TriangleHipPress = 31us
    [<Literal>]
    let WeightedTriangleHipPress = 32us
    [<Literal>]
    let TrxSuspendedJackknife = 33us
    [<Literal>]
    let WeightedTrxSuspendedJackknife = 34us
    [<Literal>]
    let UBoat = 35us
    [<Literal>]
    let WeightedUBoat = 36us
    [<Literal>]
    let WindmillSwitches = 37us
    [<Literal>]
    let WeightedWindmillSwitches = 38us
    [<Literal>]
    let AlternatingSlideOut = 39us
    [<Literal>]
    let WeightedAlternatingSlideOut = 40us
    [<Literal>]
    let GhdBackExtensions = 41us
    [<Literal>]
    let WeightedGhdBackExtensions = 42us
    [<Literal>]
    let OverheadWalk = 43us
    [<Literal>]
    let Inchworm = 44us
    [<Literal>]
    let WeightedModifiedFrontLever = 45us
    [<Literal>]
    let RussianTwist = 46us
    [<Literal>]
    let AbdominalLegRotations = 47us
    [<Literal>]
    let ArmAndLegExtensionOnKnees = 48us
    [<Literal>]
    let Bicycle = 49us
    [<Literal>]
    let BicepCurlWithLegExtension = 50us
    [<Literal>]
    let CatCow = 51us
    [<Literal>]
    let Corkscrew = 52us
    [<Literal>]
    let CrissCross = 53us
    [<Literal>]
    let CrissCrossWithBall = 54us
    [<Literal>]
    let DoubleLegStretch = 55us
    [<Literal>]
    let KneeFolds = 56us
    [<Literal>]
    let LowerLift = 57us
    [<Literal>]
    let NeckPull = 58us
    [<Literal>]
    let PelvicClocks = 59us
    [<Literal>]
    let RollOver = 60us
    [<Literal>]
    let RollUp = 61us
    [<Literal>]
    let Rolling = 62us
    [<Literal>]
    let Rowing1 = 63us
    [<Literal>]
    let Rowing2 = 64us
    [<Literal>]
    let Scissors = 65us
    [<Literal>]
    let SingleLegCircles = 66us
    [<Literal>]
    let SingleLegStretch = 67us
    [<Literal>]
    let SnakeTwist1And2 = 68us
    [<Literal>]
    let Swan = 69us
    [<Literal>]
    let Swimming = 70us
    [<Literal>]
    let Teaser = 71us
    [<Literal>]
    let TheHundred = 72us

  module CrunchExerciseName =
    [<Literal>]
    let BicycleCrunch = 0us
    [<Literal>]
    let CableCrunch = 1us
    [<Literal>]
    let CircularArmCrunch = 2us
    [<Literal>]
    let CrossedArmsCrunch = 3us
    [<Literal>]
    let WeightedCrossedArmsCrunch = 4us
    [<Literal>]
    let CrossLegReverseCrunch = 5us
    [<Literal>]
    let WeightedCrossLegReverseCrunch = 6us
    [<Literal>]
    let CrunchChop = 7us
    [<Literal>]
    let WeightedCrunchChop = 8us
    [<Literal>]
    let DoubleCrunch = 9us
    [<Literal>]
    let WeightedDoubleCrunch = 10us
    [<Literal>]
    let ElbowToKneeCrunch = 11us
    [<Literal>]
    let WeightedElbowToKneeCrunch = 12us
    [<Literal>]
    let FlutterKicks = 13us
    [<Literal>]
    let WeightedFlutterKicks = 14us
    [<Literal>]
    let FoamRollerReverseCrunchOnBench = 15us
    [<Literal>]
    let WeightedFoamRollerReverseCrunchOnBench = 16us
    [<Literal>]
    let FoamRollerReverseCrunchWithDumbbell = 17us
    [<Literal>]
    let FoamRollerReverseCrunchWithMedicineBall = 18us
    [<Literal>]
    let FrogPress = 19us
    [<Literal>]
    let HangingKneeRaiseObliqueCrunch = 20us
    [<Literal>]
    let WeightedHangingKneeRaiseObliqueCrunch = 21us
    [<Literal>]
    let HipCrossover = 22us
    [<Literal>]
    let WeightedHipCrossover = 23us
    [<Literal>]
    let HollowRock = 24us
    [<Literal>]
    let WeightedHollowRock = 25us
    [<Literal>]
    let InclineReverseCrunch = 26us
    [<Literal>]
    let WeightedInclineReverseCrunch = 27us
    [<Literal>]
    let KneelingCableCrunch = 28us
    [<Literal>]
    let KneelingCrossCrunch = 29us
    [<Literal>]
    let WeightedKneelingCrossCrunch = 30us
    [<Literal>]
    let KneelingObliqueCableCrunch = 31us
    [<Literal>]
    let KneesToElbow = 32us
    [<Literal>]
    let LegExtensions = 33us
    [<Literal>]
    let WeightedLegExtensions = 34us
    [<Literal>]
    let LegLevers = 35us
    [<Literal>]
    let McgillCurlUp = 36us
    [<Literal>]
    let WeightedMcgillCurlUp = 37us
    [<Literal>]
    let ModifiedPilatesRollUpWithBall = 38us
    [<Literal>]
    let WeightedModifiedPilatesRollUpWithBall = 39us
    [<Literal>]
    let PilatesCrunch = 40us
    [<Literal>]
    let WeightedPilatesCrunch = 41us
    [<Literal>]
    let PilatesRollUpWithBall = 42us
    [<Literal>]
    let WeightedPilatesRollUpWithBall = 43us
    [<Literal>]
    let RaisedLegsCrunch = 44us
    [<Literal>]
    let WeightedRaisedLegsCrunch = 45us
    [<Literal>]
    let ReverseCrunch = 46us
    [<Literal>]
    let WeightedReverseCrunch = 47us
    [<Literal>]
    let ReverseCrunchOnABench = 48us
    [<Literal>]
    let WeightedReverseCrunchOnABench = 49us
    [<Literal>]
    let ReverseCurlAndLift = 50us
    [<Literal>]
    let WeightedReverseCurlAndLift = 51us
    [<Literal>]
    let RotationalLift = 52us
    [<Literal>]
    let WeightedRotationalLift = 53us
    [<Literal>]
    let SeatedAlternatingReverseCrunch = 54us
    [<Literal>]
    let WeightedSeatedAlternatingReverseCrunch = 55us
    [<Literal>]
    let SeatedLegU = 56us
    [<Literal>]
    let WeightedSeatedLegU = 57us
    [<Literal>]
    let SideToSideCrunchAndWeave = 58us
    [<Literal>]
    let WeightedSideToSideCrunchAndWeave = 59us
    [<Literal>]
    let SingleLegReverseCrunch = 60us
    [<Literal>]
    let WeightedSingleLegReverseCrunch = 61us
    [<Literal>]
    let SkaterCrunchCross = 62us
    [<Literal>]
    let WeightedSkaterCrunchCross = 63us
    [<Literal>]
    let StandingCableCrunch = 64us
    [<Literal>]
    let StandingSideCrunch = 65us
    [<Literal>]
    let StepClimb = 66us
    [<Literal>]
    let WeightedStepClimb = 67us
    [<Literal>]
    let SwissBallCrunch = 68us
    [<Literal>]
    let SwissBallReverseCrunch = 69us
    [<Literal>]
    let WeightedSwissBallReverseCrunch = 70us
    [<Literal>]
    let SwissBallRussianTwist = 71us
    [<Literal>]
    let WeightedSwissBallRussianTwist = 72us
    [<Literal>]
    let SwissBallSideCrunch = 73us
    [<Literal>]
    let WeightedSwissBallSideCrunch = 74us
    [<Literal>]
    let ThoracicCrunchesOnFoamRoller = 75us
    [<Literal>]
    let WeightedThoracicCrunchesOnFoamRoller = 76us
    [<Literal>]
    let TricepsCrunch = 77us
    [<Literal>]
    let WeightedBicycleCrunch = 78us
    [<Literal>]
    let WeightedCrunch = 79us
    [<Literal>]
    let WeightedSwissBallCrunch = 80us
    [<Literal>]
    let ToesToBar = 81us
    [<Literal>]
    let WeightedToesToBar = 82us
    [<Literal>]
    let Crunch = 83us
    [<Literal>]
    let StraightLegCrunchWithBall = 84us

  module CurlExerciseName =
    [<Literal>]
    let AlternatingDumbbellBicepsCurl = 0us
    [<Literal>]
    let AlternatingDumbbellBicepsCurlOnSwissBall = 1us
    [<Literal>]
    let AlternatingInclineDumbbellBicepsCurl = 2us
    [<Literal>]
    let BarbellBicepsCurl = 3us
    [<Literal>]
    let BarbellReverseWristCurl = 4us
    [<Literal>]
    let BarbellWristCurl = 5us
    [<Literal>]
    let BehindTheBackBarbellReverseWristCurl = 6us
    [<Literal>]
    let BehindTheBackOneArmCableCurl = 7us
    [<Literal>]
    let CableBicepsCurl = 8us
    [<Literal>]
    let CableHammerCurl = 9us
    [<Literal>]
    let CheatingBarbellBicepsCurl = 10us
    [<Literal>]
    let CloseGripEzBarBicepsCurl = 11us
    [<Literal>]
    let CrossBodyDumbbellHammerCurl = 12us
    [<Literal>]
    let DeadHangBicepsCurl = 13us
    [<Literal>]
    let DeclineHammerCurl = 14us
    [<Literal>]
    let DumbbellBicepsCurlWithStaticHold = 15us
    [<Literal>]
    let DumbbellHammerCurl = 16us
    [<Literal>]
    let DumbbellReverseWristCurl = 17us
    [<Literal>]
    let DumbbellWristCurl = 18us
    [<Literal>]
    let EzBarPreacherCurl = 19us
    [<Literal>]
    let ForwardBendBicepsCurl = 20us
    [<Literal>]
    let HammerCurlToPress = 21us
    [<Literal>]
    let InclineDumbbellBicepsCurl = 22us
    [<Literal>]
    let InclineOffsetThumbDumbbellCurl = 23us
    [<Literal>]
    let KettlebellBicepsCurl = 24us
    [<Literal>]
    let LyingConcentrationCableCurl = 25us
    [<Literal>]
    let OneArmPreacherCurl = 26us
    [<Literal>]
    let PlatePinchCurl = 27us
    [<Literal>]
    let PreacherCurlWithCable = 28us
    [<Literal>]
    let ReverseEzBarCurl = 29us
    [<Literal>]
    let ReverseGripWristCurl = 30us
    [<Literal>]
    let ReverseGripBarbellBicepsCurl = 31us
    [<Literal>]
    let SeatedAlternatingDumbbellBicepsCurl = 32us
    [<Literal>]
    let SeatedDumbbellBicepsCurl = 33us
    [<Literal>]
    let SeatedReverseDumbbellCurl = 34us
    [<Literal>]
    let SplitStanceOffsetPinkyDumbbellCurl = 35us
    [<Literal>]
    let StandingAlternatingDumbbellCurls = 36us
    [<Literal>]
    let StandingDumbbellBicepsCurl = 37us
    [<Literal>]
    let StandingEzBarBicepsCurl = 38us
    [<Literal>]
    let StaticCurl = 39us
    [<Literal>]
    let SwissBallDumbbellOverheadTricepsExtension = 40us
    [<Literal>]
    let SwissBallEzBarPreacherCurl = 41us
    [<Literal>]
    let TwistingStandingDumbbellBicepsCurl = 42us
    [<Literal>]
    let WideGripEzBarBicepsCurl = 43us

  module DeadliftExerciseName =
    [<Literal>]
    let BarbellDeadlift = 0us
    [<Literal>]
    let BarbellStraightLegDeadlift = 1us
    [<Literal>]
    let DumbbellDeadlift = 2us
    [<Literal>]
    let DumbbellSingleLegDeadliftToRow = 3us
    [<Literal>]
    let DumbbellStraightLegDeadlift = 4us
    [<Literal>]
    let KettlebellFloorToShelf = 5us
    [<Literal>]
    let OneArmOneLegDeadlift = 6us
    [<Literal>]
    let RackPull = 7us
    [<Literal>]
    let RotationalDumbbellStraightLegDeadlift = 8us
    [<Literal>]
    let SingleArmDeadlift = 9us
    [<Literal>]
    let SingleLegBarbellDeadlift = 10us
    [<Literal>]
    let SingleLegBarbellStraightLegDeadlift = 11us
    [<Literal>]
    let SingleLegDeadliftWithBarbell = 12us
    [<Literal>]
    let SingleLegRdlCircuit = 13us
    [<Literal>]
    let SingleLegRomanianDeadliftWithDumbbell = 14us
    [<Literal>]
    let SumoDeadlift = 15us
    [<Literal>]
    let SumoDeadliftHighPull = 16us
    [<Literal>]
    let TrapBarDeadlift = 17us
    [<Literal>]
    let WideGripBarbellDeadlift = 18us

  module FlyeExerciseName =
    [<Literal>]
    let CableCrossover = 0us
    [<Literal>]
    let DeclineDumbbellFlye = 1us
    [<Literal>]
    let DumbbellFlye = 2us
    [<Literal>]
    let InclineDumbbellFlye = 3us
    [<Literal>]
    let KettlebellFlye = 4us
    [<Literal>]
    let KneelingRearFlye = 5us
    [<Literal>]
    let SingleArmStandingCableReverseFlye = 6us
    [<Literal>]
    let SwissBallDumbbellFlye = 7us
    [<Literal>]
    let ArmRotations = 8us
    [<Literal>]
    let HugATree = 9us

  module HipRaiseExerciseName =
    [<Literal>]
    let BarbellHipThrustOnFloor = 0us
    [<Literal>]
    let BarbellHipThrustWithBench = 1us
    [<Literal>]
    let BentKneeSwissBallReverseHipRaise = 2us
    [<Literal>]
    let WeightedBentKneeSwissBallReverseHipRaise = 3us
    [<Literal>]
    let BridgeWithLegExtension = 4us
    [<Literal>]
    let WeightedBridgeWithLegExtension = 5us
    [<Literal>]
    let ClamBridge = 6us
    [<Literal>]
    let FrontKickTabletop = 7us
    [<Literal>]
    let WeightedFrontKickTabletop = 8us
    [<Literal>]
    let HipExtensionAndCross = 9us
    [<Literal>]
    let WeightedHipExtensionAndCross = 10us
    [<Literal>]
    let HipRaise = 11us
    [<Literal>]
    let WeightedHipRaise = 12us
    [<Literal>]
    let HipRaiseWithFeetOnSwissBall = 13us
    [<Literal>]
    let WeightedHipRaiseWithFeetOnSwissBall = 14us
    [<Literal>]
    let HipRaiseWithHeadOnBosuBall = 15us
    [<Literal>]
    let WeightedHipRaiseWithHeadOnBosuBall = 16us
    [<Literal>]
    let HipRaiseWithHeadOnSwissBall = 17us
    [<Literal>]
    let WeightedHipRaiseWithHeadOnSwissBall = 18us
    [<Literal>]
    let HipRaiseWithKneeSqueeze = 19us
    [<Literal>]
    let WeightedHipRaiseWithKneeSqueeze = 20us
    [<Literal>]
    let InclineRearLegExtension = 21us
    [<Literal>]
    let WeightedInclineRearLegExtension = 22us
    [<Literal>]
    let KettlebellSwing = 23us
    [<Literal>]
    let MarchingHipRaise = 24us
    [<Literal>]
    let WeightedMarchingHipRaise = 25us
    [<Literal>]
    let MarchingHipRaiseWithFeetOnASwissBall = 26us
    [<Literal>]
    let WeightedMarchingHipRaiseWithFeetOnASwissBall = 27us
    [<Literal>]
    let ReverseHipRaise = 28us
    [<Literal>]
    let WeightedReverseHipRaise = 29us
    [<Literal>]
    let SingleLegHipRaise = 30us
    [<Literal>]
    let WeightedSingleLegHipRaise = 31us
    [<Literal>]
    let SingleLegHipRaiseWithFootOnBench = 32us
    [<Literal>]
    let WeightedSingleLegHipRaiseWithFootOnBench = 33us
    [<Literal>]
    let SingleLegHipRaiseWithFootOnBosuBall = 34us
    [<Literal>]
    let WeightedSingleLegHipRaiseWithFootOnBosuBall = 35us
    [<Literal>]
    let SingleLegHipRaiseWithFootOnFoamRoller = 36us
    [<Literal>]
    let WeightedSingleLegHipRaiseWithFootOnFoamRoller = 37us
    [<Literal>]
    let SingleLegHipRaiseWithFootOnMedicineBall = 38us
    [<Literal>]
    let WeightedSingleLegHipRaiseWithFootOnMedicineBall = 39us
    [<Literal>]
    let SingleLegHipRaiseWithHeadOnBosuBall = 40us
    [<Literal>]
    let WeightedSingleLegHipRaiseWithHeadOnBosuBall = 41us
    [<Literal>]
    let WeightedClamBridge = 42us
    [<Literal>]
    let SingleLegSwissBallHipRaiseAndLegCurl = 43us
    [<Literal>]
    let Clams = 44us
    [<Literal>]
    let InnerThighCircles = 45us
    [<Literal>]
    let InnerThighSideLift = 46us
    [<Literal>]
    let LegCircles = 47us
    [<Literal>]
    let LegLift = 48us
    [<Literal>]
    let LegLiftInExternalRotation = 49us

  module HipStabilityExerciseName =
    [<Literal>]
    let BandSideLyingLegRaise = 0us
    [<Literal>]
    let DeadBug = 1us
    [<Literal>]
    let WeightedDeadBug = 2us
    [<Literal>]
    let ExternalHipRaise = 3us
    [<Literal>]
    let WeightedExternalHipRaise = 4us
    [<Literal>]
    let FireHydrantKicks = 5us
    [<Literal>]
    let WeightedFireHydrantKicks = 6us
    [<Literal>]
    let HipCircles = 7us
    [<Literal>]
    let WeightedHipCircles = 8us
    [<Literal>]
    let InnerThighLift = 9us
    [<Literal>]
    let WeightedInnerThighLift = 10us
    [<Literal>]
    let LateralWalksWithBandAtAnkles = 11us
    [<Literal>]
    let PretzelSideKick = 12us
    [<Literal>]
    let WeightedPretzelSideKick = 13us
    [<Literal>]
    let ProneHipInternalRotation = 14us
    [<Literal>]
    let WeightedProneHipInternalRotation = 15us
    [<Literal>]
    let Quadruped = 16us
    [<Literal>]
    let QuadrupedHipExtension = 17us
    [<Literal>]
    let WeightedQuadrupedHipExtension = 18us
    [<Literal>]
    let QuadrupedWithLegLift = 19us
    [<Literal>]
    let WeightedQuadrupedWithLegLift = 20us
    [<Literal>]
    let SideLyingLegRaise = 21us
    [<Literal>]
    let WeightedSideLyingLegRaise = 22us
    [<Literal>]
    let SlidingHipAdduction = 23us
    [<Literal>]
    let WeightedSlidingHipAdduction = 24us
    [<Literal>]
    let StandingAdduction = 25us
    [<Literal>]
    let WeightedStandingAdduction = 26us
    [<Literal>]
    let StandingCableHipAbduction = 27us
    [<Literal>]
    let StandingHipAbduction = 28us
    [<Literal>]
    let WeightedStandingHipAbduction = 29us
    [<Literal>]
    let StandingRearLegRaise = 30us
    [<Literal>]
    let WeightedStandingRearLegRaise = 31us
    [<Literal>]
    let SupineHipInternalRotation = 32us
    [<Literal>]
    let WeightedSupineHipInternalRotation = 33us

  module HipSwingExerciseName =
    [<Literal>]
    let SingleArmKettlebellSwing = 0us
    [<Literal>]
    let SingleArmDumbbellSwing = 1us
    [<Literal>]
    let StepOutSwing = 2us

  module HyperextensionExerciseName =
    [<Literal>]
    let BackExtensionWithOppositeArmAndLegReach = 0us
    [<Literal>]
    let WeightedBackExtensionWithOppositeArmAndLegReach = 1us
    [<Literal>]
    let BaseRotations = 2us
    [<Literal>]
    let WeightedBaseRotations = 3us
    [<Literal>]
    let BentKneeReverseHyperextension = 4us
    [<Literal>]
    let WeightedBentKneeReverseHyperextension = 5us
    [<Literal>]
    let HollowHoldAndRoll = 6us
    [<Literal>]
    let WeightedHollowHoldAndRoll = 7us
    [<Literal>]
    let Kicks = 8us
    [<Literal>]
    let WeightedKicks = 9us
    [<Literal>]
    let KneeRaises = 10us
    [<Literal>]
    let WeightedKneeRaises = 11us
    [<Literal>]
    let KneelingSuperman = 12us
    [<Literal>]
    let WeightedKneelingSuperman = 13us
    [<Literal>]
    let LatPullDownWithRow = 14us
    [<Literal>]
    let MedicineBallDeadliftToReach = 15us
    [<Literal>]
    let OneArmOneLegRow = 16us
    [<Literal>]
    let OneArmRowWithBand = 17us
    [<Literal>]
    let OverheadLungeWithMedicineBall = 18us
    [<Literal>]
    let PlankKneeTucks = 19us
    [<Literal>]
    let WeightedPlankKneeTucks = 20us
    [<Literal>]
    let SideStep = 21us
    [<Literal>]
    let WeightedSideStep = 22us
    [<Literal>]
    let SingleLegBackExtension = 23us
    [<Literal>]
    let WeightedSingleLegBackExtension = 24us
    [<Literal>]
    let SpineExtension = 25us
    [<Literal>]
    let WeightedSpineExtension = 26us
    [<Literal>]
    let StaticBackExtension = 27us
    [<Literal>]
    let WeightedStaticBackExtension = 28us
    [<Literal>]
    let SupermanFromFloor = 29us
    [<Literal>]
    let WeightedSupermanFromFloor = 30us
    [<Literal>]
    let SwissBallBackExtension = 31us
    [<Literal>]
    let WeightedSwissBallBackExtension = 32us
    [<Literal>]
    let SwissBallHyperextension = 33us
    [<Literal>]
    let WeightedSwissBallHyperextension = 34us
    [<Literal>]
    let SwissBallOppositeArmAndLegLift = 35us
    [<Literal>]
    let WeightedSwissBallOppositeArmAndLegLift = 36us
    [<Literal>]
    let SupermanOnSwissBall = 37us
    [<Literal>]
    let Cobra = 38us
    [<Literal>]
    let SupineFloorBarre = 39us

  module LateralRaiseExerciseName =
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _45DegreeCableExternalRotation = 0us
    [<Literal>]
    let AlternatingLateralRaiseWithStaticHold = 1us
    [<Literal>]
    let BarMuscleUp = 2us
    [<Literal>]
    let BentOverLateralRaise = 3us
    [<Literal>]
    let CableDiagonalRaise = 4us
    [<Literal>]
    let CableFrontRaise = 5us
    [<Literal>]
    let CalorieRow = 6us
    [<Literal>]
    let ComboShoulderRaise = 7us
    [<Literal>]
    let DumbbellDiagonalRaise = 8us
    [<Literal>]
    let DumbbellVRaise = 9us
    [<Literal>]
    let FrontRaise = 10us
    [<Literal>]
    let LeaningDumbbellLateralRaise = 11us
    [<Literal>]
    let LyingDumbbellRaise = 12us
    [<Literal>]
    let MuscleUp = 13us
    [<Literal>]
    let OneArmCableLateralRaise = 14us
    [<Literal>]
    let OverhandGripRearLateralRaise = 15us
    [<Literal>]
    let PlateRaises = 16us
    [<Literal>]
    let RingDip = 17us
    [<Literal>]
    let WeightedRingDip = 18us
    [<Literal>]
    let RingMuscleUp = 19us
    [<Literal>]
    let WeightedRingMuscleUp = 20us
    [<Literal>]
    let RopeClimb = 21us
    [<Literal>]
    let WeightedRopeClimb = 22us
    [<Literal>]
    let Scaption = 23us
    [<Literal>]
    let SeatedLateralRaise = 24us
    [<Literal>]
    let SeatedRearLateralRaise = 25us
    [<Literal>]
    let SideLyingLateralRaise = 26us
    [<Literal>]
    let StandingLift = 27us
    [<Literal>]
    let SuspendedRow = 28us
    [<Literal>]
    let UnderhandGripRearLateralRaise = 29us
    [<Literal>]
    let WallSlide = 30us
    [<Literal>]
    let WeightedWallSlide = 31us
    [<Literal>]
    let ArmCircles = 32us
    [<Literal>]
    let ShavingTheHead = 33us

  module LegCurlExerciseName =
    [<Literal>]
    let LegCurl = 0us
    [<Literal>]
    let WeightedLegCurl = 1us
    [<Literal>]
    let GoodMorning = 2us
    [<Literal>]
    let SeatedBarbellGoodMorning = 3us
    [<Literal>]
    let SingleLegBarbellGoodMorning = 4us
    [<Literal>]
    let SingleLegSlidingLegCurl = 5us
    [<Literal>]
    let SlidingLegCurl = 6us
    [<Literal>]
    let SplitBarbellGoodMorning = 7us
    [<Literal>]
    let SplitStanceExtension = 8us
    [<Literal>]
    let StaggeredStanceGoodMorning = 9us
    [<Literal>]
    let SwissBallHipRaiseAndLegCurl = 10us
    [<Literal>]
    let ZercherGoodMorning = 11us

  module LegRaiseExerciseName =
    [<Literal>]
    let HangingKneeRaise = 0us
    [<Literal>]
    let HangingLegRaise = 1us
    [<Literal>]
    let WeightedHangingLegRaise = 2us
    [<Literal>]
    let HangingSingleLegRaise = 3us
    [<Literal>]
    let WeightedHangingSingleLegRaise = 4us
    [<Literal>]
    let KettlebellLegRaises = 5us
    [<Literal>]
    let LegLoweringDrill = 6us
    [<Literal>]
    let WeightedLegLoweringDrill = 7us
    [<Literal>]
    let LyingStraightLegRaise = 8us
    [<Literal>]
    let WeightedLyingStraightLegRaise = 9us
    [<Literal>]
    let MedicineBallLegDrops = 10us
    [<Literal>]
    let QuadrupedLegRaise = 11us
    [<Literal>]
    let WeightedQuadrupedLegRaise = 12us
    [<Literal>]
    let ReverseLegRaise = 13us
    [<Literal>]
    let WeightedReverseLegRaise = 14us
    [<Literal>]
    let ReverseLegRaiseOnSwissBall = 15us
    [<Literal>]
    let WeightedReverseLegRaiseOnSwissBall = 16us
    [<Literal>]
    let SingleLegLoweringDrill = 17us
    [<Literal>]
    let WeightedSingleLegLoweringDrill = 18us
    [<Literal>]
    let WeightedHangingKneeRaise = 19us
    [<Literal>]
    let LateralStepover = 20us
    [<Literal>]
    let WeightedLateralStepover = 21us

  module LungeExerciseName =
    [<Literal>]
    let OverheadLunge = 0us
    [<Literal>]
    let LungeMatrix = 1us
    [<Literal>]
    let WeightedLungeMatrix = 2us
    [<Literal>]
    let AlternatingBarbellForwardLunge = 3us
    [<Literal>]
    let AlternatingDumbbellLungeWithReach = 4us
    [<Literal>]
    let BackFootElevatedDumbbellSplitSquat = 5us
    [<Literal>]
    let BarbellBoxLunge = 6us
    [<Literal>]
    let BarbellBulgarianSplitSquat = 7us
    [<Literal>]
    let BarbellCrossoverLunge = 8us
    [<Literal>]
    let BarbellFrontSplitSquat = 9us
    [<Literal>]
    let BarbellLunge = 10us
    [<Literal>]
    let BarbellReverseLunge = 11us
    [<Literal>]
    let BarbellSideLunge = 12us
    [<Literal>]
    let BarbellSplitSquat = 13us
    [<Literal>]
    let CoreControlRearLunge = 14us
    [<Literal>]
    let DiagonalLunge = 15us
    [<Literal>]
    let DropLunge = 16us
    [<Literal>]
    let DumbbellBoxLunge = 17us
    [<Literal>]
    let DumbbellBulgarianSplitSquat = 18us
    [<Literal>]
    let DumbbellCrossoverLunge = 19us
    [<Literal>]
    let DumbbellDiagonalLunge = 20us
    [<Literal>]
    let DumbbellLunge = 21us
    [<Literal>]
    let DumbbellLungeAndRotation = 22us
    [<Literal>]
    let DumbbellOverheadBulgarianSplitSquat = 23us
    [<Literal>]
    let DumbbellReverseLungeToHighKneeAndPress = 24us
    [<Literal>]
    let DumbbellSideLunge = 25us
    [<Literal>]
    let ElevatedFrontFootBarbellSplitSquat = 26us
    [<Literal>]
    let FrontFootElevatedDumbbellSplitSquat = 27us
    [<Literal>]
    let GunslingerLunge = 28us
    [<Literal>]
    let LawnmowerLunge = 29us
    [<Literal>]
    let LowLungeWithIsometricAdduction = 30us
    [<Literal>]
    let LowSideToSideLunge = 31us
    [<Literal>]
    let Lunge = 32us
    [<Literal>]
    let WeightedLunge = 33us
    [<Literal>]
    let LungeWithArmReach = 34us
    [<Literal>]
    let LungeWithDiagonalReach = 35us
    [<Literal>]
    let LungeWithSideBend = 36us
    [<Literal>]
    let OffsetDumbbellLunge = 37us
    [<Literal>]
    let OffsetDumbbellReverseLunge = 38us
    [<Literal>]
    let OverheadBulgarianSplitSquat = 39us
    [<Literal>]
    let OverheadDumbbellReverseLunge = 40us
    [<Literal>]
    let OverheadDumbbellSplitSquat = 41us
    [<Literal>]
    let OverheadLungeWithRotation = 42us
    [<Literal>]
    let ReverseBarbellBoxLunge = 43us
    [<Literal>]
    let ReverseBoxLunge = 44us
    [<Literal>]
    let ReverseDumbbellBoxLunge = 45us
    [<Literal>]
    let ReverseDumbbellCrossoverLunge = 46us
    [<Literal>]
    let ReverseDumbbellDiagonalLunge = 47us
    [<Literal>]
    let ReverseLungeWithReachBack = 48us
    [<Literal>]
    let WeightedReverseLungeWithReachBack = 49us
    [<Literal>]
    let ReverseLungeWithTwistAndOverheadReach = 50us
    [<Literal>]
    let WeightedReverseLungeWithTwistAndOverheadReach = 51us
    [<Literal>]
    let ReverseSlidingBoxLunge = 52us
    [<Literal>]
    let WeightedReverseSlidingBoxLunge = 53us
    [<Literal>]
    let ReverseSlidingLunge = 54us
    [<Literal>]
    let WeightedReverseSlidingLunge = 55us
    [<Literal>]
    let RunnersLungeToBalance = 56us
    [<Literal>]
    let WeightedRunnersLungeToBalance = 57us
    [<Literal>]
    let ShiftingSideLunge = 58us
    [<Literal>]
    let SideAndCrossoverLunge = 59us
    [<Literal>]
    let WeightedSideAndCrossoverLunge = 60us
    [<Literal>]
    let SideLunge = 61us
    [<Literal>]
    let WeightedSideLunge = 62us
    [<Literal>]
    let SideLungeAndPress = 63us
    [<Literal>]
    let SideLungeJumpOff = 64us
    [<Literal>]
    let SideLungeSweep = 65us
    [<Literal>]
    let WeightedSideLungeSweep = 66us
    [<Literal>]
    let SideLungeToCrossoverTap = 67us
    [<Literal>]
    let WeightedSideLungeToCrossoverTap = 68us
    [<Literal>]
    let SideToSideLungeChops = 69us
    [<Literal>]
    let WeightedSideToSideLungeChops = 70us
    [<Literal>]
    let SiffJumpLunge = 71us
    [<Literal>]
    let WeightedSiffJumpLunge = 72us
    [<Literal>]
    let SingleArmReverseLungeAndPress = 73us
    [<Literal>]
    let SlidingLateralLunge = 74us
    [<Literal>]
    let WeightedSlidingLateralLunge = 75us
    [<Literal>]
    let WalkingBarbellLunge = 76us
    [<Literal>]
    let WalkingDumbbellLunge = 77us
    [<Literal>]
    let WalkingLunge = 78us
    [<Literal>]
    let WeightedWalkingLunge = 79us
    [<Literal>]
    let WideGripOverheadBarbellSplitSquat = 80us

  module OlympicLiftExerciseName =
    [<Literal>]
    let BarbellHangPowerClean = 0us
    [<Literal>]
    let BarbellHangSquatClean = 1us
    [<Literal>]
    let BarbellPowerClean = 2us
    [<Literal>]
    let BarbellPowerSnatch = 3us
    [<Literal>]
    let BarbellSquatClean = 4us
    [<Literal>]
    let CleanAndJerk = 5us
    [<Literal>]
    let BarbellHangPowerSnatch = 6us
    [<Literal>]
    let BarbellHangPull = 7us
    [<Literal>]
    let BarbellHighPull = 8us
    [<Literal>]
    let BarbellSnatch = 9us
    [<Literal>]
    let BarbellSplitJerk = 10us
    [<Literal>]
    let Clean = 11us
    [<Literal>]
    let DumbbellClean = 12us
    [<Literal>]
    let DumbbellHangPull = 13us
    [<Literal>]
    let OneHandDumbbellSplitSnatch = 14us
    [<Literal>]
    let PushJerk = 15us
    [<Literal>]
    let SingleArmDumbbellSnatch = 16us
    [<Literal>]
    let SingleArmHangSnatch = 17us
    [<Literal>]
    let SingleArmKettlebellSnatch = 18us
    [<Literal>]
    let SplitJerk = 19us
    [<Literal>]
    let SquatCleanAndJerk = 20us

  module PlankExerciseName =
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _45DegreePlank = 0us
    [<Literal>]
    let Weighted45DegreePlank = 1us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _90DegreeStaticHold = 2us
    [<Literal>]
    let Weighted90DegreeStaticHold = 3us
    [<Literal>]
    let BearCrawl = 4us
    [<Literal>]
    let WeightedBearCrawl = 5us
    [<Literal>]
    let CrossBodyMountainClimber = 6us
    [<Literal>]
    let WeightedCrossBodyMountainClimber = 7us
    [<Literal>]
    let ElbowPlankPikeJacks = 8us
    [<Literal>]
    let WeightedElbowPlankPikeJacks = 9us
    [<Literal>]
    let ElevatedFeetPlank = 10us
    [<Literal>]
    let WeightedElevatedFeetPlank = 11us
    [<Literal>]
    let ElevatorAbs = 12us
    [<Literal>]
    let WeightedElevatorAbs = 13us
    [<Literal>]
    let ExtendedPlank = 14us
    [<Literal>]
    let WeightedExtendedPlank = 15us
    [<Literal>]
    let FullPlankPasseTwist = 16us
    [<Literal>]
    let WeightedFullPlankPasseTwist = 17us
    [<Literal>]
    let InchingElbowPlank = 18us
    [<Literal>]
    let WeightedInchingElbowPlank = 19us
    [<Literal>]
    let InchwormToSidePlank = 20us
    [<Literal>]
    let WeightedInchwormToSidePlank = 21us
    [<Literal>]
    let KneelingPlank = 22us
    [<Literal>]
    let WeightedKneelingPlank = 23us
    [<Literal>]
    let KneelingSidePlankWithLegLift = 24us
    [<Literal>]
    let WeightedKneelingSidePlankWithLegLift = 25us
    [<Literal>]
    let LateralRoll = 26us
    [<Literal>]
    let WeightedLateralRoll = 27us
    [<Literal>]
    let LyingReversePlank = 28us
    [<Literal>]
    let WeightedLyingReversePlank = 29us
    [<Literal>]
    let MedicineBallMountainClimber = 30us
    [<Literal>]
    let WeightedMedicineBallMountainClimber = 31us
    [<Literal>]
    let ModifiedMountainClimberAndExtension = 32us
    [<Literal>]
    let WeightedModifiedMountainClimberAndExtension = 33us
    [<Literal>]
    let MountainClimber = 34us
    [<Literal>]
    let WeightedMountainClimber = 35us
    [<Literal>]
    let MountainClimberOnSlidingDiscs = 36us
    [<Literal>]
    let WeightedMountainClimberOnSlidingDiscs = 37us
    [<Literal>]
    let MountainClimberWithFeetOnBosuBall = 38us
    [<Literal>]
    let WeightedMountainClimberWithFeetOnBosuBall = 39us
    [<Literal>]
    let MountainClimberWithHandsOnBench = 40us
    [<Literal>]
    let MountainClimberWithHandsOnSwissBall = 41us
    [<Literal>]
    let WeightedMountainClimberWithHandsOnSwissBall = 42us
    [<Literal>]
    let Plank = 43us
    [<Literal>]
    let PlankJacksWithFeetOnSlidingDiscs = 44us
    [<Literal>]
    let WeightedPlankJacksWithFeetOnSlidingDiscs = 45us
    [<Literal>]
    let PlankKneeTwist = 46us
    [<Literal>]
    let WeightedPlankKneeTwist = 47us
    [<Literal>]
    let PlankPikeJumps = 48us
    [<Literal>]
    let WeightedPlankPikeJumps = 49us
    [<Literal>]
    let PlankPikes = 50us
    [<Literal>]
    let WeightedPlankPikes = 51us
    [<Literal>]
    let PlankToStandUp = 52us
    [<Literal>]
    let WeightedPlankToStandUp = 53us
    [<Literal>]
    let PlankWithArmRaise = 54us
    [<Literal>]
    let WeightedPlankWithArmRaise = 55us
    [<Literal>]
    let PlankWithKneeToElbow = 56us
    [<Literal>]
    let WeightedPlankWithKneeToElbow = 57us
    [<Literal>]
    let PlankWithObliqueCrunch = 58us
    [<Literal>]
    let WeightedPlankWithObliqueCrunch = 59us
    [<Literal>]
    let PlyometricSidePlank = 60us
    [<Literal>]
    let WeightedPlyometricSidePlank = 61us
    [<Literal>]
    let RollingSidePlank = 62us
    [<Literal>]
    let WeightedRollingSidePlank = 63us
    [<Literal>]
    let SideKickPlank = 64us
    [<Literal>]
    let WeightedSideKickPlank = 65us
    [<Literal>]
    let SidePlank = 66us
    [<Literal>]
    let WeightedSidePlank = 67us
    [<Literal>]
    let SidePlankAndRow = 68us
    [<Literal>]
    let WeightedSidePlankAndRow = 69us
    [<Literal>]
    let SidePlankLift = 70us
    [<Literal>]
    let WeightedSidePlankLift = 71us
    [<Literal>]
    let SidePlankWithElbowOnBosuBall = 72us
    [<Literal>]
    let WeightedSidePlankWithElbowOnBosuBall = 73us
    [<Literal>]
    let SidePlankWithFeetOnBench = 74us
    [<Literal>]
    let WeightedSidePlankWithFeetOnBench = 75us
    [<Literal>]
    let SidePlankWithKneeCircle = 76us
    [<Literal>]
    let WeightedSidePlankWithKneeCircle = 77us
    [<Literal>]
    let SidePlankWithKneeTuck = 78us
    [<Literal>]
    let WeightedSidePlankWithKneeTuck = 79us
    [<Literal>]
    let SidePlankWithLegLift = 80us
    [<Literal>]
    let WeightedSidePlankWithLegLift = 81us
    [<Literal>]
    let SidePlankWithReachUnder = 82us
    [<Literal>]
    let WeightedSidePlankWithReachUnder = 83us
    [<Literal>]
    let SingleLegElevatedFeetPlank = 84us
    [<Literal>]
    let WeightedSingleLegElevatedFeetPlank = 85us
    [<Literal>]
    let SingleLegFlexAndExtend = 86us
    [<Literal>]
    let WeightedSingleLegFlexAndExtend = 87us
    [<Literal>]
    let SingleLegSidePlank = 88us
    [<Literal>]
    let WeightedSingleLegSidePlank = 89us
    [<Literal>]
    let SpidermanPlank = 90us
    [<Literal>]
    let WeightedSpidermanPlank = 91us
    [<Literal>]
    let StraightArmPlank = 92us
    [<Literal>]
    let WeightedStraightArmPlank = 93us
    [<Literal>]
    let StraightArmPlankWithShoulderTouch = 94us
    [<Literal>]
    let WeightedStraightArmPlankWithShoulderTouch = 95us
    [<Literal>]
    let SwissBallPlank = 96us
    [<Literal>]
    let WeightedSwissBallPlank = 97us
    [<Literal>]
    let SwissBallPlankLegLift = 98us
    [<Literal>]
    let WeightedSwissBallPlankLegLift = 99us
    [<Literal>]
    let SwissBallPlankLegLiftAndHold = 100us
    [<Literal>]
    let SwissBallPlankWithFeetOnBench = 101us
    [<Literal>]
    let WeightedSwissBallPlankWithFeetOnBench = 102us
    [<Literal>]
    let SwissBallProneJackknife = 103us
    [<Literal>]
    let WeightedSwissBallProneJackknife = 104us
    [<Literal>]
    let SwissBallSidePlank = 105us
    [<Literal>]
    let WeightedSwissBallSidePlank = 106us
    [<Literal>]
    let ThreeWayPlank = 107us
    [<Literal>]
    let WeightedThreeWayPlank = 108us
    [<Literal>]
    let TowelPlankAndKneeIn = 109us
    [<Literal>]
    let WeightedTowelPlankAndKneeIn = 110us
    [<Literal>]
    let TStabilization = 111us
    [<Literal>]
    let WeightedTStabilization = 112us
    [<Literal>]
    let TurkishGetUpToSidePlank = 113us
    [<Literal>]
    let WeightedTurkishGetUpToSidePlank = 114us
    [<Literal>]
    let TwoPointPlank = 115us
    [<Literal>]
    let WeightedTwoPointPlank = 116us
    [<Literal>]
    let WeightedPlank = 117us
    [<Literal>]
    let WideStancePlankWithDiagonalArmLift = 118us
    [<Literal>]
    let WeightedWideStancePlankWithDiagonalArmLift = 119us
    [<Literal>]
    let WideStancePlankWithDiagonalLegLift = 120us
    [<Literal>]
    let WeightedWideStancePlankWithDiagonalLegLift = 121us
    [<Literal>]
    let WideStancePlankWithLegLift = 122us
    [<Literal>]
    let WeightedWideStancePlankWithLegLift = 123us
    [<Literal>]
    let WideStancePlankWithOppositeArmAndLegLift = 124us
    [<Literal>]
    let WeightedMountainClimberWithHandsOnBench = 125us
    [<Literal>]
    let WeightedSwissBallPlankLegLiftAndHold = 126us
    [<Literal>]
    let WeightedWideStancePlankWithOppositeArmAndLegLift = 127us
    [<Literal>]
    let PlankWithFeetOnSwissBall = 128us
    [<Literal>]
    let SidePlankToPlankWithReachUnder = 129us
    [<Literal>]
    let BridgeWithGluteLowerLift = 130us
    [<Literal>]
    let BridgeOneLegBridge = 131us
    [<Literal>]
    let PlankWithArmVariations = 132us
    [<Literal>]
    let PlankWithLegLift = 133us
    [<Literal>]
    let ReversePlankWithLegPull = 134us

  module PlyoExerciseName =
    [<Literal>]
    let AlternatingJumpLunge = 0us
    [<Literal>]
    let WeightedAlternatingJumpLunge = 1us
    [<Literal>]
    let BarbellJumpSquat = 2us
    [<Literal>]
    let BodyWeightJumpSquat = 3us
    [<Literal>]
    let WeightedJumpSquat = 4us
    [<Literal>]
    let CrossKneeStrike = 5us
    [<Literal>]
    let WeightedCrossKneeStrike = 6us
    [<Literal>]
    let DepthJump = 7us
    [<Literal>]
    let WeightedDepthJump = 8us
    [<Literal>]
    let DumbbellJumpSquat = 9us
    [<Literal>]
    let DumbbellSplitJump = 10us
    [<Literal>]
    let FrontKneeStrike = 11us
    [<Literal>]
    let WeightedFrontKneeStrike = 12us
    [<Literal>]
    let HighBoxJump = 13us
    [<Literal>]
    let WeightedHighBoxJump = 14us
    [<Literal>]
    let IsometricExplosiveBodyWeightJumpSquat = 15us
    [<Literal>]
    let WeightedIsometricExplosiveJumpSquat = 16us
    [<Literal>]
    let LateralLeapAndHop = 17us
    [<Literal>]
    let WeightedLateralLeapAndHop = 18us
    [<Literal>]
    let LateralPlyoSquats = 19us
    [<Literal>]
    let WeightedLateralPlyoSquats = 20us
    [<Literal>]
    let LateralSlide = 21us
    [<Literal>]
    let WeightedLateralSlide = 22us
    [<Literal>]
    let MedicineBallOverheadThrows = 23us
    [<Literal>]
    let MedicineBallSideThrow = 24us
    [<Literal>]
    let MedicineBallSlam = 25us
    [<Literal>]
    let SideToSideMedicineBallThrows = 26us
    [<Literal>]
    let SideToSideShuffleJump = 27us
    [<Literal>]
    let WeightedSideToSideShuffleJump = 28us
    [<Literal>]
    let SquatJumpOntoBox = 29us
    [<Literal>]
    let WeightedSquatJumpOntoBox = 30us
    [<Literal>]
    let SquatJumpsInAndOut = 31us
    [<Literal>]
    let WeightedSquatJumpsInAndOut = 32us

  module PullUpExerciseName =
    [<Literal>]
    let BandedPullUps = 0us
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _30DegreeLatPulldown = 1us
    [<Literal>]
    let BandAssistedChinUp = 2us
    [<Literal>]
    let CloseGripChinUp = 3us
    [<Literal>]
    let WeightedCloseGripChinUp = 4us
    [<Literal>]
    let CloseGripLatPulldown = 5us
    [<Literal>]
    let CrossoverChinUp = 6us
    [<Literal>]
    let WeightedCrossoverChinUp = 7us
    [<Literal>]
    let EzBarPullover = 8us
    [<Literal>]
    let HangingHurdle = 9us
    [<Literal>]
    let WeightedHangingHurdle = 10us
    [<Literal>]
    let KneelingLatPulldown = 11us
    [<Literal>]
    let KneelingUnderhandGripLatPulldown = 12us
    [<Literal>]
    let LatPulldown = 13us
    [<Literal>]
    let MixedGripChinUp = 14us
    [<Literal>]
    let WeightedMixedGripChinUp = 15us
    [<Literal>]
    let MixedGripPullUp = 16us
    [<Literal>]
    let WeightedMixedGripPullUp = 17us
    [<Literal>]
    let ReverseGripPulldown = 18us
    [<Literal>]
    let StandingCablePullover = 19us
    [<Literal>]
    let StraightArmPulldown = 20us
    [<Literal>]
    let SwissBallEzBarPullover = 21us
    [<Literal>]
    let TowelPullUp = 22us
    [<Literal>]
    let WeightedTowelPullUp = 23us
    [<Literal>]
    let WeightedPullUp = 24us
    [<Literal>]
    let WideGripLatPulldown = 25us
    [<Literal>]
    let WideGripPullUp = 26us
    [<Literal>]
    let WeightedWideGripPullUp = 27us
    [<Literal>]
    let BurpeePullUp = 28us
    [<Literal>]
    let WeightedBurpeePullUp = 29us
    [<Literal>]
    let JumpingPullUps = 30us
    [<Literal>]
    let WeightedJumpingPullUps = 31us
    [<Literal>]
    let KippingPullUp = 32us
    [<Literal>]
    let WeightedKippingPullUp = 33us
    [<Literal>]
    let LPullUp = 34us
    [<Literal>]
    let WeightedLPullUp = 35us
    [<Literal>]
    let SuspendedChinUp = 36us
    [<Literal>]
    let WeightedSuspendedChinUp = 37us
    [<Literal>]
    let PullUp = 38us

  module PushUpExerciseName =
    [<Literal>]
    let ChestPressWithBand = 0us
    [<Literal>]
    let AlternatingStaggeredPushUp = 1us
    [<Literal>]
    let WeightedAlternatingStaggeredPushUp = 2us
    [<Literal>]
    let AlternatingHandsMedicineBallPushUp = 3us
    [<Literal>]
    let WeightedAlternatingHandsMedicineBallPushUp = 4us
    [<Literal>]
    let BosuBallPushUp = 5us
    [<Literal>]
    let WeightedBosuBallPushUp = 6us
    [<Literal>]
    let ClappingPushUp = 7us
    [<Literal>]
    let WeightedClappingPushUp = 8us
    [<Literal>]
    let CloseGripMedicineBallPushUp = 9us
    [<Literal>]
    let WeightedCloseGripMedicineBallPushUp = 10us
    [<Literal>]
    let CloseHandsPushUp = 11us
    [<Literal>]
    let WeightedCloseHandsPushUp = 12us
    [<Literal>]
    let DeclinePushUp = 13us
    [<Literal>]
    let WeightedDeclinePushUp = 14us
    [<Literal>]
    let DiamondPushUp = 15us
    [<Literal>]
    let WeightedDiamondPushUp = 16us
    [<Literal>]
    let ExplosiveCrossoverPushUp = 17us
    [<Literal>]
    let WeightedExplosiveCrossoverPushUp = 18us
    [<Literal>]
    let ExplosivePushUp = 19us
    [<Literal>]
    let WeightedExplosivePushUp = 20us
    [<Literal>]
    let FeetElevatedSideToSidePushUp = 21us
    [<Literal>]
    let WeightedFeetElevatedSideToSidePushUp = 22us
    [<Literal>]
    let HandReleasePushUp = 23us
    [<Literal>]
    let WeightedHandReleasePushUp = 24us
    [<Literal>]
    let HandstandPushUp = 25us
    [<Literal>]
    let WeightedHandstandPushUp = 26us
    [<Literal>]
    let InclinePushUp = 27us
    [<Literal>]
    let WeightedInclinePushUp = 28us
    [<Literal>]
    let IsometricExplosivePushUp = 29us
    [<Literal>]
    let WeightedIsometricExplosivePushUp = 30us
    [<Literal>]
    let JudoPushUp = 31us
    [<Literal>]
    let WeightedJudoPushUp = 32us
    [<Literal>]
    let KneelingPushUp = 33us
    [<Literal>]
    let WeightedKneelingPushUp = 34us
    [<Literal>]
    let MedicineBallChestPass = 35us
    [<Literal>]
    let MedicineBallPushUp = 36us
    [<Literal>]
    let WeightedMedicineBallPushUp = 37us
    [<Literal>]
    let OneArmPushUp = 38us
    [<Literal>]
    let WeightedOneArmPushUp = 39us
    [<Literal>]
    let WeightedPushUp = 40us
    [<Literal>]
    let PushUpAndRow = 41us
    [<Literal>]
    let WeightedPushUpAndRow = 42us
    [<Literal>]
    let PushUpPlus = 43us
    [<Literal>]
    let WeightedPushUpPlus = 44us
    [<Literal>]
    let PushUpWithFeetOnSwissBall = 45us
    [<Literal>]
    let WeightedPushUpWithFeetOnSwissBall = 46us
    [<Literal>]
    let PushUpWithOneHandOnMedicineBall = 47us
    [<Literal>]
    let WeightedPushUpWithOneHandOnMedicineBall = 48us
    [<Literal>]
    let ShoulderPushUp = 49us
    [<Literal>]
    let WeightedShoulderPushUp = 50us
    [<Literal>]
    let SingleArmMedicineBallPushUp = 51us
    [<Literal>]
    let WeightedSingleArmMedicineBallPushUp = 52us
    [<Literal>]
    let SpidermanPushUp = 53us
    [<Literal>]
    let WeightedSpidermanPushUp = 54us
    [<Literal>]
    let StackedFeetPushUp = 55us
    [<Literal>]
    let WeightedStackedFeetPushUp = 56us
    [<Literal>]
    let StaggeredHandsPushUp = 57us
    [<Literal>]
    let WeightedStaggeredHandsPushUp = 58us
    [<Literal>]
    let SuspendedPushUp = 59us
    [<Literal>]
    let WeightedSuspendedPushUp = 60us
    [<Literal>]
    let SwissBallPushUp = 61us
    [<Literal>]
    let WeightedSwissBallPushUp = 62us
    [<Literal>]
    let SwissBallPushUpPlus = 63us
    [<Literal>]
    let WeightedSwissBallPushUpPlus = 64us
    [<Literal>]
    let TPushUp = 65us
    [<Literal>]
    let WeightedTPushUp = 66us
    [<Literal>]
    let TripleStopPushUp = 67us
    [<Literal>]
    let WeightedTripleStopPushUp = 68us
    [<Literal>]
    let WideHandsPushUp = 69us
    [<Literal>]
    let WeightedWideHandsPushUp = 70us
    [<Literal>]
    let ParalletteHandstandPushUp = 71us
    [<Literal>]
    let WeightedParalletteHandstandPushUp = 72us
    [<Literal>]
    let RingHandstandPushUp = 73us
    [<Literal>]
    let WeightedRingHandstandPushUp = 74us
    [<Literal>]
    let RingPushUp = 75us
    [<Literal>]
    let WeightedRingPushUp = 76us
    [<Literal>]
    let PushUp = 77us
    [<Literal>]
    let PilatesPushup = 78us

  module RowExerciseName =
    [<Literal>]
    let BarbellStraightLegDeadliftToRow = 0us
    [<Literal>]
    let CableRowStanding = 1us
    [<Literal>]
    let DumbbellRow = 2us
    [<Literal>]
    let ElevatedFeetInvertedRow = 3us
    [<Literal>]
    let WeightedElevatedFeetInvertedRow = 4us
    [<Literal>]
    let FacePull = 5us
    [<Literal>]
    let FacePullWithExternalRotation = 6us
    [<Literal>]
    let InvertedRowWithFeetOnSwissBall = 7us
    [<Literal>]
    let WeightedInvertedRowWithFeetOnSwissBall = 8us
    [<Literal>]
    let KettlebellRow = 9us
    [<Literal>]
    let ModifiedInvertedRow = 10us
    [<Literal>]
    let WeightedModifiedInvertedRow = 11us
    [<Literal>]
    let NeutralGripAlternatingDumbbellRow = 12us
    [<Literal>]
    let OneArmBentOverRow = 13us
    [<Literal>]
    let OneLeggedDumbbellRow = 14us
    [<Literal>]
    let RenegadeRow = 15us
    [<Literal>]
    let ReverseGripBarbellRow = 16us
    [<Literal>]
    let RopeHandleCableRow = 17us
    [<Literal>]
    let SeatedCableRow = 18us
    [<Literal>]
    let SeatedDumbbellRow = 19us
    [<Literal>]
    let SingleArmCableRow = 20us
    [<Literal>]
    let SingleArmCableRowAndRotation = 21us
    [<Literal>]
    let SingleArmInvertedRow = 22us
    [<Literal>]
    let WeightedSingleArmInvertedRow = 23us
    [<Literal>]
    let SingleArmNeutralGripDumbbellRow = 24us
    [<Literal>]
    let SingleArmNeutralGripDumbbellRowAndRotation = 25us
    [<Literal>]
    let SuspendedInvertedRow = 26us
    [<Literal>]
    let WeightedSuspendedInvertedRow = 27us
    [<Literal>]
    let TBarRow = 28us
    [<Literal>]
    let TowelGripInvertedRow = 29us
    [<Literal>]
    let WeightedTowelGripInvertedRow = 30us
    [<Literal>]
    let UnderhandGripCableRow = 31us
    [<Literal>]
    let VGripCableRow = 32us
    [<Literal>]
    let WideGripSeatedCableRow = 33us

  module ShoulderPressExerciseName =
    [<Literal>]
    let AlternatingDumbbellShoulderPress = 0us
    [<Literal>]
    let ArnoldPress = 1us
    [<Literal>]
    let BarbellFrontSquatToPushPress = 2us
    [<Literal>]
    let BarbellPushPress = 3us
    [<Literal>]
    let BarbellShoulderPress = 4us
    [<Literal>]
    let DeadCurlPress = 5us
    [<Literal>]
    let DumbbellAlternatingShoulderPressAndTwist = 6us
    [<Literal>]
    let DumbbellHammerCurlToLungeToPress = 7us
    [<Literal>]
    let DumbbellPushPress = 8us
    [<Literal>]
    let FloorInvertedShoulderPress = 9us
    [<Literal>]
    let WeightedFloorInvertedShoulderPress = 10us
    [<Literal>]
    let InvertedShoulderPress = 11us
    [<Literal>]
    let WeightedInvertedShoulderPress = 12us
    [<Literal>]
    let OneArmPushPress = 13us
    [<Literal>]
    let OverheadBarbellPress = 14us
    [<Literal>]
    let OverheadDumbbellPress = 15us
    [<Literal>]
    let SeatedBarbellShoulderPress = 16us
    [<Literal>]
    let SeatedDumbbellShoulderPress = 17us
    [<Literal>]
    let SingleArmDumbbellShoulderPress = 18us
    [<Literal>]
    let SingleArmStepUpAndPress = 19us
    [<Literal>]
    let SmithMachineOverheadPress = 20us
    [<Literal>]
    let SplitStanceHammerCurlToPress = 21us
    [<Literal>]
    let SwissBallDumbbellShoulderPress = 22us
    [<Literal>]
    let WeightPlateFrontRaise = 23us

  module ShoulderStabilityExerciseName =
    [<Literal>]
    // fsharplint:disable-next-line: LiteralNames
    let _90DegreeCableExternalRotation = 0us
    [<Literal>]
    let BandExternalRotation = 1us
    [<Literal>]
    let BandInternalRotation = 2us
    [<Literal>]
    let BentArmLateralRaiseAndExternalRotation = 3us
    [<Literal>]
    let CableExternalRotation = 4us
    [<Literal>]
    let DumbbellFacePullWithExternalRotation = 5us
    [<Literal>]
    let FloorIRaise = 6us
    [<Literal>]
    let WeightedFloorIRaise = 7us
    [<Literal>]
    let FloorTRaise = 8us
    [<Literal>]
    let WeightedFloorTRaise = 9us
    [<Literal>]
    let FloorYRaise = 10us
    [<Literal>]
    let WeightedFloorYRaise = 11us
    [<Literal>]
    let InclineIRaise = 12us
    [<Literal>]
    let WeightedInclineIRaise = 13us
    [<Literal>]
    let InclineLRaise = 14us
    [<Literal>]
    let WeightedInclineLRaise = 15us
    [<Literal>]
    let InclineTRaise = 16us
    [<Literal>]
    let WeightedInclineTRaise = 17us
    [<Literal>]
    let InclineWRaise = 18us
    [<Literal>]
    let WeightedInclineWRaise = 19us
    [<Literal>]
    let InclineYRaise = 20us
    [<Literal>]
    let WeightedInclineYRaise = 21us
    [<Literal>]
    let LyingExternalRotation = 22us
    [<Literal>]
    let SeatedDumbbellExternalRotation = 23us
    [<Literal>]
    let StandingLRaise = 24us
    [<Literal>]
    let SwissBallIRaise = 25us
    [<Literal>]
    let WeightedSwissBallIRaise = 26us
    [<Literal>]
    let SwissBallTRaise = 27us
    [<Literal>]
    let WeightedSwissBallTRaise = 28us
    [<Literal>]
    let SwissBallWRaise = 29us
    [<Literal>]
    let WeightedSwissBallWRaise = 30us
    [<Literal>]
    let SwissBallYRaise = 31us
    [<Literal>]
    let WeightedSwissBallYRaise = 32us

  module ShrugExerciseName =
    [<Literal>]
    let BarbellJumpShrug = 0us
    [<Literal>]
    let BarbellShrug = 1us
    [<Literal>]
    let BarbellUprightRow = 2us
    [<Literal>]
    let BehindTheBackSmithMachineShrug = 3us
    [<Literal>]
    let DumbbellJumpShrug = 4us
    [<Literal>]
    let DumbbellShrug = 5us
    [<Literal>]
    let DumbbellUprightRow = 6us
    [<Literal>]
    let InclineDumbbellShrug = 7us
    [<Literal>]
    let OverheadBarbellShrug = 8us
    [<Literal>]
    let OverheadDumbbellShrug = 9us
    [<Literal>]
    let ScaptionAndShrug = 10us
    [<Literal>]
    let ScapularRetraction = 11us
    [<Literal>]
    let SerratusChairShrug = 12us
    [<Literal>]
    let WeightedSerratusChairShrug = 13us
    [<Literal>]
    let SerratusShrug = 14us
    [<Literal>]
    let WeightedSerratusShrug = 15us
    [<Literal>]
    let WideGripJumpShrug = 16us

  module SitUpExerciseName =
    [<Literal>]
    let AlternatingSitUp = 0us
    [<Literal>]
    let WeightedAlternatingSitUp = 1us
    [<Literal>]
    let BentKneeVUp = 2us
    [<Literal>]
    let WeightedBentKneeVUp = 3us
    [<Literal>]
    let ButterflySitUp = 4us
    [<Literal>]
    let WeightedButterflySitup = 5us
    [<Literal>]
    let CrossPunchRollUp = 6us
    [<Literal>]
    let WeightedCrossPunchRollUp = 7us
    [<Literal>]
    let CrossedArmsSitUp = 8us
    [<Literal>]
    let WeightedCrossedArmsSitUp = 9us
    [<Literal>]
    let GetUpSitUp = 10us
    [<Literal>]
    let WeightedGetUpSitUp = 11us
    [<Literal>]
    let HoveringSitUp = 12us
    [<Literal>]
    let WeightedHoveringSitUp = 13us
    [<Literal>]
    let KettlebellSitUp = 14us
    [<Literal>]
    let MedicineBallAlternatingVUp = 15us
    [<Literal>]
    let MedicineBallSitUp = 16us
    [<Literal>]
    let MedicineBallVUp = 17us
    [<Literal>]
    let ModifiedSitUp = 18us
    [<Literal>]
    let NegativeSitUp = 19us
    [<Literal>]
    let OneArmFullSitUp = 20us
    [<Literal>]
    let RecliningCircle = 21us
    [<Literal>]
    let WeightedRecliningCircle = 22us
    [<Literal>]
    let ReverseCurlUp = 23us
    [<Literal>]
    let WeightedReverseCurlUp = 24us
    [<Literal>]
    let SingleLegSwissBallJackknife = 25us
    [<Literal>]
    let WeightedSingleLegSwissBallJackknife = 26us
    [<Literal>]
    let TheTeaser = 27us
    [<Literal>]
    let TheTeaserWeighted = 28us
    [<Literal>]
    let ThreePartRollDown = 29us
    [<Literal>]
    let WeightedThreePartRollDown = 30us
    [<Literal>]
    let VUp = 31us
    [<Literal>]
    let WeightedVUp = 32us
    [<Literal>]
    let WeightedRussianTwistOnSwissBall = 33us
    [<Literal>]
    let WeightedSitUp = 34us
    [<Literal>]
    let XAbs = 35us
    [<Literal>]
    let WeightedXAbs = 36us
    [<Literal>]
    let SitUp = 37us

  module SquatExerciseName =
    [<Literal>]
    let LegPress = 0us
    [<Literal>]
    let BackSquatWithBodyBar = 1us
    [<Literal>]
    let BackSquats = 2us
    [<Literal>]
    let WeightedBackSquats = 3us
    [<Literal>]
    let BalancingSquat = 4us
    [<Literal>]
    let WeightedBalancingSquat = 5us
    [<Literal>]
    let BarbellBackSquat = 6us
    [<Literal>]
    let BarbellBoxSquat = 7us
    [<Literal>]
    let BarbellFrontSquat = 8us
    [<Literal>]
    let BarbellHackSquat = 9us
    [<Literal>]
    let BarbellHangSquatSnatch = 10us
    [<Literal>]
    let BarbellLateralStepUp = 11us
    [<Literal>]
    let BarbellQuarterSquat = 12us
    [<Literal>]
    let BarbellSiffSquat = 13us
    [<Literal>]
    let BarbellSquatSnatch = 14us
    [<Literal>]
    let BarbellSquatWithHeelsRaised = 15us
    [<Literal>]
    let BarbellStepover = 16us
    [<Literal>]
    let BarbellStepUp = 17us
    [<Literal>]
    let BenchSquatWithRotationalChop = 18us
    [<Literal>]
    let WeightedBenchSquatWithRotationalChop = 19us
    [<Literal>]
    let BodyWeightWallSquat = 20us
    [<Literal>]
    let WeightedWallSquat = 21us
    [<Literal>]
    let BoxStepSquat = 22us
    [<Literal>]
    let WeightedBoxStepSquat = 23us
    [<Literal>]
    let BracedSquat = 24us
    [<Literal>]
    let CrossedArmBarbellFrontSquat = 25us
    [<Literal>]
    let CrossoverDumbbellStepUp = 26us
    [<Literal>]
    let DumbbellFrontSquat = 27us
    [<Literal>]
    let DumbbellSplitSquat = 28us
    [<Literal>]
    let DumbbellSquat = 29us
    [<Literal>]
    let DumbbellSquatClean = 30us
    [<Literal>]
    let DumbbellStepover = 31us
    [<Literal>]
    let DumbbellStepUp = 32us
    [<Literal>]
    let ElevatedSingleLegSquat = 33us
    [<Literal>]
    let WeightedElevatedSingleLegSquat = 34us
    [<Literal>]
    let FigureFourSquats = 35us
    [<Literal>]
    let WeightedFigureFourSquats = 36us
    [<Literal>]
    let GobletSquat = 37us
    [<Literal>]
    let KettlebellSquat = 38us
    [<Literal>]
    let KettlebellSwingOverhead = 39us
    [<Literal>]
    let KettlebellSwingWithFlipToSquat = 40us
    [<Literal>]
    let LateralDumbbellStepUp = 41us
    [<Literal>]
    let OneLeggedSquat = 42us
    [<Literal>]
    let OverheadDumbbellSquat = 43us
    [<Literal>]
    let OverheadSquat = 44us
    [<Literal>]
    let PartialSingleLegSquat = 45us
    [<Literal>]
    let WeightedPartialSingleLegSquat = 46us
    [<Literal>]
    let PistolSquat = 47us
    [<Literal>]
    let WeightedPistolSquat = 48us
    [<Literal>]
    let PlieSlides = 49us
    [<Literal>]
    let WeightedPlieSlides = 50us
    [<Literal>]
    let PlieSquat = 51us
    [<Literal>]
    let WeightedPlieSquat = 52us
    [<Literal>]
    let PrisonerSquat = 53us
    [<Literal>]
    let WeightedPrisonerSquat = 54us
    [<Literal>]
    let SingleLegBenchGetUp = 55us
    [<Literal>]
    let WeightedSingleLegBenchGetUp = 56us
    [<Literal>]
    let SingleLegBenchSquat = 57us
    [<Literal>]
    let WeightedSingleLegBenchSquat = 58us
    [<Literal>]
    let SingleLegSquatOnSwissBall = 59us
    [<Literal>]
    let WeightedSingleLegSquatOnSwissBall = 60us
    [<Literal>]
    let Squat = 61us
    [<Literal>]
    let WeightedSquat = 62us
    [<Literal>]
    let SquatsWithBand = 63us
    [<Literal>]
    let StaggeredSquat = 64us
    [<Literal>]
    let WeightedStaggeredSquat = 65us
    [<Literal>]
    let StepUp = 66us
    [<Literal>]
    let WeightedStepUp = 67us
    [<Literal>]
    let SuitcaseSquats = 68us
    [<Literal>]
    let SumoSquat = 69us
    [<Literal>]
    let SumoSquatSlideIn = 70us
    [<Literal>]
    let WeightedSumoSquatSlideIn = 71us
    [<Literal>]
    let SumoSquatToHighPull = 72us
    [<Literal>]
    let SumoSquatToStand = 73us
    [<Literal>]
    let WeightedSumoSquatToStand = 74us
    [<Literal>]
    let SumoSquatWithRotation = 75us
    [<Literal>]
    let WeightedSumoSquatWithRotation = 76us
    [<Literal>]
    let SwissBallBodyWeightWallSquat = 77us
    [<Literal>]
    let WeightedSwissBallWallSquat = 78us
    [<Literal>]
    let Thrusters = 79us
    [<Literal>]
    let UnevenSquat = 80us
    [<Literal>]
    let WeightedUnevenSquat = 81us
    [<Literal>]
    let WaistSlimmingSquat = 82us
    [<Literal>]
    let WallBall = 83us
    [<Literal>]
    let WideStanceBarbellSquat = 84us
    [<Literal>]
    let WideStanceGobletSquat = 85us
    [<Literal>]
    let ZercherSquat = 86us
    [<Literal>]
    let KbsOverhead = 87us
    [<Literal>]
    let SquatAndSideKick = 88us
    [<Literal>]
    let SquatJumpsInNOut = 89us
    [<Literal>]
    let PilatesPlieSquatsParallelTurnedOutFlatAndHeels = 90us
    [<Literal>]
    let ReleveStraightLegAndKneeBentWithOneLegVariation = 91us

  module TotalBodyExerciseName =
    [<Literal>]
    let Burpee = 0us
    [<Literal>]
    let WeightedBurpee = 1us
    [<Literal>]
    let BurpeeBoxJump = 2us
    [<Literal>]
    let WeightedBurpeeBoxJump = 3us
    [<Literal>]
    let HighPullBurpee = 4us
    [<Literal>]
    let ManMakers = 5us
    [<Literal>]
    let OneArmBurpee = 6us
    [<Literal>]
    let SquatThrusts = 7us
    [<Literal>]
    let WeightedSquatThrusts = 8us
    [<Literal>]
    let SquatPlankPushUp = 9us
    [<Literal>]
    let WeightedSquatPlankPushUp = 10us
    [<Literal>]
    let StandingTRotationBalance = 11us
    [<Literal>]
    let WeightedStandingTRotationBalance = 12us

  module TricepsExtensionExerciseName =
    [<Literal>]
    let BenchDip = 0us
    [<Literal>]
    let WeightedBenchDip = 1us
    [<Literal>]
    let BodyWeightDip = 2us
    [<Literal>]
    let CableKickback = 3us
    [<Literal>]
    let CableLyingTricepsExtension = 4us
    [<Literal>]
    let CableOverheadTricepsExtension = 5us
    [<Literal>]
    let DumbbellKickback = 6us
    [<Literal>]
    let DumbbellLyingTricepsExtension = 7us
    [<Literal>]
    let EzBarOverheadTricepsExtension = 8us
    [<Literal>]
    let InclineDip = 9us
    [<Literal>]
    let WeightedInclineDip = 10us
    [<Literal>]
    let InclineEzBarLyingTricepsExtension = 11us
    [<Literal>]
    let LyingDumbbellPulloverToExtension = 12us
    [<Literal>]
    let LyingEzBarTricepsExtension = 13us
    [<Literal>]
    let LyingTricepsExtensionToCloseGripBenchPress = 14us
    [<Literal>]
    let OverheadDumbbellTricepsExtension = 15us
    [<Literal>]
    let RecliningTricepsPress = 16us
    [<Literal>]
    let ReverseGripPressdown = 17us
    [<Literal>]
    let ReverseGripTricepsPressdown = 18us
    [<Literal>]
    let RopePressdown = 19us
    [<Literal>]
    let SeatedBarbellOverheadTricepsExtension = 20us
    [<Literal>]
    let SeatedDumbbellOverheadTricepsExtension = 21us
    [<Literal>]
    let SeatedEzBarOverheadTricepsExtension = 22us
    [<Literal>]
    let SeatedSingleArmOverheadDumbbellExtension = 23us
    [<Literal>]
    let SingleArmDumbbellOverheadTricepsExtension = 24us
    [<Literal>]
    let SingleDumbbellSeatedOverheadTricepsExtension = 25us
    [<Literal>]
    let SingleLegBenchDipAndKick = 26us
    [<Literal>]
    let WeightedSingleLegBenchDipAndKick = 27us
    [<Literal>]
    let SingleLegDip = 28us
    [<Literal>]
    let WeightedSingleLegDip = 29us
    [<Literal>]
    let StaticLyingTricepsExtension = 30us
    [<Literal>]
    let SuspendedDip = 31us
    [<Literal>]
    let WeightedSuspendedDip = 32us
    [<Literal>]
    let SwissBallDumbbellLyingTricepsExtension = 33us
    [<Literal>]
    let SwissBallEzBarLyingTricepsExtension = 34us
    [<Literal>]
    let SwissBallEzBarOverheadTricepsExtension = 35us
    [<Literal>]
    let TabletopDip = 36us
    [<Literal>]
    let WeightedTabletopDip = 37us
    [<Literal>]
    let TricepsExtensionOnFloor = 38us
    [<Literal>]
    let TricepsPressdown = 39us
    [<Literal>]
    let WeightedDip = 40us

  module WarmUpExerciseName =
    [<Literal>]
    let QuadrupedRocking = 0us
    [<Literal>]
    let NeckTilts = 1us
    [<Literal>]
    let AnkleCircles = 2us
    [<Literal>]
    let AnkleDorsiflexionWithBand = 3us
    [<Literal>]
    let AnkleInternalRotation = 4us
    [<Literal>]
    let ArmCircles = 5us
    [<Literal>]
    let BentOverReachToSky = 6us
    [<Literal>]
    let CatCamel = 7us
    [<Literal>]
    let ElbowToFootLunge = 8us
    [<Literal>]
    let ForwardAndBackwardLegSwings = 9us
    [<Literal>]
    let Groiners = 10us
    [<Literal>]
    let InvertedHamstringStretch = 11us
    [<Literal>]
    let LateralDuckUnder = 12us
    [<Literal>]
    let NeckRotations = 13us
    [<Literal>]
    let OppositeArmAndLegBalance = 14us
    [<Literal>]
    let ReachRollAndLift = 15us
    [<Literal>]
    let Scorpion = 16us
    [<Literal>]
    let ShoulderCircles = 17us
    [<Literal>]
    let SideToSideLegSwings = 18us
    [<Literal>]
    let SleeperStretch = 19us
    [<Literal>]
    let SlideOut = 20us
    [<Literal>]
    let SwissBallHipCrossover = 21us
    [<Literal>]
    let SwissBallReachRollAndLift = 22us
    [<Literal>]
    let SwissBallWindshieldWipers = 23us
    [<Literal>]
    let ThoracicRotation = 24us
    [<Literal>]
    let WalkingHighKicks = 25us
    [<Literal>]
    let WalkingHighKnees = 26us
    [<Literal>]
    let WalkingKneeHugs = 27us
    [<Literal>]
    let WalkingLegCradles = 28us
    [<Literal>]
    let Walkout = 29us
    [<Literal>]
    let WalkoutFromPushUpPosition = 30us

  module RunExerciseName =
    [<Literal>]
    let Run = 0us
    [<Literal>]
    let Walk = 1us
    [<Literal>]
    let Jog = 2us
    [<Literal>]
    let Sprint = 3us

  module WaterType =
    [<Literal>]
    let Fresh = 0uy
    [<Literal>]
    let Salt = 1uy
    [<Literal>]
    let En13319 = 2uy
    [<Literal>]
    let Custom = 3uy

  module TissueModelType =
    [<Literal>]
    let Zhl16c = 0uy

  module DiveGasStatus =
    [<Literal>]
    let Disabled = 0uy
    [<Literal>]
    let Enabled = 1uy
    [<Literal>]
    let BackupOnly = 2uy

  module DiveAlarmType =
    [<Literal>]
    let Depth = 0uy
    [<Literal>]
    let Time = 1uy

  module DiveBacklightMode =
    [<Literal>]
    let AtDepth = 0uy
    [<Literal>]
    let AlwaysOn = 1uy

  module FaveroProduct =
    [<Literal>]
    let AssiomaUno = 10us
    [<Literal>]
    let AssiomaDuo = 12us

  module ClimbProEvent =
    [<Literal>]
    let Approach = 0uy
    [<Literal>]
    let Start = 1uy
    [<Literal>]
    let Complete = 2uy

  module TapSensitivity =
    [<Literal>]
    let High = 0uy
    [<Literal>]
    let Medium = 1uy
    [<Literal>]
    let Low = 2uy

  module RadarThreatLevelType =
    [<Literal>]
    let ThreatUnknown = 0uy
    [<Literal>]
    let ThreatNone = 1uy
    [<Literal>]
    let ThreatApproaching = 2uy
    [<Literal>]
    let ThreatApproachingFast = 3uy
