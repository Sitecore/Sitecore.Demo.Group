#####################################################
# 
#  Install Group.Demo.Local Certificate
# 
#####################################################
$ErrorActionPreference = 'Stop'

. $PSScriptRoot\settings.ps1

function Install-Sitecore-Cert {
    
    try
    {
        #Set web certificate on Sitecore site
        Install-SitecoreConfiguration $SitecoreSSLConfiguration `
                                      -SiteName $SitecoreSiteName `
                                      -HabitatSiteName $HabitatSiteName `
                                      -XConnectCert $XConnectCert
    }
    catch
    {
        write-host "Sitecore SSL Binding Failed" -ForegroundColor Red
        throw
    }
}

Install-Sitecore-Cert
