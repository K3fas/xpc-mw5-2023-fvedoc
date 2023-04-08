# Assignment
Create tool for:
- Generating photovoltaic documentation for PV projects
  - Generate documentation based on PV configuration and customer info
  - Probably using QuestPDF
- Store information about past/todo/upcoming orders
  - Displayed in some kind of dashboard
- Create questionnare for gathering customer and installation info
  - e.g. Name, adress, town ...
  - e.g. PV Power, configuration ...
- Data will be stored in persistent database
  - Probably MongoDB
- Frontend diveded into 3 parts:
  - Admin
  - Project designer
  - Questionnare
- Frontend using Blazor/Razor

Main goal is to create tool for generating PV documentation which is more error proof than just writing in word document. 


# Data models

## Customer
- Name
- Adress
    - Town
    - Street
    - PSC
- Company?


## Cadastre data
- ParcelNumber
- TownID
- CadastreID
- PLNumber (Property List Number)


## PropertyInfo
- CadastreData
- MainCB
- MainSWPlace
- OccupantsCount
- Heating
- WaterHeating


## InstallationInfo
- InstallationType
- List[Strings(FVE strings)]
- TechnologyLocation
- CYADiameter
- SolarCable 

## InstallationType
- FVEType
- Power
- Inverter
- FVPanel + count
- BatteryPack
- CarCharger?

## InverterModel
- Name
- SVT
- MaxDCPower
- MaxACPower
- MaxDCInputVoltage
- NominalACOutputVoltage
- Efficiency
- IPCover

## FVPanelModel
- Name
- SVT
- Power
- Efficiency
- MaxPowerVoltage
- MaxPowerCurrent
- NLVoltage (No-Load)
- SCCurrent (Short-Circuit)
- Size (SxHxV)
- Weight

## BatteryPackModel
- Name
- Capacity
- BatteryBlockCount
- BatteryBlockCapacity
- BatteryTechnology
- NominalVoltage
- LifeExpectancy
- ContinuosDischarge (kW)
- ContinuosCharge (kW)
- Size (SxHxV)
- Weight

## CarChargerModel
- Name
- Power


## FVETypeModel
e.g. FVE typ-Ac1W
- MainType (A-X; based on used combination of INV and BAT)
- SubType (a-x; based on used FV Panel type)
- SubSubType? (1-10; based on installed FV Power)
- CarCharger (W; has car charger installed)


## OrderModel
- FVEID
- FVEType
- Customer
- PropertyInfo
- InstallationInfo


