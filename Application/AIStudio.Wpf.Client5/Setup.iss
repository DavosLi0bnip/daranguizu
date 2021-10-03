; Script generated by the Inno Setup Script Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "AIStudio.Wpf.Client"
#define MyAppVersion "1.5"
#define MyAppPublisher "AIStudio.Wpf.Client"
#define MyAppURL "https://gitee.com/akwkevin/aistudio.-wpf.-aclient"
#define MyAppExeName "AIStudio.Wpf.Client.exe"
#define MyAppAssocName MyAppName + " File"
#define MyAppAssocExt ".myp"
#define MyAppAssocKey StringChange(MyAppAssocName, " ", "") + MyAppAssocExt

[Setup]
; NOTE: The value of AppId uniquely identifies this application. Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{04875527-2B64-49C1-8922-039DB14E7D28}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={autopf}\{#MyAppName}
DisableProgramGroupPage=yes
; Remove the following line to run in administrative install mode (install for all users.)
PrivilegesRequired=lowest
OutputDir=E:\Dev
OutputBaseFilename={#MyAppName}
Compression=lzma
SolidCompression=yes
WizardStyle=modern
UsePreviousAppDir=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"
;Name: "chinesesimplified"; MessagesFile: "compiler:Languages\ChineseSimplified.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "F:\AClient\Application\AIStudio.Wpf.Client\bin\Release\netcoreapp3.1\publish\{#MyAppExeName}"; DestDir: "{app}"; Flags: ignoreversion
Source: "F:\AClient\Application\AIStudio.Wpf.Client\bin\Release\netcoreapp3.1\publish\*"; DestDir: "{app}"; Flags: ignoreversion recursesubdirs createallsubdirs
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

;[Icons]
;Name: "{autoprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
;Name: "{autodesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent


[Code]
procedure InitializeWizard();
begin
    WizardForm.BorderStyle:=bsNone;
end; 
procedure CurPageChanged(CurPageID: Integer);
begin
   WizardForm.ClientWidth := ScaleX(0)
   WizardForm.ClientHeight := ScaleY(0)
if CurPageID = wpWelcome then
WizardForm.NextButton.OnClick(WizardForm);
if CurPageID >= wpInstalling then
    WizardForm.Visible := False
  else
    WizardForm.Visible := True;
 end;
 
function ShouldSkipPage(PageID: Integer): Boolean;
begin
result := true;
end;
