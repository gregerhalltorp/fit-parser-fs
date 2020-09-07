namespace Fit2

type MesgNum =
  | FileId = 0us
  | Capabilities = 1us
  | DeviceSettings = 2us
  | UserProfile = 3us
  | HrmProfile = 4us
  | SdmProfile = 5us
  | BikeProfile = 6us
  | ZonesTarget = 7us
  | HrZone = 8us
  | PowerZone = 9us
  | MetZone = 10us
  | Sport = 12us
  | Goal = 15us
  | Session = 18us
  | Lap = 19us
  | Record = 20us
  | Event = 21us
  | DeviceInfo = 23us
  | Workout = 26us
  | WorkoutStep = 27us
  | Schedule = 28us
  | WeightScale = 30us
  | Course = 31us
  | CoursePoint = 32us
  | Totals = 33us
  | Activity = 34us
  | Software = 35us
  | FileCapabilities = 37us
  | MesgCapabilities = 38us
  | FieldCapabilities = 39us
  | FileCreator = 49us
  | BloodPressure = 51us
  | SpeedZone = 53us
  | Monitoring = 55us
  | TrainingFile = 72us
  | Hrv = 78us
  | AntRx = 80us
  | AntTx = 81us
  | AntChannelId = 82us
  | Length = 101us
  | MonitoringInfo = 103us
  | Pad = 105us
  | SlaveDevice = 106us
  | Connectivity = 127us
  | WeatherConditions = 128us
  | WeatherAlert = 129us
  | CadenceZone = 131us
  | Hr = 132us
  | SegmentLap = 142us
  | MemoGlob = 145us
  | SegmentId = 148us
  | SegmentLeaderboardEntry = 149us
  | SegmentPoint = 150us
  | SegmentFile = 151us
  | WorkoutSession = 158us
  | WatchfaceSettings = 159us
  | GpsMetadata = 160us
  | CameraEvent = 161us
  | TimestampCorrelation = 162us
  | GyroscopeData = 164us
  | AccelerometerData = 165us
  | ThreeDSensorCalibration = 167us
  | VideoFrame = 169us
  | ObdiiData = 174us
  | NmeaSentence = 177us
  | AviationAttitude = 178us
  | Video = 184us
  | VideoTitle = 185us
  | VideoDescription = 186us
  | VideoClip = 187us
  | OhrSettings = 188us
  | ExdScreenConfiguration = 200us
  | ExdDataFieldConfiguration = 201us
  | ExdDataConceptConfiguration = 202us
  | FieldDescription = 206us
  | DeveloperDataId = 207us
  | MagnetometerData = 208us
  | BarometerData = 209us
  | OneDSensorCalibration = 210us
  | Set = 225us
  | StressLevel = 227us
  | DiveSettings = 258us
  | DiveGas = 259us
  | DiveAlarm = 262us
  | ExerciseTitle = 264us
  | DiveSummary = 268us
  | Jump = 285us
  | ClimbPro = 317us
  | MfgRangeMin = 0xFF00us
  | MfgRangeMax = 0xFFFEus
  | Invalid = 0xFFFFus