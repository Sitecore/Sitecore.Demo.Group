# Solution parameters
$SolutionPrefix = "group"
$SitePostFix = "dev.local"
$webroot = "C:\inetpub\wwwroot"
$HabitatSiteName = "habitat.dev.local"

$SitecoreVersion = "9.0.0 rev. 171002"
$InstallerVersion = "1.0.2"

# Certificates
$CertPath = "$PSScriptRoot\build\certificates"

$XConnectCert = "$HabitatSiteName.xConnect.Client"
$SitecoreSSLConfiguration = "$PSScriptRoot\build\certificates\sitecore-ssl.json"
$SitecoreSiteName = "$SolutionPrefix.$SitePostFix"


