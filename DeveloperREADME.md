# Development Notes #

## Environment ##
1. Built using Visual Studio 2017 Community

## Deployment ##
1. EVOutllokPluginSetup requires Microsoft Visual Studio 2017 Install Projects, install from https://marketplace.visualstudio.com/items?itemName=VisualStudioClient.MicrosoftVisualStudio2017InstallerProjects
2. This Project will fail to build if the solution does not have both Debug and Release builds
3. The italian resource files have been added to the setup solution (Add Localisation resource) - seems to work
4. When the installer works, copy it to the Installer-Binaries folder

## Debugging ##
1. you can debug the plugin from visual studio.
2. Debugging requires the following fields are consistent with your Office Installation:
  - edit EisenVaultOutlookPlugin.csproj, change OfficeVersion and DebugInfoExeName to be the Version you have installed

## Localisation ##
Localisation has been implemented via resource files; it could have been done in the form but I feel is harder to maintain. 
The form design currently shows localisation but if you change the code in the designer you will loose the localisation at design time. 
Refer to the localiseInterface function in all form code for how to get design time localisation back. 
Read the comment in the code to enable localisation at design time.
1 create a new language resource file within visual studio
2 Use the Zeta Resource Editor to compare it against the other resource files and fill in the missing resources
3 Zeta Resource Editor available https://www.zeta-resource-editor.com/index.html

# Signing Key
Powershell as admin
New-SelfSignedCertificate -Type CodeSigningCert -Subject "CN=GitBuild, 0=NA, C=US" -TextExtension @("2.5.29.19={text}false") -KeyUsage DigitalSignature -KeyLength 2048 -NotAfter (Get-Date).AddMonths(33) -FriendlyName friendly
$pwd = ConvertTo-SecureString -String "password" -Force -AsPlainText
Export-PfxCertificate -cert "Cert:\LocalMachine\My\<thumbprint>" -FilePath TestSignature.pfx -Password $pwd