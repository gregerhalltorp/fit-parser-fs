namespace Fit2

open TypeDefinitions

module Messages =
  let fileIdMessage =
    { dataMessageBase with
        name = "FileId"
        number = MesgNum.FileId
        fields =
          [ { baseField with
                name = "Type"
                num = 0uy
                profileType = File }
            { baseField with
                name = "Manufacturer"
                num = 1uy
                fieldType = FitBaseType.Uint16
                profileType = Manufacturer }
            { baseField with
                name = "Product"
                num = 2uy
                fieldType = FitBaseType.Uint16
                profileType = Uint16
                subFields =
                  [ { name = "FaveroProduct"
                      fieldType = FitBaseType.Uint16
                      scale = 1.0
                      offset = 1.0
                      units = ""
                      maps =
                        [ { refFieldNum = 1uy
                            refFieldValue = 263 } ] }
                    { name = "GarminProduct"
                      fieldType = FitBaseType.Uint16
                      scale = 1.0
                      offset = 1.0
                      units = ""
                      maps =
                        [ { refFieldNum = 1uy; refFieldValue = 1 }
                          { refFieldNum = 1uy
                            refFieldValue = 15 }
                          { refFieldNum = 1uy
                            refFieldValue = 13 } ] } ] }
            { baseField with
                name = "SerialNumber"
                num = 3uy
                fieldType = FitBaseType.Uint32z
                profileType = Uint32z }
            { baseField with
                name = "TimeCreated"
                num = 4uy
                fieldType = FitBaseType.Uint32
                profileType = DateTime }
            { baseField with
                name = "Number"
                num = 5uy
                fieldType = FitBaseType.Uint16
                profileType = Uint16 }
            { baseField with
                name = "ProductName"
                num = 8uy
                fieldType = FitBaseType.String
                profileType = String } ] }
