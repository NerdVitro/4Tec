; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "4Tec"
#define MyAppVersion "1.0"
#define MyAppPublisher "My Company, Inc."
#define MyAppExeName "SisCaixaEstoque.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{F2ED4E6C-0E74-4786-87D3-90B1468A2D2F}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
DefaultDirName={autopf}\{#MyAppName}
ChangesAssociations=yes
DisableProgramGroupPage=yes
; Uncomment the following line to run in non administrative install mode (install for current user only.)
;PrivilegesRequired=lowest
OutputDir=C:\Users\Second User\Desktop\Instalador 4tec
OutputBaseFilename=Instalador 4Tec
Compression=lzma
SolidCompression=yes
WizardStyle=modern

[Languages]
Name: "brazilianportuguese"; MessagesFile: "compiler:Languages\BrazilianPortuguese.isl"
Name: "portuguese"; MessagesFile: "compiler:Languages\Portuguese.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "D:\Publicação Sistemas\SisCaixaEstoque\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\ArquivoBanco.db"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\ClosedXML.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\DocumentFormat.OpenXml.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\EntityFramework.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\EntityFramework.SqlServer.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\ExcelNumberFormat.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\Irony.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SisCaixaEstoque.deps.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SisCaixaEstoque.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SisCaixaEstoque.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SisCaixaEstoque.pdb"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SisCaixaEstoque.runtimeconfig.json"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SixLabors.Fonts.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\SQLite.Interop.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\System.Data.SqlClient.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\System.Data.SQLite.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\System.Data.SQLite.EF6.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\XLParser.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "D:\Publicação Sistemas\SisCaixaEstoque\pt-BR\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
Source: "D:\Publicação Sistemas\SisCaixaEstoque\runtimes\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Registry]
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocExt}\OpenWithProgids"; ValueType: string; ValueName: "{#MyAppAssocKey}"; ValueData: ""; Flags: uninsdeletevalue
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}"; ValueType: string; ValueName: ""; ValueData: "{#MyAppAssocName}"; Flags: uninsdeletekey
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\DefaultIcon"; ValueType: string; ValueName: ""; ValueData: "{app}\{#MyAppExeName},0"
Root: HKA; Subkey: "Software\Classes\{#MyAppAssocKey}\shell\open\command"; ValueType: string; ValueName: ""; ValueData: """{app}\{#MyAppExeName}"" ""%1"""
Root: HKA; Subkey: "Software\Classes\Applications\{#MyAppExeName}\SupportedTypes"; ValueType: string; ValueName: ".myp"; ValueData: ""

[Icons]
Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent

